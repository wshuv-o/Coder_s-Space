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
    public partial class FormPortfoilo : Form
    {
        private int projectAdderClicked = 1;
        public FormPortfoilo()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton12_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton8_Click(object sender, EventArgs e)
        {
            projectAdderClicked++;
            if(projectAdderClicked>=2)
            {
                panel7.Size = new Size(panel7.Size.Width, panel7.Size.Height + 320);
            }
            UC_ProjectDetails uc1 = new UC_ProjectDetails();
            uc1.Location = new Point(
                (this.ClientSize.Width - uc1.Width) / 2,
                (this.ClientSize.Height - uc1.Height - 300) / 2
            );
            this.Controls.Add(uc1);
            uc1.BringToFront();
            uc1.guna2Button4.Click += OnPostClicked;
        }

        private void OnPostClicked(object sender, EventArgs e)
        {
            // Get the parent control of the sender button
            Control parent = ((Control)sender).Parent;

            // Cast the parent control to a projDetails user control
            UC_ProjectDetails projDetails = parent as UC_ProjectDetails;


            //DateTime clickTime = DateTime.Now;
            if (projDetails != null)
            {
                FormProfile formP = new FormProfile();
                string userName = formP.UserName; // get the username from FormProfile
                Image userImage = formP.pictureBox3.Image;

                UC_ProjectAdded projAdd = new UC_ProjectAdded(projDetails.textBoxTitle.Text,projDetails.textBoxDesc.Text,projDetails.textBoxTools.Text,projDetails.imageLocation);
                flowLayoutPanel4.Controls.Add(projAdd);
                projAdd.BringToFront();
                projDetails.Dispose();
            }
        }
    }
}
