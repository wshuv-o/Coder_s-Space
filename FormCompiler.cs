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

namespace Coder_s_space
{
    public partial class FormCompiler : Form
    {
        ChromiumWebBrowser browser;

        public FormCompiler()
        {
            InitializeComponent();
            var settings = new CefSettings();
            settings.PersistSessionCookies = true;

            Cef.Initialize(settings);

             browser = new ChromiumWebBrowser("https://www.facebook.com");
            browser.Dock = DockStyle.Fill;
            panelBrowser.Controls.Add(browser); 



        }

        private void FormCompiler_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
