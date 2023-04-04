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
        public FormProfile()
        {
            InitializeComponent();

            this.BackColor = Color.Magenta;
            this.TransparencyKey = Color.Magenta;
            this.FormBorderStyle = FormBorderStyle.None;

            //FunctionsAll.RoundPanel(panel6, 50);

            Color color1 = FunctionsAll.GetBackgroundAverageColor((Bitmap)pictureBox3.Image);
            Color color2 = FunctionsAll.GetClothColor((Bitmap)pictureBox3.Image);
            LinearGradientBrush brush = new LinearGradientBrush(new Point(0, 0), new Point(panel6.Width, panel6.Height), color1, color2);
            panel6.Paint += (s, e) => e.Graphics.FillRectangle(brush, e.ClipRectangle);
            panel6.SendToBack();

            
            FunctionsAll.RoundPanel(panel6, 30);
            FunctionsAll.RoundPictureBox(pictureBox3, 170);
            //pictureBox3.Image=FunctionsAll.GetCircularImage(pictureBox3.Image); 

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
