using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter9
{
    public partial class Form1 : Form
    {
        Crawler crawler = new Crawler();
        public Form1()
        {
            InitializeComponent();

            string startUrl = "http://www.baidu.com/";
            crawler.urls.Add(startUrl, false);
            label1.DataBindings.Add("Text", crawler, "HTML");
            new Thread(crawler.Crawl).Start();
            //crawler.Crawl();




        }



    }
}
