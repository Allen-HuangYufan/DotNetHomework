using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace homework9
{
    class Crawler
    {
        public event Action<Crawler> CrawlerStopped;
        public event Action<Crawler, int, string, string> PageDownloaded;
        
        private ConcurrentQueue<string> queue = new ConcurrentQueue<string>();
        
        private ConcurrentDictionary<string, bool> downloadedPages { get; } = new ConcurrentDictionary<string, bool>();
        
        public static readonly string UrlDetectRegex = @"(href|HREF)[]*=[]*[""'](?<url>[^""'#>]+)[""']";
        
        public static readonly string urlParseRegex = @"^(?<site>(?<protocal>https?)://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
        
        public string HostFilter { get; set; }
        
        public string FileFilter { get; set; }
        
        public int MaxPage { get; set; }
        
        public string StartURL { get; set; }
        
        public Encoding HtmlEncoding { get; set; }

        public Crawler()
        {
            MaxPage = 100;
            HtmlEncoding = Encoding.UTF8;
        }

        public void Start()
        {
            downloadedPages.Clear();
            queue = new ConcurrentQueue<string>();
            queue.Enqueue(StartURL);

            List<Task> tasks = new List<Task>();
            int completedTasks = 0;
            PageDownloaded += (crawler, index, url, info) => { completedTasks++; };
            
            while (tasks.Count < MaxPage)
            {
                if (!queue.TryDequeue(out string url))
                {
                    if (completedTasks < tasks.Count) 
                        continue;
                    else 
                        break;
                }
                int index = tasks.Count;
                Task task = Task.Run(() => ParseAndDownload(url, index));
                tasks.Add(task);
            }
            Task.WaitAll(tasks.ToArray());
            CrawlerStopped(this);
        }

        private void ParseAndDownload(string url, int index)
        {
            try
            {
                string html = DownLoad(url, index);
                downloadedPages[url] = true;
                Parse(html, url);//解析,并加入新的链接
                PageDownloaded(this, index, url, "success");
            }
            catch (Exception ex)
            {
                PageDownloaded(this, index, url, "Error:" + ex.Message);
            }
        }

        private string DownLoad(string url, int index)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = HtmlEncoding;
            string html = webClient.DownloadString(url);
            File.WriteAllText(index + ".html", html, Encoding.UTF8);
            return html;
        }



        private void Parse(string html, string pageUrl)
        {
            var matches = new Regex(UrlDetectRegex).Matches(html);
            foreach (Match match in matches)
            {
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "" || linkUrl.StartsWith("javascript:")) continue;

                linkUrl = FixUrl(linkUrl, pageUrl);

                Match linkUrlMatch = Regex.Match(linkUrl, urlParseRegex);
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;
                if (file == "") file = "index.html";

                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, FileFilter)
                  && !downloadedPages.ContainsKey(linkUrl))
                {
                    queue.Enqueue(linkUrl);
                    downloadedPages.TryAdd(linkUrl, false);
                }
            }
        }

        static private string FixUrl(string url, string pageUrl)
        {
            if (url.Contains("://"))
            { 
                return url;
            }
            if (url.StartsWith("//"))
            {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                string protocal = urlMatch.Groups["protocal"].Value;
                return protocal + ":" + url;
            }
            if (url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }
            if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = pageUrl.LastIndexOf('/');
                return FixUrl(url, pageUrl.Substring(0, idx));
            }
            if (url.StartsWith("./"))
            {
                return FixUrl(url.Substring(2), pageUrl);
            }
            int end = pageUrl.LastIndexOf("/");
            return pageUrl.Substring(0, end) + "/" + url;
        }
    }
}
