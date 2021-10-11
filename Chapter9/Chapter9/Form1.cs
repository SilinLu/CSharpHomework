using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter9
{

    
    public delegate void CrawlerHandler(object sender, EventArgs e);
    public partial class Form1 : Form
    {


        Thread thread1 ,thread2;



        public Form1()
        {
            InitializeComponent();
            thread1 = new Thread(Crawl);
            thread2 = new Thread(CrawlAsync);
        }
        

        public Hashtable urls = new Hashtable();
        public Hashtable URLS
        {
            get; set;
        }



        private string html;

        public string current { get; set; }
        

        private int count = 0;



        public void Crawl()
        {
            Action act;
            try
            {
               


                while (true)
                {
                    current = null;
                    foreach (string url in urls.Keys)
                    {
                        if ((bool)urls[url]) continue;
                        current = url;
                        break;

                    }
                    if (current == null || count > 10) break;

                    
                    html=Download(current);


                    Console.WriteLine(html);
                    if (label3.InvokeRequired && listBox1.InvokeRequired)
                    {
                        act = delegate () {
                            label3.Text = html;
                            listBox1.Items.Add(current);
                        };
                        Invoke(act);
                    }

                    urls[current] = true;

                    count++;

                    Parse(html);
                }
            }
            catch (Exception e)
            {

                if (label5.InvokeRequired)
                {
                    act = delegate () {
                        label5.Text = e.ToString();
                        
                    };
                    Invoke(act);
                }
            }
            finally
            {
                count = 0;
            }

        }


        public void CrawlAsync()
        {
            Action act;
            try
            {



                while (true)
                {
                    current = null;
                    foreach (string url in urls.Keys)
                    {
                        if ((bool)urls[url]) continue;
                        current = url;
                        break;

                    }
                    if (current == null || count > 10) break;


                    DownloadAsync(current);
                    while (html == null) ;

                    Console.WriteLine(html);
                    if (label3.InvokeRequired && listBox1.InvokeRequired)
                    {
                        act = delegate () {
                            label3.Text = html;
                            listBox1.Items.Add(current);
                        };
                        Invoke(act);
                    }

                    urls[current] = true;

                    count++;

                    Parse(html);
                }
            }
            catch (Exception e)
            {

                if (label5.InvokeRequired)
                {
                    act = delegate () {
                        label5.Text = e.ToString();

                    };
                    Invoke(act);
                }
            }
            finally
            {
                count = 0;
            }

        }

        private string Download(string url)
        {
            try
            {

                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;


                string html = webClient.DownloadString(url);
                string fileName = count.ToString();

                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
                


            }
            catch (Exception e)
            {

                throw e;
            }
        }

        private void DownloadAsync(string url)
        {
            try
            {

                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;

                webClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(DownloadCompleted);
                webClient.DownloadStringAsync(new Uri(url));
             

            }
            catch (Exception e)
            {

                throw e;
            }
        }
       private void DownloadCompleted(object sender,DownloadStringCompletedEventArgs args)
        {
            Action act;
            try
            {
                html = args.Result;
            }
            catch (Exception ex)
            {
                if (label5.InvokeRequired)
                {
                    act = delegate () {
                        label5.Text = ex.ToString();

                    };
                    Invoke(act);
                }

            }
            finally
            {
                count = 0;
            }
            
        }
        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+(html|htm|aspx|jsp|com|cn)+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).
                    Trim('"', '\"', '#', '>');
                Uri baseUri = new Uri(current);
                Uri absoluteUri = new Uri(baseUri, strRef);
                strRef = absoluteUri.ToString();
                if (strRef.Length == 0)
                    continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }

        private void buttonNormal_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                label5.Text = "";
                urls.Clear();
                string startUrl = textBox1.Text;
                urls.Add(startUrl, false);
                thread1.Start();

            }
            catch (Exception ex)
            {

                label5.Text = ex.ToString();
            }

        }


        private void buttonThread_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                label5.Text = "";
                urls.Clear();
                string startUrl = textBox1.Text;
                urls.Add(startUrl, false);
                thread2.Start();

            }
            catch (Exception ex)
            {

                label5.Text = ex.ToString();
            }
        }
    }
}
