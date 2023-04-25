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
    public partial class FormCourses : Form
    {
        private List<Image> _images = new List<Image>(); // List of images to display
        private int _currentIndex = 0; // Index of the current image being displayed
        private Timer _timer = new Timer(); // Timer to move the picture
        public FormCourses()
        {
            InitializeComponent();
            _images.Add(Coder_s_space.Properties.Resources.csi1);
            _images.Add(Coder_s_space.Properties.Resources.csi2);
            _images.Add(Coder_s_space.Properties.Resources.csi3);
            _images.Add(Coder_s_space.Properties.Resources.csi4);
            // Set the initial image in the picture box
            guna2PictureBox1.Image = _images[_currentIndex];

            // Set the timer properties
            _timer.Interval = 2000; // 4 seconds
            _timer.Tick += timer_Tick;
            _timer.Start();

            FlowLayoutPanel[] flowPanels = { flowLayoutPanel3,flowLayoutPanel4, flowLayoutPanel5, flowLayoutPanel6, flowLayoutPanel7, flowLayoutPanel8 };
            foreach (FlowLayoutPanel flowPanel in flowPanels)
            {
                foreach (Guna2CustomGradientPanel pnl in flowPanel.Controls.OfType<Guna2CustomGradientPanel>())
                {
                    Guna2ImageButton button = pnl.Controls.OfType<Guna2ImageButton>().FirstOrDefault();
                    if (button != null)
                    {
                        button.Click += ButtonAdder;
                    }
                }
            }



        }
        void timer_Tick(object sender, EventArgs e)
        {
            // Increment the index and reset to 0 when the last image has been displayed
            _currentIndex = (_currentIndex + 1) % _images.Count;

            // Set the next image in the list
            guna2PictureBox1.Image = _images[_currentIndex];
        }



        private List<Guna2ImageButton> addedButtons = new List<Guna2ImageButton>();

        private void ButtonAdder(object sender, EventArgs e)
        {
            Guna2ImageButton clickedButton = (Guna2ImageButton)sender;

            // Check if the button has already been added
            if (!addedButtons.Contains(clickedButton))
            {
                // Create a new button and add it to the list of added buttons
                Guna2ImageButton newButton = new Guna2ImageButton();
                newButton.Height = clickedButton.Height;
                newButton.Width = flowLayoutPanel2.Width - 30;
                newButton.Image = clickedButton.Image;
                newButton.HoverState.ImageSize = new System.Drawing.Size(220, 125);
                newButton.ImageSize = clickedButton.ImageSize;
                addedButtons.Add(clickedButton);

                // Add the new button to the FlowLayoutPanel
                flowLayoutPanel2.Controls.Add(newButton);
            }
            else
            {
                MessageBox.Show("This course has Already been Owned");
            }
        }



    }
}
