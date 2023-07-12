using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mime;
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
using System.Windows.Shapes;

namespace Ms.Palmer
{
    /// <summary>
    /// Interaction logic for LoadingConfig.xaml
    /// </summary>
    public partial class LoadingConfig : Window
    {

        private WebClient ISODownloader;
        private Stack<String> PassedConfig;

        private VM_Report VMReport;
        private bool IsVirtualMachineDeploymentComplete;
        private bool IsGuestAdditionsPresent;
        private bool IsDownloadComplete;
        private bool IsSoftwareLoaded;


        public LoadingConfig(Stack<String> FullVMConfig)
        {
            InitializeComponent();
            PassedConfig = new Stack<String>();
            PassedConfig = FullVMConfig;

            Thread RunVMSetup = new Thread(CreateVM);
            Thread RunVMSetupTwo = new Thread(LoadSoftware);
            Thread RunVMSetupThree = new Thread(CheckAdditions);

            RunVMSetup.Start();

            Thread.Sleep(5000);

            RunVMSetupTwo.Start();

            Thread.Sleep(5000);

            RunVMSetupThree.Start();
        }

        private void CreateVM()
        {

            
            foreach (var DC in PassedConfig)
            {

                Debug.WriteLine(DC);
            }

            Debug.WriteLine("VM Size: " + Convert.ToString(Convert.ToInt64(PassedConfig.ElementAt(5)) * 1024));
     
            ProcessStartInfo CreateAVirtualMachine = new ProcessStartInfo();

            CreateAVirtualMachine.FileName = "cmd.exe";
            CreateAVirtualMachine.WorkingDirectory = @"C:\PROGRA~1\Oracle\VirtualBox\";

            CreateAVirtualMachine.Arguments = " /c VBoxManage createvm --name "+PassedConfig.ElementAt(8)+" --ostype Linux_64 --register && " +
                                            "VBoxManage createhd --filename C:/Users/%USERNAME%/VirtualBox/"+PassedConfig.ElementAt(8)+"/"+PassedConfig.ElementAt(8)+".vdi --size "+ Convert.ToString(Convert.ToInt64(PassedConfig.ElementAt(5)) * 1024);
            CreateAVirtualMachine.RedirectStandardOutput = true;
            CreateAVirtualMachine.UseShellExecute = false;
            CreateAVirtualMachine.RedirectStandardInput = true;
            CreateAVirtualMachine.CreateNoWindow = true;

           
            ProcessStartInfo AddVirtualMachineStorage = new ProcessStartInfo();

            AddVirtualMachineStorage.FileName = "cmd.exe";
            AddVirtualMachineStorage.WorkingDirectory = @"C:\PROGRA~1\Oracle\VirtualBox\";

          
            AddVirtualMachineStorage.Arguments = " /c VBoxManage storagectl "+PassedConfig.ElementAt(8)+" --name 'Drive-Controller' --add sata --controller IntelAHCI && " +
                                            "VBoxManage storageattach "+PassedConfig.ElementAt(8)+" --storagectl 'Drive-Controller' --port 0 --device 0 --type hdd --medium C:/Users/%USERNAME%/VirtualBox/"+PassedConfig.ElementAt(8)+"/"+PassedConfig.ElementAt(8)+".vdi && " +
                                            "VBoxManage storagectl "+PassedConfig.ElementAt(8)+ " --name 'Disk-Controller' --add ide && " +
                                            "VBoxManage storageattach "+PassedConfig.ElementAt(8)+ " --storagectl 'Disk-Controller' --port 0 --device 1 --type dvddrive --medium " + PassedConfig.ElementAt(6);

            AddVirtualMachineStorage.RedirectStandardOutput = true;
            AddVirtualMachineStorage.UseShellExecute = false;
            AddVirtualMachineStorage.RedirectStandardInput = true;
            AddVirtualMachineStorage.CreateNoWindow = true;

            ProcessStartInfo AdditionalConfigurations = new ProcessStartInfo();

            AdditionalConfigurations.FileName = "cmd.exe";

            AdditionalConfigurations.WorkingDirectory = @"C:\PROGRA~1\Oracle\VirtualBox\";


            AdditionalConfigurations.Arguments = " /c VBoxManage modifyvm "+PassedConfig.ElementAt(8)+" --memory 4096 --vram 128";

            AdditionalConfigurations.RedirectStandardOutput = true;
            AdditionalConfigurations.UseShellExecute = false;
            AdditionalConfigurations.RedirectStandardInput = true;
            AdditionalConfigurations.CreateNoWindow = true;

            ////The following programming statement was adapted from C-SharpCorner:
            ////Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            ////Author: Aman
            ////Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            //ProcessStartInfo InstallOS= new ProcessStartInfo();

            ////The following programming statement was adapted from C-SharpCorner:
            ////Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            ////Author: Aman
            ////Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            //InstallOS.FileName = "cmd.exe";

            ////The following programming statement was adapted from C-SharpCorner:
            ////Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            ////Author: Aman
            ////Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            //InstallOS.WorkingDirectory = @"C:\PROGRA~1\Oracle\VirtualBox\";


            //InstallOS.Arguments = " /c VBoxManage unattended install "+PassedConfig.ElementAt(8)+" --iso "+PassedConfig.ElementAt(6)+" --user "+ PassedConfig.ElementAt(4)+" --password "+ PassedConfig.ElementAt(3)+"--no-install-additions";

            //InstallOS.RedirectStandardOutput = true;
            //InstallOS.UseShellExecute = false;
            //InstallOS.RedirectStandardInput = true;
            //InstallOS.CreateNoWindow = true;



            //The following programming statement was adapted from C-SharpCorner:
            //Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            //Author: Aman
            //Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            Process StartDeployment = new Process();

            //The following programming statement was adapted from C-SharpCorner:
            //Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            //Author: Aman
            //Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            StartDeployment.StartInfo = CreateAVirtualMachine;

            if (StartDeployment.Start())
            {

                StartDeployment.WaitForExit();

                //Adding Storage
                StartDeployment.StartInfo = AddVirtualMachineStorage;
                    
                StartDeployment.Start();

                StartDeployment.WaitForExit();
                //Adding Additional Configurations
                StartDeployment.StartInfo = AdditionalConfigurations;

                StartDeployment.Start();

                StartDeployment.WaitForExit();
                ////Install OS
                //StartDeployment.StartInfo = InstallOS;

                //StartDeployment.Start();

                //StartDeployment.WaitForExit();


                if (StartDeployment.ExitCode == 0)
                {

                   IsVirtualMachineDeploymentComplete = true;

                }else if (StartDeployment.ExitCode == 1){

                    IsVirtualMachineDeploymentComplete = false;
                }
            }
           
          
        }

