using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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



        private String[] OperatingSystems = new string[5];
        private int[] DefaultVMSizes = new int[5];
        private bool IsGuestAddtionsSet;

      
        public Stack<String> VM;

        private OpenFileDialog FindISOLocally;
        private Nullable<bool> IsWindowOpened;

        private LoadingConfig DeployVMConfig;
        private DataTable MLSuggestedConfig;
        private String ConnectionToDatabase;
        private string SelectedUseCase;
        public VM_Config(String VMUseCase)
        {
            InitializeComponent();

            SelectedUseCase = VMUseCase;

            SetName(SelectedUseCase);
        }
       

        public Stack<String> SetOS(string OperatingSystem)
        {

          
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

        public Stack<String> AddPostInstallScript(string UseCase)
        {
            string PathToScript;
            switch (SelectedUseCase)
            {

                case "Gaming":
                    PathToScript = System.IO.Path.Combine(Directory.GetCurrentDirectory(),"\\Scripts\\DeploySoftware (Gaming) (Linux).sh");
                    VM.Push(PathToScript);
                    break;
                case "Work":
                    PathToScript = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "\\Scripts\\DeploySoftware (Work) (Linux).sh");
                    VM.Push(PathToScript);
                    break;
                case "Entertainment":
                    PathToScript = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "\\Scripts\\DeploySoftware (Entertainment) (Linux).sh");
                    VM.Push(PathToScript);
                    break;
                case "Education":
                    PathToScript = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "\\Scripts\\DeploySoftware (Education) (Linux).sh");
                    VM.Push(PathToScript);
                    break;

            }

            return VM;
        }

        public Stack<String> SetName(string UseCase)
        {
            VM = new Stack<string>();
            switch (SelectedUseCase)
            {

                case "Gaming":
                    VM.Push(SelectedUseCase);
                    break;
                case "Work":
                    VM.Push(SelectedUseCase);
                    break;
                case "Entertainment":
                    VM.Push(SelectedUseCase);
                    break;
                case "Education":
                    VM.Push(SelectedUseCase);
                    break;

            }

            return VM;
        }

        public Stack<String> SetSize(string VMSize)
        {
           
            if(VMSize != null)
            {

                VM.Push(VMSize.Replace("GB",""));
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

                VMSize.Items.Add(VMSizes.ToString() + "GB");

                if (VMSize.Items.Count.Equals(5))
                {
                    VMSize.Items.Add("Other...");
                }
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

                    SetOS("Windows10");

                    SetIsoPath(FindISOLocally.FileName);

                    SetSize(VMSize.SelectedItem.ToString());

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

                    AddPostInstallScript(SelectedUseCase);
                    break;
                case "Ubuntu":

                    SetOS("Ubuntu_64");

                    SetIsoPath(FindISOLocally.FileName);

                    SetSize(VMSize.SelectedItem.ToString());

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

                    AddPostInstallScript(SelectedUseCase);
                    break;
                case "Fedora":

                    SetOS("Fedora_64");

                    SetIsoPath(FindISOLocally.FileName);

                    SetSize(VMSize.SelectedItem.ToString());

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

                    AddPostInstallScript(SelectedUseCase);
                    break;
                case "Pop OS":

                    SetOS("Linux_64");

                    SetIsoPath(FindISOLocally.FileName);

                    SetSize(VMSize.SelectedItem.ToString());

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

                    AddPostInstallScript(SelectedUseCase);
                    break;
                case "Linux Mint":

                    SetOS("Linux_64");

                    SetIsoPath(FindISOLocally.FileName);

                    SetSize(VMSize.SelectedItem.ToString());

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

                    AddPostInstallScript(SelectedUseCase);
                    break;

            }

            DeployVMConfig = new LoadingConfig(VM);
            DeployVMConfig.Show();
            this.Hide();
            this.Close();

        }

        private void StoreConfigOffsite()
        {
            using (SqlConnection AccessDB = new SqlConnection(ConnectionToDatabase))
            {
                SqlCommand AddToDB = new SqlCommand("AddConfig");
                AddToDB.CommandType = CommandType.StoredProcedure;

                SqlParameter UseCase = new SqlParameter();
                UseCase.ParameterName = "@UseCase";
                UseCase.SqlDbType = SqlDbType.VarChar;
                UseCase.Size = 10;
                UseCase.Value = this.SelectedUseCase;

                SqlParameter OS = new SqlParameter();
                OS.ParameterName = "@OperatingSystem";
                OS.SqlDbType = SqlDbType.VarChar;
                OS.Size = 15;
                OS.Value = VM.ElementAt(5);

                SqlParameter Size = new SqlParameter();
                Size.ParameterName = "@Size";
                Size.SqlDbType = SqlDbType.Int;
                Size.Value = int.Parse(VMSize.SelectedItem.ToString());

                SqlParameter OSLicense = new SqlParameter();
                OSLicense.ParameterName = "@OperatingSystemLicense";
                OSLicense.SqlDbType = SqlDbType.VarChar;
                OSLicense.Size = 30;
                OSLicense.Value = VM.ElementAt(1);

                SqlParameter GuestAdditions = new SqlParameter();
                GuestAdditions.ParameterName = "@GuestAdditions";
                GuestAdditions.SqlDbType = SqlDbType.Bit;
                GuestAdditions.Value = VM.ElementAt(0);

                AddToDB.Parameters.Add(UseCase);
                AddToDB.Parameters.Add(OS);
                AddToDB.Parameters.Add(Size);
                AddToDB.Parameters.Add(OSLicense);
                AddToDB.Parameters.Add(GuestAdditions);

                AccessDB.Open();

                AddToDB.ExecuteNonQuery();

                AccessDB.Close();



            }
        }
        private DataTable SetupDataTable()
        {
            MLSuggestedConfig = new DataTable();

            MLSuggestedConfig.Columns.Add(new DataColumn("Use Case", typeof(String)));
            MLSuggestedConfig.Columns.Add(new DataColumn("OS", typeof(String)));
            MLSuggestedConfig.Columns.Add(new DataColumn("Size", typeof(int)));
            MLSuggestedConfig.Columns.Add(new DataColumn("OS License", typeof(String)));
            MLSuggestedConfig.Columns.Add(new DataColumn("Guest Additions", typeof(Boolean)));

          


            return MLSuggestedConfig;
        }

        private DataTable AddConfigData()
        {
            DataRow Content = MLSuggestedConfig.NewRow();

            return MLSuggestedConfig;
        }

        private void DisplaySuggestedConfig()
        {
           
                foreach (DataColumn Header in MLSuggestedConfig.Columns)
                {
                     foreach (DataRow Content in MLSuggestedConfig.Rows)
                     {

                        SuggestedVMConfigView.Items.Add(Header +": "+ Content);

                     }
                }
        }

        private void SuggestedVMConfigView_Initialized(object sender, EventArgs e)
        {

            SetupDataTable();
            //DisplaySuggestedConfig();

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
