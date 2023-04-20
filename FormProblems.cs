using Guna.UI2.WinForms;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace Coder_s_space
{

    public partial class FormProblems : Form
    {
        Microsoft.Web.WebView2.WinForms.WebView2 webView2k = new Microsoft.Web.WebView2.WinForms.WebView2();

        Form activeForm = null;
        private List<Image> _images = new List<Image>(); // List of images to display
        private int _currentIndex = 0; // Index of the current image being displayed
        private Timer _timer = new Timer(); // Timer to move the picture

        public FormProblems()
        {
            InitializeComponent();
            InitWebView();
            _images.Add(Coder_s_space.Properties.Resources.banner_for_Coder_s_space);
            _images.Add(Coder_s_space.Properties.Resources.banner_for_Coder_s_space__4_);
            _images.Add(Coder_s_space.Properties.Resources.banner_for_Coder_s_space__1_);
            _images.Add(Coder_s_space.Properties.Resources.banner_for_Coder_s_space__2_);

            // Set the initial image in the picture box
            guna2PictureBox1.Image = _images[_currentIndex];

            // Set the timer properties
            _timer.Interval = 4000; // 5 seconds
            _timer.Tick += timer_Tick;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            // Increment the index and reset to 0 when the last image has been displayed
            _currentIndex = (_currentIndex + 1) % _images.Count;

            // Set the next image in the list
            guna2PictureBox1.Image = _images[_currentIndex];
        }
        async void InitWebView()
        {
            await webView2k.EnsureCoreWebView2Async(null);
            webView2k.CoreWebView2.Navigate("https://www.tutorialspoint.com/compile_csharp_online.php");

        }

        private async void FormProblems_Load(object sender, EventArgs e)
        {
            // Start the timer when the form is loaded
            _timer.Start();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void guna2ImageButton10_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void guna2ImageButton16_Click(object sender, EventArgs e)
        {
        }

        private async void guna2ImageButton18_Click(object sender, EventArgs e)
        {
             NavigateToWeb("https://www.hackerrank.com/");
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        public async void NavigateToWeb(string url)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Padding = new Padding(0);
            flowLayoutPanel1.Controls.Add(webView2k);
            webView2k.BackColor=Color.White;
            webView2k.Size = new System.Drawing.Size(1366, 768);
            webView2k.CoreWebView2.Navigate("https://www.tutorialspoint.com/compile_csharp_online.php");
        }
    }
}
