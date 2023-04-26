using Guna.UI2.WinForms;
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
    public partial class FormClouds : Form
    {
        private int currentLabelIndex = 0;
        private String[] txts = { "#Create", "#Contribute", "#Store", "#Share" };
        private Timer timer = new Timer();

        private Guna2Button selectedButton;
        public FormClouds()
        {
            InitializeComponent();
            InitWebView();
            selectedButton = buttonGitHub;
            UpdateButtonColors();

            label1.Text= txts[currentLabelIndex];
            timer.Interval = 2000; // set timer interval to 2 seconds
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start(); // start the timer
        }

        void timer_Tick(object sender, EventArgs e)
        {
            currentLabelIndex=(currentLabelIndex+1)%txts.Length; // increment the index of the current visible label
            label1.Text = txts[currentLabelIndex];
        }



        async void InitWebView()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.Navigate("https://github.com/");

        }

        private void UpdateButtonColors()
        {
            // Set the background color of all buttons to their default color

            foreach (Guna2Button button in guna2Panel1.Controls.OfType<Guna2Button>())
            {
                if (button != selectedButton)
                {
                    button.BackColor = Color.Transparent;
                    button.FillColor = Color.Transparent;
                }
                else
                {
                    button.BorderRadius = 15;
                    button.FillColor = Color.FromArgb(71, 207, 115);
                    button.BackColor = Color.Transparent;
                }
            }


        }

        private void buttonGitHub_Click(object sender, EventArgs e)
        {
            selectedButton = (Guna2Button)sender;
            UpdateButtonColors();
            webView21.CoreWebView2.Navigate("https://github.com/");
        }

        private void buttonGitLab_Click(object sender, EventArgs e)
        {
            selectedButton = (Guna2Button)sender;
            UpdateButtonColors();
            webView21.CoreWebView2.Navigate("https://gitlab.com/");
        }

        private void buttonBitBucket_Click(object sender, EventArgs e)
        {
            selectedButton = (Guna2Button)sender;
            UpdateButtonColors();
            webView21.CoreWebView2.Navigate("https://bitbucket.org/");
        }

        private void buttonPasteBin_Click(object sender, EventArgs e)
        {
            selectedButton = (Guna2Button)sender;
            UpdateButtonColors();
            webView21.CoreWebView2.Navigate("https://bitbucket.org/");
        }

        private void buttonReplIt_Click(object sender, EventArgs e)
        {
            selectedButton = (Guna2Button)sender;
            UpdateButtonColors();
            webView21.CoreWebView2.Navigate("https://github.com/");
        }

        private void buttonGist_Click(object sender, EventArgs e)
        {
            selectedButton = (Guna2Button)sender;
            UpdateButtonColors();
            webView21.CoreWebView2.Navigate("https://github.com/");
        }

        private void buttonPasteCode_Click(object sender, EventArgs e)
        {
            selectedButton = (Guna2Button)sender;
            UpdateButtonColors();
            webView21.CoreWebView2.Navigate("https://github.com/");
        }

        private void buttonJSFiddle_Click(object sender, EventArgs e)
        {
            selectedButton = (Guna2Button)sender;
            UpdateButtonColors();
            webView21.CoreWebView2.Navigate("https://github.com/");
        }

        private void buttonCodeSandbox_Click(object sender, EventArgs e)
        {
            selectedButton = (Guna2Button)sender;
            UpdateButtonColors();
            webView21.CoreWebView2.Navigate("https://github.com/");
        }
    }
}
