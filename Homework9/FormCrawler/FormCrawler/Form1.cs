using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrawlerForm;

namespace FormCrawler

{
    public partial class FormCrawl : Form
    {
        BindingSource resultBindingSource = new BindingSource();
        Crawler Crawler = new Crawler();
        Thread thread = null;
        public FormCrawl()
        {
            InitializeComponent();
            dataGridView1.DataSource = resultBindingSource;
            Crawler.PageDownloaded += PageDownloaded;

        }
        
        private void PageDownloaded(Crawler crawler, string url, string info)
        {
            var pageInfo = new { Index = resultBindingSource.Count + 1, URL = url, Status = info };
            Action action = () => { resultBindingSource.Add(pageInfo); };
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            resultBindingSource.Clear();
            Crawler.StartURL = UrlText.Text;

            Match match = Regex.Match(Crawler.StartURL, Crawler.urlParseRegex);
            if (match.Length == 0) return;
            string host = match.Groups["host"].Value;
            Crawler.HostFilter = "^" + host + "$";
            Crawler.FileFilter = ".html?$";

            if (thread != null)
            {
                thread.Abort();
            }
            thread = new Thread(Crawler.Start);
            thread.Start();
        }
    }
}
