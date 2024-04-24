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
        }

       
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
                    Button dayBox = new Button();
                    dayBox.Size = new Size(BoxWidth, BoxHeight);
                    dayBox.Location = new Point(x, y);
                    dayBox.FlatStyle = FlatStyle.Flat;
                    dayBox.FlatAppearance.BorderSize = 0;
                    dayBox.BackColor = Color.White; // Default color
                                                    // Add event handler for click event if needed

                    // Add the date to the box
                    dayBox.Tag = startDate.AddDays(col * NumRows + row);

                    // Add tooltip to show date on hover
                    ToolTip toolTip = new ToolTip();
                    toolTip.SetToolTip(dayBox, ((DateTime)dayBox.Tag).ToString("dd/MM/yyyy"));

                    // Add the day box to guna2ShadowPanel1
                    guna2ShadowPanel1.Controls.Add(dayBox);
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
    }
}
