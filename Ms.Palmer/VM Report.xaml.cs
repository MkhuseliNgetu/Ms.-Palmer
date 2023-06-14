using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ms.Palmer
{
    /// <summary>
    /// Interaction logic for VM_Report.xaml
    /// </summary>
    public partial class VM_Report : Window
    {

        private Stack<String> PassedConfig;
        public VM_Report(Stack<String> FullVMConfig)
        {
            InitializeComponent();

            PassedConfig = FullVMConfig;
        }

        private void OpenHypervisor_Click(object sender, RoutedEventArgs e)
        {
  

            //The following programming statement was adapted from C-SharpCorner:
            //Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            //Author: Aman
            //Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            ProcessStartInfo OpenAvailableHyperVisors = new ProcessStartInfo();

            //The following programming statement was adapted from C-SharpCorner:
            //Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            //Author: Aman
            //Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            OpenAvailableHyperVisors.FileName = "cmd.exe";

            //The following programming statement was adapted from C-SharpCorner:
            //Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            //Author: Aman
            //Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            OpenAvailableHyperVisors.WorkingDirectory = @"C:\";

            OpenAvailableHyperVisors.Arguments = "cd /PROGRA~1/Oracle/VirtualBox && start VirtualBox";

            //This programming statement was adapted from StackOverflow:
            //Link: https://stackoverflow.com/questions/3440105/hide-command-window-in-c-sharp-application
            //Author: ajay_whiz
            //Author Profile Link: https://stackoverflow.com/users/398368/ajay-whiz
            OpenAvailableHyperVisors.WindowStyle = ProcessWindowStyle.Hidden;

            //The following programming statement was adapted from C-SharpCorner:
            //Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            //Author: Aman
            //Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            Process StartVirtualBox = new Process();

            //The following programming statement was adapted from C-SharpCorner:
            //Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            //Author: Aman
            //Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            StartVirtualBox.StartInfo = OpenAvailableHyperVisors;

            try
            {
                StartVirtualBox.Start();
                
                this.Hide();
               

            }catch (Exception FailedToOperHyperVisor)
            {

                //throw new Exception("Could not open hypervisor: Hypervisor Error"); 

            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void VMConfigView1_Initialized(object sender, EventArgs e)
        {
            VMConfigView1.Text = "Your virutal machine has been configured suceessfully." +"\n";
            VMConfigView1.AppendText("To use your virtual machine you can either click on 'Open Hypervisor' or close the application and open your hypervisor manually."+
                                    "\n"+"Thank you for using Ms. Palmer.");

            //Fix Bug
            //for (int LC = PassedConfig.Count() - 1; LC >= 0; LC--)
            //{

            //    VMConfigView1.AppendText(PassedConfig.ElementAt(LC));
            //}
        }
    }
}
