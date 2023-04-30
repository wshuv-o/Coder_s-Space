using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        private void timer_Tick(object sender, EventArgs e)
        {
            _currentIndex = (_currentIndex + 1) % _images.Count;
            guna2PictureBox1.Image = _images[_currentIndex];

            // Start a fade-in effect
            int fadeSteps = 30; // Number of steps in the fade effect
            double fadeStepTime = 6; // Time (in ms) between fade steps
            double fadeStepOpacity = 2.0 / fadeSteps; // Opacity change per step
            double currentOpacity = 0.0;
            _timer.Stop(); // Stop the timer temporarily to avoid overlapping ticks
            for (int i = 0; i < fadeSteps; i++)
            {
                currentOpacity += fadeStepOpacity;
                guna2PictureBox1.Image = _images[_currentIndex];
                guna2PictureBox1.Image = ChangeOpacity(guna2PictureBox1.Image, currentOpacity);
                guna2PictureBox1.Refresh();
                Application.DoEvents();
                System.Threading.Thread.Sleep((int)fadeStepTime);
            }
            _timer.Start();
        }

        private Image ChangeOpacity(Image image, double opacity)
        {
            // Create a new Bitmap object with the same dimensions as the original image
            Bitmap bmp = new Bitmap(image.Width, image.Height);

            // Draw the original image onto the new Bitmap object with the specified opacity
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = (float)opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }

            // Return the new image
            return bmp;
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
