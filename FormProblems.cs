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

            _images.Add(Coder_s_space.Properties.Resources.online_training_web_banner_design_free_vector);
            _images.Add(Coder_s_space.Properties.Resources.graphic_design_courses_hyderabad);
            _images.Add(Coder_s_space.Properties.Resources._10302556_4413474);

            // Set the initial image in the picture box
            guna2PictureBox1.Image = _images[_currentIndex];

            // Set the timer properties
            _timer.Interval = 3000; // 5 seconds
            _timer.Tick += timer_Tick;
            //_timer.Start();
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
    }
}
