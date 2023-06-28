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
        private bool IsVirtualizationEnabled;
        private bool IsHypervisorPresent;

        private VM_Config SetupInstallScript;

        public MainWindow()
        {
            InitializeComponent();

            CheckVirtualizationStatus();

            CheckHypervisors();

        }

        private bool CheckVirtualizationStatus()
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

            NewProcess.Arguments = " /c systeminfo";

            NewProcess.RedirectStandardOutput = true;
            NewProcess.UseShellExecute = false;
            NewProcess.RedirectStandardInput = true;
            NewProcess.CreateNoWindow = true;

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

           
                if (StartCheck.Start())
                {
                    StartCheck.WaitForExit();

                    if (StartCheck.ExitCode == 0)
                    {

                        IsVirtualizationEnabled = true;
                      
                    }
                    else if (StartCheck.ExitCode == 1)
                    {

                        IsVirtualizationEnabled = false;
                        
                    }
                }


            if (IsVirtualizationEnabled == true)
            {

                VirtualizationStatus.Content = "Virtualization: Enabled";
            }
            else if (IsVirtualizationEnabled == false)
            {
                VirtualizationStatus.Content = "Virtualization: Disabled";
               
            }

            return IsVirtualizationEnabled;
        }

        private bool CheckHypervisors()
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

            CheckAvailableHyperVisors.Arguments = " /c cd /PROGRA~1 && DIR Oracle";

            CheckAvailableHyperVisors.RedirectStandardOutput = true;
            CheckAvailableHyperVisors.UseShellExecute = false;
            CheckAvailableHyperVisors.RedirectStandardInput = true;
            CheckAvailableHyperVisors.CreateNoWindow = true;

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

           
                if (StartCheck.Start())
                {
                     StartCheck.WaitForExit();

                    if (StartCheck.ExitCode == 0)
                    {
                        IsHypervisorPresent = true; 
                    }
                    else if (StartCheck.ExitCode == 1)
                    {
                        IsHypervisorPresent = false;
                        
                    }

                   
                }


            if (IsHypervisorPresent == true)
            {
                HyperVisorStatus.Content = "Hypervisor's: Hypervisor available!";
            }
            else if (IsHypervisorPresent == false)
            {
                HyperVisorStatus.Content = "Hypervisor's: Hypervisor unavailable";
                

            }

            return IsHypervisorPresent;
        }

        private void UseCaseOne_Click(object sender, RoutedEventArgs e)
        {
            UseCaseOne.Content = "Gaming";
            SetupInstallScript = new VM_Config((string)UseCaseOne.Content);
            SetupInstallScript.Show();

            this.Hide();
            this.Close();

        }

        private void UseCaseTwo_Click(object sender, RoutedEventArgs e)
        {
            UseCaseTwo.Content = "Work";
            SetupInstallScript = new VM_Config((string)UseCaseTwo.Content);
            SetupInstallScript.Show();

            this.Hide();
            this.Close();
        }

        private void UseCaseThree_Click(object sender, RoutedEventArgs e)
        {
            UseCaseThree.Content = "Education";
            SetupInstallScript = new VM_Config((string)UseCaseThree.Content);
            SetupInstallScript.Show();

            this.Hide();
            this.Close();
        }

        private void UseCaseFour_Click(object sender, RoutedEventArgs e)
        {
            UseCaseFour.Content = "Entertainment";
            SetupInstallScript = new VM_Config((string)UseCaseFour.Content);
            SetupInstallScript.Show();

            this.Hide();
            this.Close();
        }

        private void VirtualizationStatus_Initialized_1(object sender, EventArgs e)
        {
          
        }

        private void HyperVisorStatus_Initialized_1(object sender, EventArgs e)
        {
           
        }
    }

    
}
