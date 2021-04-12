using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UcakBileti
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public String html;
        public Uri url;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            
                
               lisbx2.Items.Clear();
                lisbx3.Items.Clear();
                WebClient client = new WebClient();
                client.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
                client.Headers.Add("Accept: text/html, application/xhtml+xml, */*");
                client.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                //  string html = client.DownloadString(url);

                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                // dokuman.LoadHtml(html);
                int sayı = 0;

                for (int i = 1; i < 15; i += 2)
                {
                    verial("https://www.ucuzabilet.com/ic-hat-arama-sonuc?from=SAW&to=TZX&ddate=15.04.2021&adult=1",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[1]/div[1]",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[2]/b",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[2]/div",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[1]/div[3]",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[4]/b/text()",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[3]/span",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[3]/div[2]/text()",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[4]/div",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[5]/div[2]/span", lisbx1);
                }
                for (int j = 15; j < 43; j += 2)
                {
                    verial2("https://www.ucuzabilet.com/ic-hat-arama-sonuc?from=SAW&to=TZX&ddate=15.04.2021&adult=1",
                        "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[1]/div[1]",
                        "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[2]/b",
                        "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[2]/div",
                        "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[1]/div[3]",
                        "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[4]/b",
                        "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[3]/span",
                        "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[3]/div[2]/text()",
                        "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[4]/div",
                        "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[5]/div[2]/span", lisbx1);


                }

                /*  string veri1 = dokuman.DocumentNode.SelectNodes("/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[1]/td[4]")[sayı].InnerText;
                  string veri2 = dokuman.DocumentNode.SelectNodes("/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[1]/td[5]/div[1]/span")[sayı].InnerText;
                  string veri3 = dokuman.DocumentNode.SelectNodes("/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[1]/td[3]/span")[sayı].InnerText;
                  string veri4 = dokuman.DocumentNode.SelectNodes("/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[1]/td[2]")[sayı].InnerText;
                  string veri5 = dokuman.DocumentNode.SelectNodes("/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[1]/td[1]/div[1]")[sayı].InnerText;
                  string veri6 = dokuman.DocumentNode.SelectNodes("/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[1]/td[1]/div[3]")[sayı].InnerText;
                  string veri0 = dokuman.DocumentNode.SelectNodes("/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table")[sayı].InnerText;

                    listBox1.Text = veri6.Trim().Replace(" ",string.Empty)+"            " + veri5.Trim().Replace(" ", string.Empty)+"           "  
                        + veri4.Trim().Replace(" ",string.Empty)+"          " + veri3.Trim().Replace(" ",string.Empty)+"          "
                        + veri1.Trim().Replace(" ",string.Empty)+"        " + veri2.Trim().Replace(" ",string.Empty);



                  //string resim_yolu = "/html/body/main/div[4]/div[1]/section[1]/div[2]/ul/li[1]/a/div";
                */
            }
            public void verial(String Url, String Xpath, String Xpath2, String Xpath3, String Xpath4, String Xpath5, String Xpath6,
                String Xpath7, String Xpath8, String Xpath9, ListBox snc)
            {
                try
                {
                    url = new Uri(Url);


                }
                catch (UriFormatException)
                {
                    MessageBox.Show("url hatası");
                }
                WebClient web = new WebClient();
                web.Encoding = Encoding.UTF8;
                try
                {
                    html = web.DownloadString(url);

                }
                catch (WebException)
                {

                }
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);
                try
                {//Pegasus
                    snc.Items.Add(doc.DocumentNode.SelectSingleNode(Xpath).InnerText + "     " +
                        doc.DocumentNode.SelectSingleNode(Xpath2).InnerText + "       " +
                        doc.DocumentNode.SelectSingleNode(Xpath3).InnerText + "       " +
                        doc.DocumentNode.SelectSingleNode(Xpath4).InnerText + "       " +
                        doc.DocumentNode.SelectSingleNode(Xpath5).InnerText.Trim() + "        " +
                        doc.DocumentNode.SelectSingleNode(Xpath6).InnerText.Trim() + "        " +
                        doc.DocumentNode.SelectSingleNode(Xpath7).InnerText.Trim() + "        " +
                        doc.DocumentNode.SelectSingleNode(Xpath8).InnerText + "       " +
                        doc.DocumentNode.SelectSingleNode(Xpath9).InnerText);

                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Hatalı xpath");
                }
            }

            public void verial2(String Url, String Xpath1, String Xpath2, String Xpath3, String Xpath4, String Xpath5,
                String Xpath6, String Xpath7, String Xpath8, String Xpath9, ListBox snc)
            {
                try
                {
                    url = new Uri(Url);


                }
                catch (UriFormatException)
                {
                    MessageBox.Show("url hatası");
                }
                WebClient web = new WebClient();
                web.Encoding = Encoding.UTF8;
                try
                {
                    html = web.DownloadString(url);

                }
                catch (WebException)
                {

                }
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);
                try
                {//AnadoluJet
                    snc.Items.Add(doc.DocumentNode.SelectSingleNode(Xpath1).InnerText + "     " +
                        doc.DocumentNode.SelectSingleNode(Xpath2).InnerText + "       " +
                        doc.DocumentNode.SelectSingleNode(Xpath3).InnerText.Trim() + "        " +
                        doc.DocumentNode.SelectSingleNode(Xpath4).InnerText + "       " +
                        doc.DocumentNode.SelectSingleNode(Xpath5).InnerText.Trim() + "        " +
                        doc.DocumentNode.SelectSingleNode(Xpath6).InnerText.Trim() + "        " +
                        doc.DocumentNode.SelectSingleNode(Xpath7).InnerText.Trim() + "        " +
                        doc.DocumentNode.SelectSingleNode(Xpath8).InnerText.Trim() + "        " +
                        doc.DocumentNode.SelectSingleNode(Xpath9).InnerText.Trim());

                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Hatalı xpath");
                }
            }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            
            lisbx1.Items.Clear();
            lisbx3.Items.Clear();
           // listBox3.Items.Clear();
            WebClient client = new WebClient();
            client.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            client.Headers.Add("Accept: text/html, application/xhtml+xml, */*");
            client.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            //  string html = client.DownloadString(url);

            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            // dokuman.LoadHtml(html);
            int sayı = 0;

            for (int i = 1; i < 15; i += 2)
            {
                verial3("https://www.ucuzabilet.com/ic-hat-arama-sonuc?from=SAW&to=TZX&ddate=16.04.2021&adult=1",
                "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[1]/div[1]",
                "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[2]/b",
                "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[2]/div",
                "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[1]/div[3]",
                "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[4]/b/text()",
                "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[3]/span",
                "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[3]/div[2]/text()",
                "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[4]/div",
                "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[5]/div[2]/span", lisbx2);
            }
            for (int j = 15; j < 43; j += 2)
            {
                verial4("https://www.ucuzabilet.com/ic-hat-arama-sonuc?from=SAW&to=TZX&ddate=16.04.2021&adult=1",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[1]/div[1]",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[2]/b",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[2]/div",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[1]/div[3]",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[4]/b",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[3]/span",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[3]/div[2]/text()",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[4]/div",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[5]/div[2]/span", lisbx2);


            }

            /*  string veri1 = dokuman.DocumentNode.SelectNodes("/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[1]/td[4]")[sayı].InnerText;
              string veri2 = dokuman.DocumentNode.SelectNodes("/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[1]/td[5]/div[1]/span")[sayı].InnerText;
              string veri3 = dokuman.DocumentNode.SelectNodes("/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[1]/td[3]/span")[sayı].InnerText;
              string veri4 = dokuman.DocumentNode.SelectNodes("/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[1]/td[2]")[sayı].InnerText;
              string veri5 = dokuman.DocumentNode.SelectNodes("/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[1]/td[1]/div[1]")[sayı].InnerText;
              string veri6 = dokuman.DocumentNode.SelectNodes("/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[1]/td[1]/div[3]")[sayı].InnerText;
              string veri0 = dokuman.DocumentNode.SelectNodes("/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table")[sayı].InnerText;

                listBox1.Text = veri6.Trim().Replace(" ",string.Empty)+"            " + veri5.Trim().Replace(" ", string.Empty)+"           "  
                    + veri4.Trim().Replace(" ",string.Empty)+"          " + veri3.Trim().Replace(" ",string.Empty)+"          "
                    + veri1.Trim().Replace(" ",string.Empty)+"        " + veri2.Trim().Replace(" ",string.Empty);



              //string resim_yolu = "/html/body/main/div[4]/div[1]/section[1]/div[2]/ul/li[1]/a/div";
            */
        }
        public void verial3(String Url, String Xpath, String Xpath2, String Xpath3, String Xpath4, String Xpath5, String Xpath6,
            String Xpath7, String Xpath8, String Xpath9, ListBox snc)
        {
            try
            {
                url = new Uri(Url);


            }
            catch (UriFormatException)
            {
                MessageBox.Show("url hatası");
            }
            WebClient web = new WebClient();
            web.Encoding = Encoding.UTF8;
            try
            {
                html = web.DownloadString(url);

            }
            catch (WebException)
            {

            }
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            try
            {//Pegasus
                snc.Items.Add(doc.DocumentNode.SelectSingleNode(Xpath).InnerText + "     " +
                    doc.DocumentNode.SelectSingleNode(Xpath2).InnerText + "       " +
                    doc.DocumentNode.SelectSingleNode(Xpath3).InnerText + "       " +
                    doc.DocumentNode.SelectSingleNode(Xpath4).InnerText + "       " +
                    doc.DocumentNode.SelectSingleNode(Xpath5).InnerText.Trim() + "        " +
                    doc.DocumentNode.SelectSingleNode(Xpath6).InnerText.Trim() + "        " +
                    doc.DocumentNode.SelectSingleNode(Xpath7).InnerText.Trim() + "        " +
                    doc.DocumentNode.SelectSingleNode(Xpath8).InnerText + "       " +
                    doc.DocumentNode.SelectSingleNode(Xpath9).InnerText);

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Hatalı xpath");
            }
        }

        public void verial4(String Url, String Xpath1, String Xpath2, String Xpath3, String Xpath4, String Xpath5,
            String Xpath6, String Xpath7, String Xpath8, String Xpath9, ListBox snc)
        {
            try
            {
                url = new Uri(Url);


            }
            catch (UriFormatException)
            {
                MessageBox.Show("url hatası");
            }
            WebClient web = new WebClient();
            web.Encoding = Encoding.UTF8;
            try
            {
                html = web.DownloadString(url);

            }
            catch (WebException)
            {

            }
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            try
            {//AnadoluJet
                snc.Items.Add(doc.DocumentNode.SelectSingleNode(Xpath1).InnerText + "     " +
                    doc.DocumentNode.SelectSingleNode(Xpath2).InnerText + "       " +
                    doc.DocumentNode.SelectSingleNode(Xpath3).InnerText.Trim() + "        " +
                    doc.DocumentNode.SelectSingleNode(Xpath4).InnerText + "       " +
                    doc.DocumentNode.SelectSingleNode(Xpath5).InnerText.Trim() + "        " +
                    doc.DocumentNode.SelectSingleNode(Xpath6).InnerText.Trim() + "        " +
                    doc.DocumentNode.SelectSingleNode(Xpath7).InnerText.Trim() + "        " +
                    doc.DocumentNode.SelectSingleNode(Xpath8).InnerText.Trim() + "        " +
                    doc.DocumentNode.SelectSingleNode(Xpath9).InnerText.Trim());

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Hatalı xpath");
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
           
            lisbx1.Items.Clear();
            lisbx2.Items.Clear();

            WebClient client = new WebClient();
            client.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            client.Headers.Add("Accept: text/html, application/xhtml+xml, */*");
            client.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            //  string html = client.DownloadString(url);

            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            // dokuman.LoadHtml(html);
            int sayı = 0;

            for (int i = 1; i < 15; i += 2)
            {
                veria5("https://www.ucuzabilet.com/ic-hat-arama-sonuc?from=SAW&to=TZX&ddate=17.04.2021&adult=1",
                "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[1]/div[1]",
                "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[2]/b",
                "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[2]/div",
                "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[1]/div[3]",
                "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[4]/b/text()",
                "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[3]/span",
                "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[3]/div[2]/text()",
                "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[4]/div",
                "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + i + "]/td[5]/div[2]/span", lisbx3);
            }
            for (int j = 15; j < 37; j += 2)
            {
                verial6("https://www.ucuzabilet.com/ic-hat-arama-sonuc?from=SAW&to=TZX&ddate=17.04.2021&adult=1",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[1]/div[1]",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[2]/b",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[2]/div",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[1]/div[3]",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[4]/b",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[3]/span",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[3]/div[2]/text()",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[4]/div",
                    "/html/body/div[3]/div[5]/div[2]/div/div/div[2]/table/tbody/tr[" + j + "]/td[5]/div[2]/span", lisbx3);


            }

        }

        public void veria5(String Url, String Xpath, String Xpath2, String Xpath3, String Xpath4, String Xpath5, String Xpath6,
            String Xpath7, String Xpath8, String Xpath9, ListBox snc1)
        {
            try
            {
                url = new Uri(Url);


            }
            catch (UriFormatException)
            {
                MessageBox.Show("url hatası");
            }
            WebClient web = new WebClient();
            web.Encoding = Encoding.UTF8;
            try
            {
                html = web.DownloadString(url);

            }
            catch (WebException)
            {

            }
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            try
            {//Pegasus

                snc1.Items.Add(doc.DocumentNode.SelectSingleNode(Xpath).InnerText + "     " +
                    doc.DocumentNode.SelectSingleNode(Xpath2).InnerText + "       " +
                    doc.DocumentNode.SelectSingleNode(Xpath3).InnerText + "       " +
                    doc.DocumentNode.SelectSingleNode(Xpath4).InnerText + "       " +
                    doc.DocumentNode.SelectSingleNode(Xpath5).InnerText.Trim() + "        " +
                    doc.DocumentNode.SelectSingleNode(Xpath6).InnerText.Trim() + "        " +
                    doc.DocumentNode.SelectSingleNode(Xpath7).InnerText.Trim() + "        " +
                    doc.DocumentNode.SelectSingleNode(Xpath8).InnerText + "       " +
                    doc.DocumentNode.SelectSingleNode(Xpath9).InnerText);

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Hatalı xpath");
            }
        }

        public void verial6(String Url, String Xpath1, String Xpath2, String Xpath3, String Xpath4, String Xpath5,
            String Xpath6, String Xpath7, String Xpath8, String Xpath9, ListBox snc1)
        {
            try
            {
                url = new Uri(Url);


            }
            catch (UriFormatException)
            {
                MessageBox.Show("url hatası");
            }
            WebClient web = new WebClient();
            web.Encoding = Encoding.UTF8;
            try
            {
                html = web.DownloadString(url);

            }
            catch (WebException)
            {

            }
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            try
            {//AnadoluJet

                snc1.Items.Add(doc.DocumentNode.SelectSingleNode(Xpath1).InnerText + "     " +
                    doc.DocumentNode.SelectSingleNode(Xpath2).InnerText + "       " +
                    doc.DocumentNode.SelectSingleNode(Xpath3).InnerText.Trim() + "        " +
                    doc.DocumentNode.SelectSingleNode(Xpath4).InnerText + "       " +
                    doc.DocumentNode.SelectSingleNode(Xpath5).InnerText.Trim() + "        " +
                    doc.DocumentNode.SelectSingleNode(Xpath6).InnerText.Trim() + "        " +
                    doc.DocumentNode.SelectSingleNode(Xpath7).InnerText.Trim() + "        " +
                    doc.DocumentNode.SelectSingleNode(Xpath8).InnerText.Trim() + "        " +
                    doc.DocumentNode.SelectSingleNode(Xpath9).InnerText.Trim());


            }

            catch (NullReferenceException)
            {
                
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            lisbx1.Items.Clear();
            lisbx2.Items.Clear();
            lisbx3.Items.Clear();
        }

        private void Label_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