        private void LoadSoftware()
        {

            ProcessStartInfo MountISO = new ProcessStartInfo();

            MountISO.FileName = "powershell.exe";

            MountISO.Arguments = " /c Mount-DiskImage -ImagePath " + PassedConfig.ElementAt(6) + "";
            MountISO.RedirectStandardOutput = true;
            MountISO.UseShellExecute = false;
            MountISO.RedirectStandardInput = true;
            MountISO.CreateNoWindow = true;

            ProcessStartInfo UnmountISO = new ProcessStartInfo();

            UnmountISO.FileName = "powershell.exe";

            UnmountISO.Arguments = " /c Dismount-DiskImage -ImagePath " + PassedConfig.ElementAt(6) + "";
            UnmountISO.RedirectStandardOutput = true;
            UnmountISO.UseShellExecute = false;
            UnmountISO.RedirectStandardInput = true;
            UnmountISO.CreateNoWindow = true;

            //The following programming statement was adapted from C-SharpCorner:
            //Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            //Author: Aman
            //Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            Process StartDeployment = new Process();

            //The following programming statement was adapted from C-SharpCorner:
            //Link: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-start-a-process-like-cmd-window-using-C-Sharp/
            //Author: Aman
            //Author Profile Link:https://www.c-sharpcorner.com/members/aman2
            StartDeployment.StartInfo = MountISO;

            if (StartDeployment.Start())
            {

                StartDeployment.WaitForExit();

                //Removing modified iso
                StartDeployment.StartInfo = UnmountISO;

                StartDeployment.Start();

                StartDeployment.WaitForExit();

                if (StartDeployment.ExitCode == 0)
                {

                    IsSoftwareLoaded = true;
                }
                else if(StartDeployment.ExitCode == 1)
                {
                    IsSoftwareLoaded = false;
                }

            }
        }

