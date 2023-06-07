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
    public class TreeNode<String>
    {
        public TreeNode<string> Root;
        public LinkedList<TreeNode<string>> Children;
        private string useCase;

        public TreeNode(string useCase)
        {
            this.useCase = useCase;
        }

        public TreeNode<string> AddConfig(string UseCase)
        {
            if (UseCase != null)
            {
                this.Root = new TreeNode<string>(UseCase);
            }
            else
            {
                throw new Exception("A Virtual Machines needs to have a use case");
            }
            return Root;
        }

        public LinkedList<TreeNode<string>> SetupChildren()
        {
            Children = new LinkedList<TreeNode<string>>();

            return Children;
        }

        public LinkedList<TreeNode<string>> AddUsernameAndPassCode(string Username, string Passcode)
        {

            if (Username != null && Passcode != null)
            {

                TreeNode<string> UserName = new TreeNode<string>(Username);
                TreeNode<string> PassCode = new TreeNode<string>(Passcode);

                if (Children.Count == 0)
                {

                    Children.AddFirst(UserName);
                    Children.Append(PassCode);
                }

            }
            else
            {
                throw new Exception("A Virtual Machines needs to have a username and password");
            }

            return Children;
        }
        public LinkedList<TreeNode<string>> AddKey(string OsKey)
        {

            if (OsKey != null)
            {
                TreeNode<string> OperatingSystemKey = new TreeNode<string>(OsKey);

                if (Children.Count == 2)
                {
                    Children.Append(OperatingSystemKey);
                }

            }
            else
            {
                throw new Exception("A Virtual Machines needs to have a license/key to proceed");
            }

            return Children;
        }
        public LinkedList<TreeNode<string>> SetAdditions(string AreAdditionsNeeded)
        {

            if (AreAdditionsNeeded != null)
            {

                TreeNode<string> GuestAddtions = new TreeNode<string>(AreAdditionsNeeded);


                if (Children.ElementAt(3) == null)
                {
                    Children.Append(GuestAddtions);
                }
                else if (Children.ElementAt(4) == null)
                {
                    Children.Append(GuestAddtions);
                }

            }
            else
            {
                throw new Exception("A Virtual Machines needs to have a license/key to proceed");
            }
            return Children;
        }

    }
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
        private TreeNode<string> VM;

        private String Line;
        private WebClient ISODownloader;
        public VM_Config()
        {
            InitializeComponent();

            CreateInstallScript();

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

                    //Adding User Parameters
                   /* using (StreamReader ReadTheInstallScript = File.OpenText(VirtualMachineInstallScriptLocation))
                    {

                        while (ReadTheInstallScript.Read() > 0)
                        {
                            var Line = ReadTheInstallScript.ReadLine();

                            File.AppendAllLines(@VirtualMachineInstallScriptLocation, Line.Split('\n'));

                        }
                    }*/

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

        private void VMPassword_TextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void VMUsername_TextInput(object sender, TextCompositionEventArgs e)
        {

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

        private void DeployVMButton_Click(object sender, RoutedEventArgs e)
        {

           
        }

        private void OSKey_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void InstallGuestAdditions_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void DeployVM_Click(object sender, RoutedEventArgs e)
        {
            VMReport = new VM_Report();


            switch (OperatingSystemType.SelectedItem)
            {
                case "Windows 10":
                    break;
                case "Ubuntu":
                    VM = new TreeNode<string>("Ubuntu");

                    VM.SetupChildren();

                    VM.AddConfig(OperatingSystemType.SelectedItem.ToString());

                    VM.AddUsernameAndPassCode(VMUsername.Text, VMPassword.Password);

                    if (InstallGuestAdditions.IsChecked == true)
                    {
                        IsGuestAddtionsSet = true;
                        //VM.SetAdditions(IsGuestAddtionsSet.ToString());
                    }
                    else
                    {
                        IsGuestAddtionsSet = false;
                        //VM.SetAdditions(IsGuestAddtionsSet.ToString());
                    }


                    break;
                case "Fedora":
                    VM = new TreeNode<string>("Fedora");

                    VM.SetupChildren();

                    VM.AddConfig(OperatingSystemType.SelectedItem.ToString());

                    VM.AddUsernameAndPassCode(VMUsername.Text, VMPassword.Password);

                    if (InstallGuestAdditions.IsChecked == true)
                    {
                        IsGuestAddtionsSet = true;
                       //VM.SetAdditions(IsGuestAddtionsSet.ToString());
                    }
                    else
                    {
                        IsGuestAddtionsSet = false;
                        //VM.SetAdditions(IsGuestAddtionsSet.ToString());
                    }
                    break;
                case "Pop OS":
                    VM = new TreeNode<string>("Pop OS");

                    VM.SetupChildren();

                    VM.AddConfig(OperatingSystemType.SelectedItem.ToString());

                    VM.AddUsernameAndPassCode(VMUsername.Text, VMPassword.Password);

                    if (InstallGuestAdditions.IsChecked == true)
                    {
                        IsGuestAddtionsSet = true;
                        //VM.SetAdditions(IsGuestAddtionsSet.ToString());
                    }
                    else
                    {
                        IsGuestAddtionsSet = false;
                        //VM.SetAdditions(IsGuestAddtionsSet.ToString());
                    }
                    break;
                case "Linux Mint":
                    VM = new TreeNode<string>("Linux Mint");

                    VM.SetupChildren();

                    VM.AddConfig(OperatingSystemType.SelectedItem.ToString());

                    VM.AddUsernameAndPassCode(VMUsername.Text, VMPassword.Password);

                    if (InstallGuestAdditions.IsChecked == true)
                    {
                        IsGuestAddtionsSet = true;
                        //VM.SetAdditions(IsGuestAddtionsSet.ToString());
                    }
                    else
                    {
                        IsGuestAddtionsSet = false;
                        //VM.SetAdditions(IsGuestAddtionsSet.ToString());
                    }
                    break;

            }

            //Manipulate the script
            using (StreamReader ReadTheInstallScript = File.OpenText(VirtualMachineInstallScriptLocation))
            {

                while (ReadTheInstallScript.Read() > 0)
                {
                    //Set Vm Name
                    if (ReadTheInstallScript.Read().ToString().Contains("<em>VBoxManage unattended install <uuid|vmname>"))
                    {
                        Line = ReadTheInstallScript.ReadLine();

                        Line.Replace("<em>VBoxManage unattended install <uuid|vmname>", "<em> VBoxManage unattended install" + VM.Root.ToString());

                        File.WriteAllText(VirtualMachineInstallScriptLocation, Line);

                    }
                    //Set Username and Password
                    if (ReadTheInstallScript.Read().ToString().Contains("[--user=login]"))
                    {
                        Line = ReadTheInstallScript.ReadLine();

                        Line.Replace("[--user=login]", "user =" + VM.Children.ElementAt(0));

                        File.WriteAllText(VirtualMachineInstallScriptLocation, Line);

                        if (ReadTheInstallScript.Read().ToString().Contains("[--password=password]"))
                        {
                            Line = ReadTheInstallScript.ReadLine();

                            Line.Replace("[--password=password]", "password =" + VM.Children.ElementAt(1));

                            File.WriteAllText(VirtualMachineInstallScriptLocation, Line);
                        }
                    }
                    //Set Key
                    if (ReadTheInstallScript.Read().ToString().Contains("[--key=product-key]"))
                    {
                        Line = ReadTheInstallScript.ReadLine();

                        Line.Replace("[--key=product-key]", "productKey =" + VM.Children.ElementAt(3));

                        File.WriteAllText(VirtualMachineInstallScriptLocation, Line);
                    }
                    // Set Guest Additions
                    if (ReadTheInstallScript.Read().ToString().Contains("[--install-additions]"))
                    {
                        Line = ReadTheInstallScript.ReadLine();

                        //Get Additions, if not present
                        using (ISODownloader = new WebClient())
                        {
                            ISODownloader.DownloadFile("http://download.virtualbox.org/virtualbox/7.0.8/VBoxGuestAdditions_7.0.8.iso", "VirtualBoxGuestAdditions(Latest).iso");

                            if (ISODownloader.IsBusy)
                            {
                                //Insert Measurement bar
                            }
                            
                        }

                        //Line.Replace("[--install-additions]", "installGuestAdditions =" + VM.Children.ElementAt(3));

                    }


                    //File.AppendAllLines(@VirtualMachineInstallScriptLocation, Line.Split('\n'));

                }

                ReadTheInstallScript.Dispose();
            }

            VMReport.Show();
            this.Hide();
            this.Close();
          
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

                VMSize.Items.Add(VMSizes.ToString().Append('G').Append('B'));

                if (VMSize.Items.Count.Equals(5))
                {
                    VMSize.Items.Add("Other...");
                }
            }
        }
    }
}
