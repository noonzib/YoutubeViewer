using System;
using System.Collections.Generic;
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
using System.Windows.Navigation; 
using System.Windows.Shapes;

namespace YoutubeViewer
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {

            // Get URI to navigate to  
            Uri uri = new Uri(this.searchURL.Text, UriKind.RelativeOrAbsolute);

            // Only absolute URIs can be navigated to  
            if (!uri.IsAbsoluteUri)
            {
                MessageBox.Show("The Address URI must be absolute. For example, 'http://www.microsoft.com'");
                return;
            }

            // Navigate to the desired URL by calling the .Navigate method  
            this.mainBrowser.Navigate(uri);

            // New ListBoxItem
            ListBoxItem itm = new ListBoxItem();
            itm.Content = uri;
             
            this.urlList.Items.Add(itm);
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            // Get URI to navigate to  
            Uri uri = new Uri((string)this.url1.Content, UriKind.RelativeOrAbsolute);

            // Navigate to the desired URL by calling the .Navigate method  
            this.mainBrowser.Navigate(uri);

        }
    }
}
