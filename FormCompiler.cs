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
using Guna.UI2.WinForms;

namespace Coder_s_space
{
    public partial class FormCompiler : Form
    {
        //ChromiumWebBrowser browser;
        private Guna2Button selectedButton;
        public FormCompiler()
        {
            InitializeComponent();
            InitWebView();
            selectedButton = guna2ButtonCs;
            UpdateButtonColors();

            //FunctionsAll.RoundButtonParams(20, buttonCpp,buttonCs);

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

        

        private void panelBrowser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void guna2CustomGradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonCourse_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            selectedButton = guna2ButtonCs;
            UpdateButtonColors();
            webView21.CoreWebView2.Navigate("https://www.tutorialspoint.com/compile_csharp_online.php");
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            selectedButton = guna2ButtonSwift;
            UpdateButtonColors();
            webView21.CoreWebView2.Navigate("https://www.tutorialspoint.com/compile_swift_online.php");
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            selectedButton = guna2ButtonJs;
            UpdateButtonColors();
            webView21.CoreWebView2.Navigate("https://www.tutorialspoint.com/online_javascript_editor.php");

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            selectedButton = guna2ButtonHtml;
            UpdateButtonColors();
            webView21.CoreWebView2.Navigate("https://www.tutorialspoint.com/online_html_editor.php");

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            selectedButton = guna2ButtonPhp;
            UpdateButtonColors();
            webView21.CoreWebView2.Navigate("https://www.tutorialspoint.com/execute_php_online.php");

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            selectedButton = guna2ButtonPython;
            UpdateButtonColors();
            webView21.CoreWebView2.Navigate("https://www.tutorialspoint.com/execute_python_online.php");

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            selectedButton = guna2ButtonJava;
            UpdateButtonColors();
            webView21.CoreWebView2.Navigate("https://www.tutorialspoint.com/online_java_compiler.php");

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            selectedButton = guna2ButtonCp;
            UpdateButtonColors();
            webView21.CoreWebView2.Navigate("https://www.tutorialspoint.com/compile_c_online.php");

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            selectedButton = guna2ButtonCpp;
            UpdateButtonColors();
            webView21.CoreWebView2.Navigate("https://www.tutorialspoint.com/compile_cpp_online.php");
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            selectedButton = guna2ButtonSQL;
            UpdateButtonColors();
            webView21.CoreWebView2.Navigate("https://www.tutorialspoint.com/execute_sql_online.php");

        }
        private void UpdateButtonColors()
        {
            // Set the background color of all buttons to their default color
            
            foreach (Guna2Button button in guna2Panel1.Controls.OfType<Guna2Button>())
            {
                if (button != selectedButton)
                {
                    button.BackColor = Color.Transparent;
                    button.FillColor= Color.Transparent;
                }
                else
                {
                    button.BorderRadius = 15;
                    button.FillColor = Color.Violet;
                    button.BackColor = Color.Transparent;
                }
            }
            
            
        }
    }
}
