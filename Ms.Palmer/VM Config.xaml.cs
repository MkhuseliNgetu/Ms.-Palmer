using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
    /// Interaction logic for VM_Config.xaml
    /// </summary>
    /// 
    public partial class VM_Config : Window
    {

        private String VirtualMachineInstallScriptName = "PalmerInstallScript.txt";
        private String VirtualMachineInstallScriptLocation = "";
        private String VirtualBoxUnattendedInstallTemplate = "VirtualBox VM Unattended Install Template (Credit To Valery Portnyagin).txt";
        private String VirtualBoxUnattendedInstallTemplateLocation = "";


        private String[] OperatingSystems = new string[5];
        private int[] DefaultVMSizes = new int[5];
        private bool IsGuestAddtionsSet;

        private VM_Report VMReport;
        public Stack<String> VM;

        private List<String> Line;
        private OpenFileDialog FindISOLocally;
        private Nullable<bool> IsWindowOpened;

        private LoadingConfig DownloadISO;
        public VM_Config(String VMUseCase)
        {
            InitializeComponent();

            CreateInstallScript();

            Line = new List<String>();

        }

        public Stack<String> StartConfig(string OperatingSystem)
        {

            VM = new Stack<string>();
            if (OperatingSystem != null)
            {
                VM.Push(OperatingSystem);
            }
            else
            {
                throw new Exception("A virtual machines needs to have a use case");
            }
            return VM;
        }
        public Stack<String> SetIsoPath(string IsoPath)
        {

            if (IsoPath != null && VM.Count>0)
            {
                VM.Push(IsoPath);
            }
            else
            {
                throw new Exception("A virtual machine needs to have a iso to proceed");
            }
            return VM;
        }
        public Stack<String> AddUsernameAndPassCode(string Username, string Passcode)
        {

            if (Username != null && Passcode != null)
            {
                VM.Push(Username);
                VM.Push(Passcode);
            }
            else
            {
                throw new Exception("A virtual machines needs to have a username and password");
            }

            return VM;
        }
        public Stack<String> AddKey(string OsKey)
        {

            if (OsKey != null)
            {
                VM.Push(OsKey);
            }
            else
            {
                throw new Exception("A virtual machines needs to have a license/key to proceed");
            }

            return VM;
        }
        public Stack<String> SetAdditions(string AreAdditionsNeeded)
        {

            if (AreAdditionsNeeded != null)
            {

               VM.Push(AreAdditionsNeeded);
               
               
            }
            else
            {
                throw new Exception("A virtual machines needs to have a license/key to proceed");
            }
            return VM;
        }

      

        private void VMSize_Loaded_1(object sender, RoutedEventArgs e)
        {
            DefaultVMSizes[0] = 30;
            DefaultVMSizes[1] = 60;
            DefaultVMSizes[2] = 90;
            DefaultVMSizes[3] = 120;
            DefaultVMSizes[4] = 256;

            foreach (int VMSizes in DefaultVMSizes)
            {

                VMSize.Items.Add(VMSizes.ToString() + "Gb");

                if (VMSize.Items.Count.Equals(5))
                {
                    VMSize.Items.Add("Other...");
                }
            }
        }

        private void CreateInstallScript()
        {
            VirtualBoxUnattendedInstallTemplateLocation = System.IO.Path.Combine(Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName, VirtualBoxUnattendedInstallTemplate);
            VirtualMachineInstallScriptLocation = System.IO.Path.Combine(Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName, VirtualMachineInstallScriptName);

            switch (File.Exists(VirtualMachineInstallScriptLocation))
            {

                case true:

                    if (!File.ReadAllText(VirtualMachineInstallScriptLocation).Contains(""))
                    {
                        File.Delete(VirtualMachineInstallScriptLocation);

                        File.Create(VirtualMachineInstallScriptLocation).Dispose();

                        //Adding Template
                        using (StreamReader ReadTheTemplate = File.OpenText(VirtualBoxUnattendedInstallTemplateLocation))
                        {
                            

                            while (ReadTheTemplate.Read() != null)
                            {

                                String LineFromFile = ReadTheTemplate.ReadToEnd();

                                File.AppendAllText(@VirtualMachineInstallScriptLocation, LineFromFile);
                            }

                            
                        }


                    }
                    break;

                case false:


                    File.Create(VirtualMachineInstallScriptLocation).Dispose();

                    //Adding Template
                    using (StreamReader ReadTheTemplate = File.OpenText(VirtualBoxUnattendedInstallTemplateLocation))
                    {

                        String LineFromFile = ReadTheTemplate.ReadToEnd();

                        File.AppendAllText(@VirtualMachineInstallScriptLocation, LineFromFile);
                    }

                 

                    break;
            }
        }

        private void OperatingSystemType_Loaded(object sender, RoutedEventArgs e)
        {

            OperatingSystems[0] = "Windows 10";
            OperatingSystems[1] = "Ubuntu";
            OperatingSystems[2] = "Fedora";
            OperatingSystems[3] = "Pop OS";
            OperatingSystems[4] = "Linux Mint";

            foreach(String OS in OperatingSystems)
            {

                OperatingSystemType.Items.Add(OS);
            }

           
        }

        private void OperatingSystemType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (OperatingSystemType.SelectedItem)
            {

                case "Windows 10":
                    break;
                case "Ubuntu":
                    OSKey.Visibility = Visibility.Hidden;
                    break;
                case "Fedora":
                    OSKey.Visibility = Visibility.Hidden;
                    break;
                case "Pop OS":
                    OSKey.Visibility = Visibility.Hidden;
                    break;
                case "Linux Mint":
                    OSKey.Visibility = Visibility.Hidden;
                    break;

            }
        }



        private void DeployVM_Click(object sender, RoutedEventArgs e)
        {
           


            switch (OperatingSystemType.SelectedItem)
            {
                case "Windows 10":

                    StartConfig(OperatingSystemType.SelectedItem.ToString());

                    SetIsoPath(FindISOLocally.FileName);

                    AddUsernameAndPassCode(VMUsername.Text, VMPassword.Password);

                    AddKey(OSKey.Text);

                    if (InstallGuestAdditions.IsChecked == true)
                    {
                        IsGuestAddtionsSet = true;
                        SetAdditions(IsGuestAddtionsSet.ToString());
                    }
                    else
                    {
                        IsGuestAddtionsSet = false;
                        SetAdditions(IsGuestAddtionsSet.ToString());
                    }
                    break;
                case "Ubuntu":

                    StartConfig(OperatingSystemType.SelectedItem.ToString());

                    SetIsoPath(FindISOLocally.FileName);

                    AddUsernameAndPassCode(VMUsername.Text, VMPassword.Password);

                    AddKey("N/A");

                    if (InstallGuestAdditions.IsChecked == true)
                    {
                        IsGuestAddtionsSet = true;
                        SetAdditions(IsGuestAddtionsSet.ToString());
                    }
                    else
                    {
                        IsGuestAddtionsSet = false;
                        SetAdditions(IsGuestAddtionsSet.ToString());
                    }


                    break;
                case "Fedora":

                    StartConfig(OperatingSystemType.SelectedItem.ToString());

                    SetIsoPath(FindISOLocally.FileName);

                    AddUsernameAndPassCode(VMUsername.Text, VMPassword.Password);

                    AddKey("N/A");

                    if (InstallGuestAdditions.IsChecked == true)
                    {
                        IsGuestAddtionsSet = true;
                        SetAdditions(IsGuestAddtionsSet.ToString());
                    }
                    else
                    {
                        IsGuestAddtionsSet = false;
                        SetAdditions(IsGuestAddtionsSet.ToString());
                    }

                    break;
                case "Pop OS":

                    StartConfig(OperatingSystemType.SelectedItem.ToString());

                    SetIsoPath(FindISOLocally.FileName);

                    AddUsernameAndPassCode(VMUsername.Text, VMPassword.Password);

                    AddKey("N/A");

                    if (InstallGuestAdditions.IsChecked == true)
                    {
                        IsGuestAddtionsSet = true;
                        SetAdditions(IsGuestAddtionsSet.ToString());
                    }
                    else
                    {
                        IsGuestAddtionsSet = false;
                        SetAdditions(IsGuestAddtionsSet.ToString());
                    }

                    break;
                case "Linux Mint":

                    StartConfig(OperatingSystemType.SelectedItem.ToString());

                    SetIsoPath(FindISOLocally.FileName);

                    AddUsernameAndPassCode(VMUsername.Text, VMPassword.Password);

                    AddKey("N/A");

                    if (InstallGuestAdditions.IsChecked == true)
                    {
                        IsGuestAddtionsSet = true;
                        SetAdditions(IsGuestAddtionsSet.ToString());
                    }
                    else
                    {
                        IsGuestAddtionsSet = false;
                        SetAdditions(IsGuestAddtionsSet.ToString());
                    }

                    break;

            }

            //Manipulate the script
            //Set Vm Name
            Line.Add("<em> VBoxManage unattended install " + VM.ElementAt(5));
            //Set Iso Path
            Line.Add("<--iso=" + VM.ElementAt(4) + ">");
            //Set Username and Password
            Line.Add("[--user=" + VM.ElementAt(3) + "]");
            Line.Add("[--password=" + VM.ElementAt(2) + "]");
            //Set Key 
            Line.Add("[--key="+ VM.ElementAt(1)+"]");
            // Set Guest Additions
            if (VM.ElementAt(0).Equals("true"))
            {
                Line.Add("[--install-additions" + VM.ElementAt(0) + "]");

               
            }
            else if (VM.ElementAt(0).Equals("false"))
            {

                Line.Add("[--install-additions" + VM.ElementAt(0) + "]");
            }

            
               // DownloadISO = new LoadingConfig(VM);
               // DownloadISO.Show();
               // this.Hide();
               // this.Close();
           

                using (FileStream OpenInstallScript = new FileStream(VirtualMachineInstallScriptLocation, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
                {

                    using (StreamReader ReadTheScript = new StreamReader(OpenInstallScript))
                    using (StreamWriter WriteToScript = new StreamWriter(OpenInstallScript))
                    {
                        var AllData = ReadTheScript.ReadToEnd();

                        OpenInstallScript.SetLength(0);

                        foreach (String ConfigLine in Line)
                        {
                            WriteToScript.WriteLine(ConfigLine);

                        }

                        WriteToScript.WriteLine("</em>");

                    }
                }

                VMReport = new VM_Report(VM);
                VMReport.Show();
                this.Hide();
                this.Close();
            
          


        }


        private void SuggestedVMConfigView_Initialized(object sender, EventArgs e)
        {

        }

        private void ConfirmISOButton_Click(object sender, RoutedEventArgs e)
        {
            //The following 6 consecutive programming statements were adapted from C# Corner:
            //Link: https://www.c-sharpcorner.com/uploadfile/mahesh/openfiledialog-in-wpf/
            //Author: Mahesh Chand
            //Author Profile Link: https://www.c-sharpcorner.com/members/mahesh-chand
            FindISOLocally = new OpenFileDialog();
            FindISOLocally.Filter = "Disk Image File (*.iso)|*.iso";
            FindISOLocally.InitialDirectory = @"C:\Users\";
            FindISOLocally.Multiselect = false;
            IsWindowOpened = FindISOLocally.ShowDialog();

            switch (IsWindowOpened == true)
            {
                case true:
                    ISOPath.Text = FindISOLocally.FileName;
                    ISOPath.IsEnabled = false;
                    break;

                case false:
                    throw new Exception("A iso must be selected to continue");
                    break;

            }
        }

        private void ISOPath_Initialized(object sender, EventArgs e)
        {

            ISOPath.IsEnabled = false;
        }
    }
}
