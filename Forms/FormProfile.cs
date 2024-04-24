using media;
using media.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coder_s_space
{
    public partial class FormProfile : Form
    {
        User user;

        // Define calendar layout constants
        private const int NumColumns = 56;
        private const int NumRows = 7;
        private const int BoxWidth = 10;
        private const int BoxHeight = 10;
        private const int BoxMargin = 5;

        // Define a dictionary to store contributions for each date
        Dictionary<DateTime, int> contributions = new Dictionary<DateTime, int>();

        public FormProfile(User user)
        {
            DBImage dbi = new DBImage();
            this.user = user;
            InitializeComponent();
            Image profileImage = dbi.LoadImageFromDataBase(user.Key);

            this.BackColor = Color.Magenta;
            this.TransparencyKey = Color.Magenta;
            this.FormBorderStyle = FormBorderStyle.None;

            labelUserName.Text = user.UserName;
            if (profileImage != null)
            {
                guna2CirclePictureBox1.Image = profileImage;

                Color color1 = FunctionsAll.GetBackgroundAverageColor((Bitmap)profileImage);
                Color color2 = FunctionsAll.GetClothColor((Bitmap)profileImage);
                LinearGradientBrush brush = new LinearGradientBrush(new Point(0, 0), new Point(panel1.Width, panel1.Height), color1, color2);
                panel1.Paint += (s, e) => e.Graphics.FillRectangle(brush, e.ClipRectangle);

                FunctionsAll.RoundPanel(panel1, 30);
            }
            else
            {
                FunctionsAll.RoundPanel(panel1, 30);
            }

            InitializeCalendar();
            UpdateContributions(new DateTime(2023, 4, 5), 1);
            UpdateContributions(new DateTime(2023, 4, 6), 3);
            UpdateContributions(new DateTime(2023, 4, 7), 5);
            UpdateContributions(new DateTime(2023, 4, 8), 8);

            UpdateContributions(new DateTime(2023, 6, 5), 3);
            UpdateContributions(new DateTime(2024, 2, 1), 7);
            UpdateContributions(new DateTime(2023, 7, 2), 5);


            Random random = new Random();
            DateTime startDate = new DateTime(2023, 5, 1);
            DateTime endDate = new DateTime(2024, 4, 24);
            int daysInRange = (int)(endDate - startDate).TotalDays;

            for (int i = 0; i < 300; i++)
            {
                // Generate a random date within the range
                DateTime randomDate = startDate.AddDays(random.Next(daysInRange));

                // Generate a random contribution count (between 1 and 10 for example)
                int randomCount = random.Next(1, 11); // Generates a random integer between 1 and 10

                // Update contributions for the random date with the random count
                UpdateContributions(randomDate, randomCount);
            }


        }

        // Function to initialize the calendar
        private void InitializeCalendar()
        {
            // Starting date for the calendar
            DateTime startDate = new DateTime(2023, 4, 1);

            // Calculate total width and height of the calendar
            int totalWidth = NumColumns * (BoxWidth + BoxMargin) + BoxMargin;
            int totalHeight = NumRows * (BoxHeight + BoxMargin) + BoxMargin;

            // Set size of guna2ShadowPanel1 to fit the calendar
            guna2ShadowPanel1.Size = new Size(totalWidth, totalHeight);

            // Loop to create day boxes
            for (int col = 0; col < NumColumns; col++)
            {
                for (int row = 0; row < NumRows; row++)
                {
                    // Calculate position of the box
                    int x = col * (BoxWidth + BoxMargin) + BoxMargin;
                    int y = row * (BoxHeight + BoxMargin) + BoxMargin;

                    // Create and customize the day box
                    Guna.UI2.WinForms.Guna2Button dayBox = new Guna.UI2.WinForms.Guna2Button();
                    dayBox.Size = new Size(BoxWidth, BoxHeight);
                    dayBox.Location = new Point(x, y);
                    dayBox.BorderRadius = 2;
                    dayBox.FillColor = Color.Gray;
                   // dayBox.BackColor = Color.Gray; // Default color

                    // Add the date to the box
                    dayBox.Tag = startDate.AddDays(col * NumRows + row);

                    // Add tooltip to show date on hover
                    ToolTip toolTip = new ToolTip();
                    toolTip.SetToolTip(dayBox, ((DateTime)dayBox.Tag).ToString("dd/MM/yyyy"));

                    // Add event handler for click event if needed

                    // Add the day box to guna2ShadowPanel1
                    guna2ShadowPanel1.Controls.Add(dayBox);
                }
            }
        }

        // Function to update contributions and color the day box
        // Function to update contributions and color the day box
        private void UpdateContributions(DateTime date, int count)
        {
            // Check if the date already exists in contributions dictionary
            if (contributions.ContainsKey(date))
            {
                // Update contributions count
                contributions[date] += count;
            }
            else
            {
                // Add new date to contributions dictionary
                contributions.Add(date, count);
            }

            // Get the corresponding day box for the given date
            Guna.UI2.WinForms.Guna2Button dayBox = guna2ShadowPanel1.Controls.OfType<Guna.UI2.WinForms.Guna2Button>().FirstOrDefault(b => (DateTime)b.Tag == date);

            // Change color of the day box based on contributions count
            if (dayBox != null)
            {
                int contributionCount = contributions[date];
                if (contributionCount >= 7)
                {
                    dayBox.FillColor = Color.FromArgb(57, 211, 83); // Bright Green
                }
                else if (contributionCount >= 5)
                {
                    dayBox.FillColor = Color.FromArgb(38, 166, 65); // Light Green
                }
                else if (contributionCount >= 3)
                {
                    dayBox.FillColor = Color.FromArgb(0, 109, 50); // Green
                }
                else if (contributionCount >= 1)
                {
                    dayBox.FillColor = Color.FromArgb(14, 68, 41); // Dark Green
                }
                else
                {
                    dayBox.FillColor = Color.Gray; // Default color
                }
            }
        }



        public string UserName
        {
            get { return labelUserName.Text; }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UpdateContributions(new DateTime(2023, 4, 5), 1);

        }
    }
}