        private void CheckAdditions()
        {
            if(PassedConfig.ElementAt(1) == "true")
            {
                ProcessStartInfo FindGuestAdditions = new ProcessStartInfo();

                FindGuestAdditions.FileName = "cmd.exe";

                FindGuestAdditions.WorkingDirectory = @"C:\PROGRA~1\Oracle\VirtualBox\";

                FindGuestAdditions.Arguments = " /c dir VBoxGuestAdditions.iso /s";

                FindGuestAdditions.RedirectStandardOutput = true;
                FindGuestAdditions.UseShellExecute = false;
                FindGuestAdditions.RedirectStandardInput = true;
                FindGuestAdditions.CreateNoWindow = true;

                ProcessStartInfo AddGuestAdditions = new ProcessStartInfo();

                AddGuestAdditions.FileName = "cmd.exe";

                AddGuestAdditions.WorkingDirectory = @"C:\PROGRA~1\Oracle\VirtualBox\";

                AddGuestAdditions.Arguments = " /c VBoxManage storageattach "+PassedConfig.ElementAt(8)+ " --storagectl 'Disk-Controller' --port 0 --device 2 --type additions --medium @C:\\PROGRA~1\\Oracle\\VirtualBox\\VBoxGuestAdditions.iso";

                AddGuestAdditions.RedirectStandardOutput = true;
                AddGuestAdditions.UseShellExecute = false;
                AddGuestAdditions.RedirectStandardInput = true;
                AddGuestAdditions.CreateNoWindow = true;

                Process StartSearch = new Process();

                StartSearch.StartInfo = FindGuestAdditions;


                if (StartSearch.Start())
                {

                    StartSearch.WaitForExit();

                    if (StartSearch.ExitCode == 0)
                    {

                        IsGuestAdditionsPresent = true;

                        //Adding Guest Additions
                        StartSearch.StartInfo = FindGuestAdditions;

                        StartSearch.Start();

                        StartSearch.WaitForExit();

                    }
                    else if (StartSearch.ExitCode == 1)
                    {

                        IsGuestAdditionsPresent = false;

                       // DownloadGuestAdditions();
                    }
                }

            }
           


        }
        
        private void DownloadGuestAdditions()
        {

            //Get Additions, if not present
            using (ISODownloader = new WebClient())
            {
                String HeaderOfDownload = ISODownloader.ResponseHeaders["content-disposition"];
                String FileName = new ContentDisposition(HeaderOfDownload).FileName;

                if (File.Exists(FileName) == false)
                {
                    ISODownloader.DownloadFile("http://download.virtualbox.org/virtualbox/7.0.8/VBoxGuestAdditions_7.0.8.iso", "VBoxGuestAdditions.iso");

                    if (ISODownloader.IsBusy)
                    {
                        //This programming statement was adapted from StackOverflow:
                        //Link: https://stackoverflow.com/questions/4978023/c-sharp-webclient-downloadprogresschanged-wont-work-properly
                        //Author: ulrichb
                        //Auhtor Profile Name: https://stackoverflow.com/users/50890/ulrichb
                        ISODownloader.DownloadProgressChanged += (Request, Response) =>
                        {
                            //This programming statement was adapted from StackOverflow:
                            //Link: https://stackoverflow.com/questions/4978023/c-sharp-webclient-downloadprogresschanged-wont-work-properly
                            //Author: ulrichb
                            //Auhtor Profile Name: https://stackoverflow.com/users/50890/ulrichb
                            ProgressBarText.Content = "Downloading Guest Additions (" + "Bytes: " + Response.BytesReceived + " of " + Response.TotalBytesToReceive + ")";
                        };
                    }
                    else
                    {
                        ProgressBarText.Content = "Downloading Guest Additions failed." + "\n" + "Restarting....";

                    }

                    ISODownloader.DownloadFileCompleted += (Request, Response) =>
                    {
                        if (Response.Cancelled == false)
                        {
                            IsDownloadComplete = true;

                        }else if (Response.Cancelled == true)
                        {
                            IsDownloadComplete = false;
                        }
                    };
                }
                else
                {
                    ProgressBarText.Content = "Downloading Guest Additions failed." + "\n" + "Reason: File Already Exists";

                }

            }

            }
            private void ProgressBarText_Loaded(object sender, RoutedEventArgs e)
            {
            
                if(IsVirtualMachineDeploymentComplete == true && IsGuestAdditionsPresent != null)
                {

                    VMReport = new VM_Report();
                    VMReport.Show();
                    this.Hide();
                    this.Close();
                }else if(IsDownloadComplete == false)
                {

                 ProgressBarText.Content = "Guest Addititions are still downloading...Please wait";
                }
                
            }
        }
    }

