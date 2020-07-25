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
using System.Xml;

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

            LoadListBoxItem();
            XmlDocument doc = new XmlDocument();
        }

        // 검색 버튼 클릭
        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            String inputUrl = this.searchURL.Text;

            // Get URI to navigate to  
            Uri uri = new Uri(inputUrl, UriKind.RelativeOrAbsolute);

            // Only absolute URIs can be navigated to  
            if (!uri.IsAbsoluteUri)
            {
                MessageBox.Show("The Address URI must be absolute. For example, 'http://www.microsoft.com'");
                return;
            }

            // Navigate to the desired URL by calling the .Navigate method  
            this.mainBrowser.Navigate(uri);

            // New ListBoxItem <- fixed!! 
            // content add to xml code

            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.Load("Resource/URLResource.xml");
            
            // CREATE element
            XmlElement urlElement = doc.CreateElement("url");
            urlElement.InnerText = inputUrl;

            // add attribute
            XmlAttribute viewName = doc.CreateAttribute("viewname");
            viewName.Value = inputUrl;
            urlElement.Attributes.Append(viewName);

            doc.DocumentElement.AppendChild(urlElement);

            doc.Save("Resource/URLResource.xml");
            MessageBox.Show("Saved File!");

            //Need CLEAR listboxitem method
            ClearListBoxItem();
            LoadListBoxItem();

        }

        private void ClearListBoxItem()
        {
            this.playList.Items.Clear();
        }

        private void LoadListBoxItem()
        {
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.Load("Resource/URLResource.xml");
            XmlNodeList urlList = doc.GetElementsByTagName("url");
            ListBoxItem listBoxItem;


            for (int i=0; i < urlList.Count; i++)
            {
                Console.WriteLine(urlList[i].InnerText);
                listBoxItem = new ListBoxItem();
                listBoxItem.Content = urlList[i].Attributes["viewname"].Value;
                listBoxItem.Selected += ListBoxItem_Selected;
                this.playList.Items.Add(listBoxItem);
            }


        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.Load("Resource/URLResource.xml");

            ListBoxItem lbi = e.Source as ListBoxItem;
            String value = lbi.Content.ToString();
            XmlNode findURL = doc.SelectSingleNode("/data/url[@viewname='"+value+"']");
            String url = findURL.InnerText;

            // Get URI to navigate to  
            Uri uri = new Uri(url, UriKind.RelativeOrAbsolute);

            // Navigate to the desired URL by calling the .Navigate method  
            this.mainBrowser.Navigate(uri);

        }
    }
}
