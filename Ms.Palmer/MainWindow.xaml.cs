using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ms.Palmer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Boolean IsVirtualizationEnabled = false;
        private Boolean IsHypervisorPresent = false;

        private VM_Config SetupInstallScript;

        public MainWindow()
        {

            InitializeComponent();

            CheckVirtualizationStatus();

            CheckHypervisors();

          

        }

        private Boolean CheckVirtualizationStatus()
        {
            //The following programming statement was adapted from C-SharpCorner:
            //Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            //Author: Aman
            //Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            ProcessStartInfo NewProcess = new ProcessStartInfo();

            //The following programming statement was adapted from C-SharpCorner:
            //Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            //Author: Aman
            //Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            NewProcess.FileName = "cmd.exe";

            //The following programming statement was adapted from C-SharpCorner:
            //Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            //Author: Aman
            //Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            NewProcess.WorkingDirectory = @"C:\";

            NewProcess.Arguments = " /C systeminfo";

            //This programming statement was adapted from StackOverflow:
            //Link: https://stackoverflow.com/questions/3440105/hide-command-window-in-c-sharp-application
            //Author: ajay_whiz
            //Author Profile Link: https://stackoverflow.com/users/398368/ajay-whiz
            NewProcess.WindowStyle = ProcessWindowStyle.Hidden;

            //The following programming statement was adapted from C-SharpCorner:
            //Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            //Author: Aman
            //Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            Process StartCheck = new Process();

            //The following programming statement was adapted from C-SharpCorner:
            //Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            //Author: Aman
            //Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            StartCheck.StartInfo = NewProcess;

            try
            {

                if (StartCheck.Start())
                {

                    foreach (var Line in StartCheck.StandardOutput.ReadToEnd())
                    {

                        if (Line.ToString().Contains("A hypervisor has been detected"))
                        {

                            IsVirtualizationEnabled = true;

                            StartCheck.Kill();

                        }
                    }
                }
                else
                {
                    IsVirtualizationEnabled = false;
                }
            }
            catch (Exception VirtulizationStatusNotFound)
            {

                //throw new Exception("Virtualization Status could not be determined due to virtualization technologies (AMD-V, Intel VT-D) not being enabled in the BIOS.");
            }



            return IsVirtualizationEnabled;
        }

        private Boolean CheckHypervisors()
        {
            //The following programming statement was adapted from C-SharpCorner:
            //Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            //Author: Aman
            //Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            ProcessStartInfo CheckAvailableHyperVisors = new ProcessStartInfo();

            //The following programming statement was adapted from C-SharpCorner:
            //Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            //Author: Aman
            //Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            CheckAvailableHyperVisors.FileName = "cmd.exe";

            //The following programming statement was adapted from C-SharpCorner:
            //Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            //Author: Aman
            //Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            CheckAvailableHyperVisors.WorkingDirectory = @"C:\";

            CheckAvailableHyperVisors.Arguments = "cd /PROGRA~1 && DIR Oracle";

            //This programming statement was adapted from StackOverflow:
            //Link: https://stackoverflow.com/questions/3440105/hide-command-window-in-c-sharp-application
            //Author: ajay_whiz
            //Author Profile Link: https://stackoverflow.com/users/398368/ajay-whiz
            CheckAvailableHyperVisors.WindowStyle = ProcessWindowStyle.Hidden;

            //The following programming statement was adapted from C-SharpCorner:
            //Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            //Author: Aman
            //Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            Process StartCheck = new Process();

            //The following programming statement was adapted from C-SharpCorner:
            //Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            //Author: Aman
            //Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            StartCheck.StartInfo = CheckAvailableHyperVisors;

            try
            {

                if (StartCheck.Start())
                {

                    foreach (var Line in StartCheck.StandardOutput.ReadToEnd())
                    {

                        if (Line.ToString().Contains("VirtualBox"))
                        {

                            IsHypervisorPresent = true;

                            StartCheck.Kill();

                        }
                    }
                }
                else
                {
                    IsHypervisorPresent = false;
                }
            }
            catch (Exception HyperVisorsNotFound)
            {

                //throw new Exception(" A hypervisor was not found in this system. Please install a virtual machine hypervior and restart the program.");
            }

            return IsHypervisorPresent;
        }

        private void UseCaseOne_Click(object sender, RoutedEventArgs e)
        {
            SetupInstallScript = new VM_Config((string)UseCaseOne.Content);
            SetupInstallScript.Show();

            this.Hide();
            this.Close();

        }

        private void UseCaseTwo_Click(object sender, RoutedEventArgs e)
        {
            SetupInstallScript = new VM_Config((string)UseCaseTwo.Content);
            SetupInstallScript.Show();

            this.Hide();
            this.Close();
        }

        private void UseCaseThree_Click(object sender, RoutedEventArgs e)
        {
            SetupInstallScript = new VM_Config((string)UseCaseThree.Content);
            SetupInstallScript.Show();

            this.Hide();
            this.Close();
        }

        private void UseCaseFour_Click(object sender, RoutedEventArgs e)
        {
            SetupInstallScript = new VM_Config((string)UseCaseFour.Content);
            SetupInstallScript.Show();

            this.Hide();
            this.Close();
        }

        private void VirtualizationStatus_Initialized_1(object sender, EventArgs e)
        {
            if (IsVirtualizationEnabled == true)
            {

                VirtualizationStatus.Content = "Virtualization Status: Enabled";
            }
            else
            {
                VirtualizationStatus.Content = "Virtualization Status: Disabled";
            }
        }

        private void HyperVisorStatus_Initialized_1(object sender, EventArgs e)
        {
            if (IsHypervisorPresent == true)
            {
                HyperVisorStatus.Content = "Hypervisor Status: Hypervisors Found Successfully!";
            }
            else
            {
                HyperVisorStatus.Content = "Hypervisor Status:"+"\n"+"No Hypervisor's have been found";

            }
        }
    }

    
}
