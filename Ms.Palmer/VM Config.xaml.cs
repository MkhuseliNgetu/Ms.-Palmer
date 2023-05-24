using System;
using System.Collections.Generic;
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
    /// Interaction logic for VM_Config.xaml
    /// </summary>
    public partial class VM_Config : Window
    {

        private String VirtualMachineInstallScriptName = "PalmerInstallScript.txt";

        private String VirtualMachineInstallScriptLocation = "";

        private String VirtualBoxUnattendedInstallTemplate = "VirtualBox VM Unattended Install Template (Credit To Valery Portnyagin).txt";

        private String VirtualBoxUnattendedInstallTemplateLocation = "";

        private String HypervisorType = "";

        private String[] OperatingSystems = new string[5];
        private int[] DefaultVMSizes = new int[5];

        private VM_Report VMReport;
        public VM_Config()
        {
            InitializeComponent();

            CreateInstallScript();

            VMReport = new VM_Report();
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

                            while (ReadTheTemplate.Read() > 0)
                            {
                                var Line = ReadTheTemplate.ReadLine();

                                File.AppendAllLines(@VirtualMachineInstallScriptLocation, Line.Split('\n'));

                            }

                             
                        }


                    }
                    break;

                case false:


                    File.Create(VirtualMachineInstallScriptLocation).Dispose();

                    //Adding Template
                    using (StreamReader ReadTheTemplate = File.OpenText(VirtualBoxUnattendedInstallTemplateLocation))
                    {

                        while (ReadTheTemplate.Read() > 0)
                        {
                            var Line = ReadTheTemplate.ReadLine();

                            File.AppendAllLines(@VirtualMachineInstallScriptLocation, Line.Split('\n'));

                        }
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

        private void DeployVMButton_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void DeployVMButton_Click(object sender, RoutedEventArgs e)
        {
            switch (OperatingSystemType.SelectedItem)
            {

                case "Windows 10":
                    break;
                case "Ubuntu":
                    if (VMUsername.Text.Length > 2 && 
                        VMUsername.Text != null && 
                        VMPassword.Password != null)
                    {

                        using (StreamReader ReadTheInstallScript = File.OpenText(VirtualMachineInstallScriptLocation))
                        {

                            while (ReadTheInstallScript.Read() > 0)
                            {

                                if (ReadTheInstallScript.Read().ToString().Contains(""))
                                {


                                }
                                var Line = ReadTheInstallScript.ReadLine();

                                File.AppendAllLines(@VirtualMachineInstallScriptLocation, Line.Split('\n'));

                            }
                        }

                    }
                    break;
                case "Fedora":
                    if (VMUsername.Text.Length > 2 || VMUsername.Text != null)
                    {



                    }
                    break;
                case "Pop OS":
                    if (VMUsername.Text.Length > 2 || VMUsername.Text != null)
                    {



                    }
                    break;
                case "Linux Mint":
                    if (VMUsername.Text.Length > 2 || VMUsername.Text != null)
                    {



                    }
                    break;

            }
            
            
        }

        private void OSKey_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void InstallGuestAdditions_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void DeployVM_Click(object sender, RoutedEventArgs e)
        {
            VMReport.Show();

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
