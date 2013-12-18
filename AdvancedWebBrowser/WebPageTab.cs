using System;
using System.Windows.Forms;

namespace AdvancedWebBrowser
{
    public class WebPageTab : TabPage
    {
        private WebBrowser Browser
        {
            get;
            set;
        }

        public WebPageTab() : this(new Uri("about:blank"))
        { }
        public WebPageTab(string url) : this(new Uri(url))
        { }
        public WebPageTab(Uri uri)
        {
            Browser = new WebBrowser();

            Browser.Dock = DockStyle.Fill;

            Browser.DocumentTitleChanged += Browser_DocumentTitleChanged;
            Browser.Navigating += Browser_Navigating;
            Browser.Navigated += Browser_Navigated;

            this.Controls.Add(Browser);
            Browser.Navigate(uri);
        }

        private void Browser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            
        }

        private void Browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            
        }

        private void Browser_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.Text = (sender as WebBrowser).DocumentTitle;
        }
    }
}