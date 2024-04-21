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
    public partial class FormVote : Form
    {
        public FormVote()
        {
            InitializeComponent();
            FunctionsAll.MakePictureBoxRound(pictureBox3);
        }
        void rndmfn()
        {
            pictureBox3.BringToFront();
            pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((Bottom)));
            pictureBox3.Location = new System.Drawing.Point(300, 700);
            pictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
        }

        private void FormVote_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.button;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.icons8_add_96;
        }

        private void guna2CustomGradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
