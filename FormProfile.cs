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
        public FormProfile(User user)
        {
            DBImage dbi=new DBImage();
            InitializeComponent();
            Image profileImage = dbi.LoadImageFromDataBase(user.Key);

            this.BackColor = Color.Magenta;
            this.TransparencyKey = Color.Magenta;
            this.FormBorderStyle = FormBorderStyle.None;
            
            labelUserName.Text = user.UserName;
            if (profileImage != null)
            {
                guna2CirclePictureBox1.Image = profileImage;
                //FunctionsAll.RoundPanel(panel6, 50);

                Color color1 = FunctionsAll.GetBackgroundAverageColor((Bitmap)profileImage);
                Color color2 = FunctionsAll.GetClothColor((Bitmap)profileImage);
                LinearGradientBrush brush = new LinearGradientBrush(new Point(0, 0), new Point(panel1.Width, panel1.Height), color1, color2);
                panel1.Paint += (s, e) => e.Graphics.FillRectangle(brush, e.ClipRectangle);
                //panel6.SendToBack();

                FunctionsAll.RoundPanel(panel1, 30);
            }
            //FunctionsAll.RoundPictureBox(pictureBox3, 170);
            else
            {

                FunctionsAll.RoundPanel(panel1, 30);

            }
            
            //pictureBox3.Visible = false;
            //pictureBox3.Image=FunctionsAll.GetCircularImage(pictureBox3.Image); 


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
    }
}
