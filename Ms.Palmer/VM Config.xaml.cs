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
    }
}
