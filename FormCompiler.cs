using CefSharp;
using CefSharp.WinForms;
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


namespace Coder_s_space
{
    public partial class FormCompiler : Form
    {
        //ChromiumWebBrowser browser;
        public FormCompiler()
        {
            InitializeComponent();
            InitWebView();
            /*var settings = new CefSettings();
            settings.PersistSessionCookies = true;

            Cef.Initialize(settings);

             browser = new ChromiumWebBrowser("https://www.facebook.com");
            browser.Dock = DockStyle.Fill;
            panelBrowser.Controls.Add(browser); */

            





        }

        private async void FormCompiler_Load(object sender, EventArgs e)
        {
           
        }
       async void InitWebView()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.Navigate("https://www.tutorialspoint.com/compile_csharp_online.php");

        }



        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void voteLabel_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.tutorialspoint.com/compile_cpp_online.php");

        }

        private void panelBrowser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
