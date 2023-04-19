using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Coder_s_space
{
    public partial class FormProblems : Form
    {
        private List<Image> _images = new List<Image>(); // List of images to display
        private int _currentIndex = 0; // Index of the current image being displayed
        private Timer _timer = new Timer(); // Timer to move the picture

        public FormProblems()
        {
            InitializeComponent();
            
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

        private void FormCloud_Load(object sender, EventArgs e)
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
    }
}
