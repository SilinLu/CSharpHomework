using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Chapter9
{
    class Crawler :INotifyPropertyChanged
    {
        public Hashtable urls = new Hashtable();
        public Hashtable URLS
        {
            get;set;
        }


        public string HTML
        {
            get { return html; }
            set { if (html != value) { html = value; FirePropertyChanged("HTML"); } } //<--通知属性更改，相关控件可以更新显示
        }

        private string html;

        public string current { get; set; }

        private int count = 0;



        public event PropertyChangedEventHandler PropertyChanged;

        void FirePropertyChanged(string propertyname)
        {
            PropertyChangedEventHandler propertychanged = this.PropertyChanged;
            if (propertychanged != null) propertychanged(this, new PropertyChangedEventArgs(propertyname));
        }



        public void Crawl()
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
                urls[current] = true;
                count++;
                Parse(html);
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

                return e.Message;
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
                Uri absoluteUri = new Uri(baseUri,strRef);
                strRef = absoluteUri.ToString();
                if (strRef.Length == 0)
                    continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
        

    }
}
