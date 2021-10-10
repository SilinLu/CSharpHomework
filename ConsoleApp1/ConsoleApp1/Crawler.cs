using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace ConsoleApp1
{
    class Crawler
    {
        public Hashtable urls = new Hashtable();
        private int count = 0;


        static void Main(string []args)
        {
            Crawler crawler = new Crawler();
            string starturl = Console.ReadLine();
            if (args.Length>=1)
            {
                starturl = args[0];
            }
            crawler.urls.Add(starturl, false);
            new Thread(crawler.Crawl).Start();
        }

        public void Crawl()
        {
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url])
                    {
                        continue;
                    }
                    current = url;

                }
                if (current == null || count > 10)
                {
                    break;
                }

                string html = Download(current);
                Console.WriteLine(current+"----------------current------------------------------------");
                urls[current] = true;
                count++;
                Parse(html,current);

            }

        }
        public string Download(string url)
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
        public void Parse(string html,string baseUrl)
        {
            string strRef = @"(href|Href)=[""'][^""'#>]+(html|htm|aspx|jsp|.com|.cn)+[""']";/**(html|htm|aspx|jsp)+**/
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', ',', '>');
                if (strRef.Length == 0) continue;
                Uri baseUri = new Uri(baseUrl);
                Uri absoluteUri = new Uri(baseUri, strRef);
                strRef = absoluteUri.ToString();
                if (urls[strRef] == null) urls[strRef] = false;
                Console.WriteLine(strRef);
            }

        }

    }
}
