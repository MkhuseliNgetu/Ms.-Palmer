using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

       
        public VM_Report()
        {
            InitializeComponent();

          
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
            OpenAvailableHyperVisors.WorkingDirectory = @"C:\PROGRA~1\Oracle\VirtualBox";

            OpenAvailableHyperVisors.Arguments = " /C start VirtualBox";

            OpenAvailableHyperVisors.RedirectStandardOutput = true;
            OpenAvailableHyperVisors.UseShellExecute = false;
            OpenAvailableHyperVisors.RedirectStandardInput = true;
            OpenAvailableHyperVisors.CreateNoWindow = true;

            //The following programming statement was adapted from C-SharpCorner:
            //Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            //Author: Aman
            //Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            Process StartHypervisor = new Process();

            //The following programming statement was adapted from C-SharpCorner:
            //Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            //Author: Aman
            //Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            StartHypervisor.StartInfo = OpenAvailableHyperVisors;

           
            StartHypervisor.Start();

            System.Environment.Exit(0);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void VMConfigView1_Initialized(object sender, EventArgs e)
        {
            VMConfigView1.Text = "Your virtual machine has been configured sucessfully." +"\n";
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
