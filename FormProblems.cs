using Guna.UI2.WinForms;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using System.Drawing.Drawing2D;

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
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            InitWebView();
            _images.Add(Coder_s_space.Properties.Resources.banner_for_Coder_s_space);
            _images.Add(Coder_s_space.Properties.Resources.banner_for_Coder_s_space__4_);
            _images.Add(Coder_s_space.Properties.Resources.banner_for_Coder_s_space__1_);
            _images.Add(Coder_s_space.Properties.Resources.banner_for_Coder_s_space__2_);


            // Set the initial image in the picture box
            guna2PictureBox1.Image = _images[_currentIndex];

            // Set the timer properties
            _timer.Interval = 4000; // 4 seconds
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
            _timer.Start();
        }

       /* private async void FormProblems_Load(object sender, EventArgs e)
        {
            // Start the timer when the form is loaded
            _timer.Start();
        }*/

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://dmoj.ca/");

        }

        private async void guna2ImageButton16_Click(object sender, EventArgs e)
        {
            NavigateToWeb(" https://codeforces.com/");

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
            flowLayoutPanel1.Padding=new Padding(0,0,0,0);
            flowLayoutPanel1.Controls.Add(webView2k);
            flowLayoutPanel1.AutoScroll = false;
            webView2k.BackColor=Color.White;
            webView2k.Size = new System.Drawing.Size(1360, 710);
            FunctionsAll.RoundWebView(webView2k, 30);
            webView2k.CoreWebView2.Navigate(url);
        }
       
        private void label18_Click(object sender, EventArgs e)
        {
            NavigateToWeb(" https://codeforces.com/");

        }

        private void guna2ImageButton17_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://leetcode.com/");
        }

        private void label19_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://leetcode.com/");

        }

        private void guna2ImageButton19_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://www.hackerearth.com/");

        }

        private void label21_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://www.hackerearth.com/");

        }

        private void guna2ImageButton20_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://www.spoj.com/");

        }

        private void label22_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://www.spoj.com/");

        }

        private void guna2ImageButton21_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://open.kattis.com/");

        }

        private void label23_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://open.kattis.com/");

        }

        private void guna2ImageButton22_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://coderbyte.com/");

        }

        private void label24_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://coderbyte.com/");

        }

        private void guna2ImageButton23_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://www.codechef.com/");

        }

        private void label25_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://www.codechef.com/");

        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            NavigateToWeb("https://www.geeksforgeeks.org/");

        }

        private void label2_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://www.geeksforgeeks.org/");

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://www.e-olymp.com/");

        }

        private void label3_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://www.e-olymp.com/");

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://dmoj.ca/");

        }

        private void guna2ImageButton25_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://lightoj.com/");

        }

        private void label27_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://lightoj.com/");

        }

        private void label20_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://www.hackerrank.com/");

        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://icpc.global/");

        }

        private void guna2ImageButton28_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://codingcompetitions.withgoogle.com/codejam");
        }

        private void label30_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://codingcompetitions.withgoogle.com/codejam");

        }

        private void guna2ImageButton27_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://www.facebook.com/codingcompetitions/hacker-cup/");

        }

        private void label29_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://www.facebook.com/codingcompetitions/hacker-cup/");

        }

        private void label5_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://icpc.global/");

        }

        private void guna2ImageButton29_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://ioinformatics.org/");

        }

        private void label31_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://ioinformatics.org/");

        }

        private void guna2ImageButton26_Click(object sender, EventArgs e)
        {
            NavigateToWeb(" https://tco23.topcoder.com/");

        }

        private void label28_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://tco23.topcoder.com/");

        }

        private void guna2ImageButton31_Click(object sender, EventArgs e)
        {
            NavigateToWeb(" https://imaginecup.microsoft.com/en-us");

        }

        private void guna2ImageButton30_Click(object sender, EventArgs e)
        {
            NavigateToWeb("  https://codingcompetitions.withgoogle.com/hashcode");

        }

        private void label33_Click(object sender, EventArgs e)
        {
            NavigateToWeb(" https://imaginecup.microsoft.com/en-us");

        }

        private void label32_Click(object sender, EventArgs e)
        {
            NavigateToWeb("  https://codingcompetitions.withgoogle.com/hashcode");

        }

        private void guna2ImageButton32_Click(object sender, EventArgs e)
        {
            NavigateToWeb(" https://ieeextreme.org/");

        }

        private void label38_Click(object sender, EventArgs e)
        {
            NavigateToWeb(" https://itch.io/jams");

        }

        private void label35_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://www.icfpconference.org/");
        }

        private void label34_Click(object sender, EventArgs e)
        {
            NavigateToWeb(" https://ieeextreme.org/"); ;

        }

        private void guna2ImageButton34_Click(object sender, EventArgs e)
        {
            NavigateToWeb(" https://atcoder.jp/");

        }

        private void label36_Click(object sender, EventArgs e)
        {
            NavigateToWeb(" https://atcoder.jp/");

        }

        private void guna2ImageButton35_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://www.codewars.com/");

        }

        private void label37_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://www.codewars.com/");

        }

        private void guna2ImageButton36_Click(object sender, EventArgs e)
        {
            NavigateToWeb(" https://itch.io/jams");

        }

        private void guna2ImageButton33_Click(object sender, EventArgs e)
        {
            NavigateToWeb("https://www.icfpconference.org/");

        }
    }
}
