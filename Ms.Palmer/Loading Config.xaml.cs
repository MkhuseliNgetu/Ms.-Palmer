using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mime;
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
    /// Interaction logic for LoadingConfig.xaml
    /// </summary>
    public partial class LoadingConfig : Window
    {

        private WebClient ISODownloader;
        private Stack<String> PassedConfig;

        private VM_Report VMReport;
        public LoadingConfig(Stack<String> FullVMConfig)
        {
            InitializeComponent();

            PassedConfig = FullVMConfig;
        }

        private void ProgressBarText_Loaded(object sender, RoutedEventArgs e)
        {
            //Get Additions, if not present
            using (ISODownloader = new WebClient())
            {
                String HeaderOfDownload = ISODownloader.ResponseHeaders["content-disposition"];
                String FileName = new ContentDisposition(HeaderOfDownload).FileName;

                if (File.Exists(FileName) == false)
                { 
                    ISODownloader.DownloadFile("http://download.virtualbox.org/virtualbox/7.0.8/VBoxGuestAdditions_7.0.8.iso", "VirtualBoxGuestAdditions(Latest).iso");

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
                        ProgressBarText.Content = "Downloading Guest Additions (" + "Bytes: " + Response.BytesReceived + " of " + Response.TotalBytesToReceive+")";
                    };
                    }
                    else
                    {
                    ProgressBarText.Content = "Downloading Guest Additions failed." +"\n"+ "Restarting....";

                    }

                    ISODownloader.DownloadFileCompleted += (Request, Response) =>
                    {
                        if (Response.Cancelled == false)
                        {
                            VMReport = new VM_Report(PassedConfig);
                            VMReport.Show();
                            this.Hide();
                            this.Close();

                        }
                    };
                }
                else
                {
                    ProgressBarText.Content = "Downloading Guest Additions failed." + "\n" + "Reason: File Already Exists";

                }
               


            }
        }
    }
}
