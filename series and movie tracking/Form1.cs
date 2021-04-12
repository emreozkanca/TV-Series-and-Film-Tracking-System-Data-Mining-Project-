using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Timer t = new Timer();
       
        private void t_Tick(object sender, EventArgs e)
        {
            int width = this.Width;
            if (label4.Location.X > width - label4.Width)
            {
                circle1.Location = new Point(-200, circle1.Location.Y);
                label1.Location = new Point(-590, label1.Location.Y);

                circle2.Location = new Point(-50, circle2.Location.Y);
                label2.Location = new Point(-175, label2.Location.Y);

                circle3.Location = new Point(-600, circle3.Location.Y);
                label3.Location = new Point(-40, label3.Location.Y);

                circle4.Location = new Point(-400, circle4.Location.Y);
                label6.Location = new Point(-390, label6.Location.Y);

                circle6.Location = new Point(-600, circle6.Location.Y);
                label7.Location = new Point(-570, label7.Location.Y);

                circle7.Location = new Point(-400, circle7.Location.Y);
                label10.Location = new Point(-393, label10.Location.Y);

                circle5.Location = new Point(-200, circle5.Location.Y);
                label9.Location = new Point(-175, label9.Location.Y);

                circle8.Location = new Point(-50, circle8.Location.Y);
                label11.Location = new Point(-22, label11.Location.Y);


                label4.Location = new Point(-600, label4.Location.Y);

            }
            else
            {
                circle1.Location = new Point(circle1.Location.X + 3, circle1.Location.Y);
                circle2.Location = new Point(circle2.Location.X + 3, circle2.Location.Y);
                circle3.Location = new Point(circle3.Location.X + 3, circle3.Location.Y);
                circle4.Location = new Point(circle4.Location.X + 3, circle4.Location.Y);
                circle6.Location = new Point(circle6.Location.X + 3, circle6.Location.Y);
                circle7.Location = new Point(circle7.Location.X + 3, circle7.Location.Y);
                circle5.Location = new Point(circle5.Location.X + 3, circle5.Location.Y);
                circle8.Location = new Point(circle8.Location.X + 3, circle8.Location.Y);



                label1.Location = new Point(label1.Location.X + 3, label1.Location.Y);
                label2.Location = new Point(label2.Location.X + 3, label2.Location.Y);
                label3.Location = new Point(label3.Location.X + 3, label3.Location.Y);
                label4.Location = new Point(label4.Location.X + 3, label4.Location.Y);
                label6.Location = new Point(label6.Location.X + 3, label6.Location.Y);
                label7.Location = new Point(label7.Location.X + 3, label7.Location.Y);
                label10.Location = new Point(label10.Location.X + 3, label10.Location.Y);
                label9.Location = new Point(label9.Location.X + 3, label9.Location.Y);
                label11.Location = new Point(label11.Location.X + 3, label11.Location.Y);

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            t.Start();
            t.Interval = 1;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;

            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url:"https://www.dizibox.pw/");
            
            foreach (var item in doc.DocumentNode.SelectNodes(xpath: "//ul[@id='recommended_series']"))
            {
                label1.Text = item.ChildNodes[1].InnerText.Trim();
                label6.Text = item.ChildNodes[5].InnerText.Trim();
                label2.Text = item.ChildNodes[3].InnerText.Trim();
                label3.Text = item.ChildNodes[7].InnerText.Trim();
                label7.Text = item.ChildNodes[9].InnerText.Trim();
                label10.Text = item.ChildNodes[11].InnerText.Trim();
                label9.Text = item.ChildNodes[13].InnerText.Trim();
                label11.Text = item.ChildNodes[15].InnerText.Trim();


            }
            circle3.Image = Resim(@"https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQc0uDAiKlG59MXaGtloPf1W9vSHCYvFy9wDQ&usqp=CAU");
            circle4.Image = Resim(@"https://cdn.webrazzi.com/uploads/2018/12/hakan-muhafiz-netflix.jpg");
            circle1.Image = Resim(@"https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQ4RwmStk90Xi9emd2mSzai-K-2dKR1Ah3TiA&usqp=CAU");
            circle2.Image = Resim(@"https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRAPoBF7z7Mits_iTKOk3tk4gY3P0_o4eG6Xg&usqp=CAU");
            circle6.Image = Resim(@"https://imgrosetta.mynet.com.tr/file/12090752/12090752-728xauto.jpg");
            circle7.Image = Resim(@"https://i4.hurimg.com/i/hurriyet/75/770x0/5912380d18c77326480102c0");
            circle5.Image = Resim(@"https://i.hizliresim.com/95zNbO.jpg");
            circle8.Image = Resim(@"https://tr.web.img4.acsta.net/pictures/14/02/16/23/53/181925.jpg?coixp=50&coiyp=39");

           

            Bitmap Resim(string Url)
            {
                WebRequest rs = WebRequest.Create(Url);
                return (Bitmap)Bitmap.FromStream(rs.GetResponse().GetResponseStream());
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dizibox.pw/diziler/stranger-things-izle-2");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dizibox.pw/diziler/hakan-muhafiz-the-protector-izle-1");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dizibox.pw/diziler/fargo-izle");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dizibox.pw/diziler/exatlon-challenge-turkiye-izle/");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dizibox.pw/diziler/dark-izle-1");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dizibox.pw/diziler/olmek-icin-on-uc-sebep-13-reasons-why-izle");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dizibox.pw/diziler/snowpiercer");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dizibox.pw/diziler/the-100-izle-1");
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            t.Stop();
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            t.Start();
        }
    }

}
