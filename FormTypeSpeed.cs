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
            InitWebView();
        }

        async void InitWebView()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.Navigate("https://monkeytype.com/");

        }
    }
}
