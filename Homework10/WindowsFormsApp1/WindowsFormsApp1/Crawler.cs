using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlerForm
{


    class Crawler
    {
        public ConcurrentBag<UrlStates> urls = new ConcurrentBag<UrlStates>();
        public int count = 0;
        static public string startUrl = "";
        static public string startWith = "";
        public event Action<Crawler, UrlStates> PageDownloaded;
        public void Crawl()
        {
            UrlStates surl = new UrlStates() { url = startUrl, processing = false, html = "" };
            urls.Add(surl);

            string str = @"(www\.){0,1}.*?\..*?/";
            Regex r = new Regex(str);
            Match m = r.Match(startUrl);
            startWith = m.Value;

            while (true)
            {
                UrlStates current = null;
                foreach (var url in urls)
                {
                    if (url.processing) continue;
                    current = url;
                    if (count > 20)
                        break;
                    if (current == null)
                        continue;
                    current.processing = true;
                    var t = new Thread(() => Process(current));
                    t.Start();
                    count++;
                }
            }
        }

        public bool UrlExists(string url)
        {

            foreach (UrlStates u in urls)
            {
                if (u.url == url)
                    return true;
            }
            return false;
        }


        public void Process(UrlStates url)
        {
            try
            {

                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url.url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                url.html = html;
                PageDownloaded(this, url);
                Parse(html, url.url);//解析,并加入新的链接
            }
            catch (Exception)
            {

            }
        }

        private void Parse(string html, string oldUrl)
        {

            //匹配不含相对路径,且包含html的网址
            string strRef = @"(href|HREF)[ ]*=[ ]*[""'](http|https)[^""'#>]+..html.*?[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                var url = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (url.Length == 0)
                    continue;
                //仅包含起始网站上的网页
                if (url.Contains(startWith))
                {
                    if (!UrlExists(url))
                    {
                        urls.Add(new UrlStates() { url = url, processing = false, html = "" });
                    }

                }
            }


            strRef = @"(href|HREF)[ ]*=[ ]*[""'][^(http|https)][^""'#>]+..html.*?[""']";
            matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                var url = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (url.Length == 0) continue;
                Uri baseUri = new Uri(oldUrl);
                Uri absoluteUri = new Uri(baseUri, url);
                if (url.Contains(startWith))
                {
                    if (!UrlExists(url))
                    {
                        urls.Add(new UrlStates() { url = url, processing = false, html = "" });
                    }
                }
            }
        }
    }
    class UrlStates
    {
        public string url { get; set; }    
        public bool processing { get; set; }
        public string html { get; set; }

    }
}

