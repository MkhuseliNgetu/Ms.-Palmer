using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;



namespace Ms.Palmer
{
    /// <summary>
    /// Interaction logic for VM_Config.xaml
    /// </summary>
    /// 
    public partial class VM_Config : Window
    {   //General
        private String[] OperatingSystems = new string[5];
        private int[] DefaultVMSizes = new int[5];
        private bool IsGuestAddtionsSet;
        public Stack<String> VM;
        //UI Related
        private OpenFileDialog FindISOLocally;
        private Nullable<bool> IsWindowOpened;
        private LoadingConfig DeployVMConfig;
        //Database Related
        private SqlConnection AccessDB;
        private SqlCommand AddToDB;
        private SqlParameter UseCase;
        private SqlParameter OS;
        private SqlParameter Size;
        private SqlParameter OSLicense;
        private SqlParameter GuestAdditions;
        private DataTable MLSuggestedConfig;
        private DataTable LocalSuggestedConfig;
        private DataRow Content;
        private string ConnectionToDatabase;
        private string SelectedUseCase;
        public VM_Config(String VMUseCase)
        {
            InitializeComponent();

           
            SelectedUseCase = VMUseCase;

            SetName(SelectedUseCase);



        }
        //ML.Net
        //The VMConfigPrediction is used to predict the size (In Mb) for the virtual machine.
        private void PredictVMSize()
        {
            //Load sample data
            //var sampleData = new VMConfigPrediction.ModelInput()
            //{
            //    UseCase = @"Education",
            //    OperatingSystem = @"Ubuntu",
            //    OperatingSystemLicense = @"N/A",
            //    GuestAdditions = false,
            //};

            //Load model and predict output
            //var result = VMConfigPrediction.Predict(sampleData);

        }
        //The VMConfigurationOperatingSystemPredictionModel is used to predict the operating system of the virtual machine based on the use case.
        private void PredictVMOS()
        {
            //Load sample data
            //var sampleData = new VMConfigurationOperatingSystemPredictionModel.ModelInput()
            //{
            //    UseCase = @"Education",
            //    OperatingSystem = @"Ubuntu",
            //    OperatingSystemLicense = @"N/A",
            //    GuestAdditions = false,
            //};

            //Load model and predict output
            //var result = VMConfigurationOperatingSystemPredictionModel.Predict(sampleData);

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
                    StoreConfigOffsite();
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
                    StoreConfigOffsite();
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
                    StoreConfigOffsite();
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
                    StoreConfigOffsite();
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
                    StoreConfigOffsite();
                    break;

            }

            DeployVMConfig = new LoadingConfig(VM);
            DeployVMConfig.Show();
            this.Hide();
            this.Close();

        }

        private void StoreConfigOffsite()
        {
            using (AccessDB = new SqlConnection(ConnectionToDatabase))
            {
                AddToDB = new SqlCommand("SP_AddConfig");
                AddToDB.CommandType = CommandType.StoredProcedure;

                UseCase = new SqlParameter();
                UseCase.ParameterName = "@UseCase";
                UseCase.SqlDbType = SqlDbType.VarChar;
                UseCase.Size = 10;
                UseCase.Value = this.SelectedUseCase;

                OS = new SqlParameter();
                OS.ParameterName = "@OperatingSystem";
                OS.SqlDbType = SqlDbType.VarChar;
                OS.Size = 15;
                OS.Value = VM.ElementAt(5);

                Size = new SqlParameter();
                Size.ParameterName = "@Size";
                Size.SqlDbType = SqlDbType.Int;
                Size.Value = int.Parse(VMSize.SelectedItem.ToString());

                OSLicense = new SqlParameter();
                OSLicense.ParameterName = "@OperatingSystemLicense";
                OSLicense.SqlDbType = SqlDbType.VarChar;
                OSLicense.Size = 30;
                OSLicense.Value = VM.ElementAt(1);

                GuestAdditions = new SqlParameter();
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
        //ML
        private DataTable SetupDataTable()
        {
            MLSuggestedConfig = new DataTable();

            MLSuggestedConfig.Columns.Add(new DataColumn("Use Case", typeof(String)));
            MLSuggestedConfig.Columns.Add(new DataColumn("OS", typeof(String)));
            MLSuggestedConfig.Columns.Add(new DataColumn("Size", typeof(int)));
            MLSuggestedConfig.Columns.Add(new DataColumn("OS License", typeof(String)));
            MLSuggestedConfig.Columns.Add(new DataColumn("Guest Additions", typeof(int)));


            LocalSuggestedConfig = new DataTable();

            LocalSuggestedConfig.Columns.Add(new DataColumn("Use Case", typeof(String)));
            LocalSuggestedConfig.Columns.Add(new DataColumn("OS", typeof(String)));
            LocalSuggestedConfig.Columns.Add(new DataColumn("Size", typeof(int)));
            LocalSuggestedConfig.Columns.Add(new DataColumn("OS License", typeof(String)));
            LocalSuggestedConfig.Columns.Add(new DataColumn("Guest Additions", typeof(int)));

            return LocalSuggestedConfig;
        }

        private DataTable AddConfigData()
        {
            using (AccessDB = new SqlConnection(ConnectionToDatabase))
            {
                AccessDB.Open();

                if (AccessDB.State== ConnectionState.Open)
                {
                    Content = LocalSuggestedConfig.NewRow();

                    String GetConfigs = "SELECT * FROM VMConfigurations WHERE UseCase ='"+SelectedUseCase+"'";

                    using(SqlCommand GetVMConfigs = new SqlCommand(GetConfigs, AccessDB))
                    {
                        GetVMConfigs.CommandType = CommandType.Text;

                        using (SqlDataAdapter DownloadVMConfigs = new SqlDataAdapter(GetVMConfigs))
                        {
                            if (LocalSuggestedConfig.Rows.Count == 0)
                            {
                                DownloadVMConfigs.Fill(LocalSuggestedConfig);
                            }
                            else 
                            {
                                AccessDB.Close();
                            }
                            
                        }

                    }
                    
                }
                else if(AccessDB.State == ConnectionState.Closed || AccessDB.State == ConnectionState.Broken)
                {
                    Content = MLSuggestedConfig.NewRow();
                }
                
            }
            return MLSuggestedConfig;
        }

        private void DisplaySuggestedConfig()
        {
           if(MLSuggestedConfig.Columns.Count!=0 && MLSuggestedConfig.Rows.Count != 0)
            {
                foreach (DataColumn Header in MLSuggestedConfig.Columns)
                {
                    foreach (DataRow Content in MLSuggestedConfig.Rows)
                    {

                        SuggestedVMConfigView.Items.Add(Header + ": " + Content);

                    }
                }

            }
            else if (LocalSuggestedConfig.Columns.Count != 0 && LocalSuggestedConfig.Rows.Count != 0)
            {
                foreach (DataColumn Header in LocalSuggestedConfig.Columns)
                {
                    foreach (DataRow Content in LocalSuggestedConfig.Rows)
                    {

                        SuggestedVMConfigView.Items.Add(Header + ": " + Content);

                    }
                }
            }
           
        }

        private void SuggestedVMConfigView_Initialized(object sender, EventArgs e)
        {
            ConnectionToDatabase = "Server=tcp:diamonddogs.database.windows.net,1433;Initial Catalog=VirtualMachineConfigurations;Persist Security Info=False;User ID=brajo;Password=!H6K@z@j9A}+y>E;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SetupDataTable();
            AddConfigData();
            DisplaySuggestedConfig();

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
