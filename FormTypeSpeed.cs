using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System.IO;
using Guna.UI2.WinForms;

namespace Coder_s_space
{
    public partial class FormTypeSpeed : Form
    {
        public FormTypeSpeed()
        {
            InitializeComponent();
            // InitWebView();
            webView21.CreationProperties = new CoreWebView2CreationProperties()
            {
                // Set the browser's user data folder to store cookies, history, and settings
                UserDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\MyWebView2UserData",
                
                // Enable built-in ad-blocking
                AdditionalBrowserArguments = "--disable-features=PreloadMediaEngagementData,AutoplayIgnoreWebAudio," +
                "AsyncFrameScrolling,AdaptiveFlingPhysics,WebFontsInterventionTrigger,LayoutNG,HeavyAdIntervention,HeavyAdPrivacyMitigations",
            };

            webView21.CoreWebView2InitializationCompleted += WebView21_CoreWebView2InitializationCompleted;
            webView21.EnsureCoreWebView2Async();
        }

        private void WebView21_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                // Navigate to your desired website
                webView21.CoreWebView2.Navigate("https://www.facebook.com");
            }
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }
    }

}
