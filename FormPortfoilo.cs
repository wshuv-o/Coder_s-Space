using Guna.UI2.WinForms;
using media.Classes;
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

        User user;
        public FormPortfoilo(User user)
        {
            InitializeComponent();
            this.user = user;
            Image pp = user.ProfilePhoto;
            profilePictureBox2.Image = pp;

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
            // Get the parent form of the sender control
            Control parentForm = ((Control)sender).Parent;

            // Get the name of the parent form
            string formName = parentForm.Name;
            if (formName == "UC_ProjectDetails")
            {
                // Get the parent control of the sender button
                Control parent = ((Control)sender).Parent;

                // Cast the parent control to a projDetails user control
                UC_ProjectDetails projDetails = parent as UC_ProjectDetails;

                if (projDetails != null)
                {
                    //FormProfile formP = new FormProfile(user);
                    string userName = user.UserName; // get the username from FormProfile
                    //Image userImage = formP.pictureBox3.Image;

                    UC_ProjectAdded projAdd = new UC_ProjectAdded(projDetails.textBoxTitle.Text, projDetails.textBoxDesc.Text, projDetails.textBoxTools.Text, projDetails.imageLocation);
                    flowLayoutPanel4.Controls.Add(projAdd);
                    projAdd.BringToFront();
                    projDetails.Dispose();
                }

            }

            else
            {
                // Get the parent control of the sender button
                Control parent = ((Control)sender).Parent;

                // Cast the parent control to a projDetails user control
                UC_SkillDetails skillDetails = parent as UC_SkillDetails;


                //DateTime clickTime = DateTime.Now;
                if (skillDetails != null)
                {
                   Guna2Button guna2SkillButton= new Guna2Button();
                   guna2SkillButton.Animated = true;
                   guna2SkillButton.BorderRadius = 15;
                   guna2SkillButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                   guna2SkillButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                   guna2SkillButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                   guna2SkillButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                   guna2SkillButton.FillColor = System.Drawing.Color.Transparent;
                   guna2SkillButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
                   guna2SkillButton.ForeColor = System.Drawing.Color.White;
                   guna2SkillButton.HoverState.BorderColor = System.Drawing.Color.Transparent;
                   guna2SkillButton.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
                   guna2SkillButton.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
                   guna2SkillButton.Image = global::Coder_s_space.Properties.Resources.stop;
                   guna2SkillButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
                   guna2SkillButton.ImageOffset = new System.Drawing.Point(-2, 0);
                   guna2SkillButton.ImageSize = new System.Drawing.Size(25, 25);
                   guna2SkillButton.Location = new System.Drawing.Point(103, 13);
                   guna2SkillButton.Name = "guna2SkillButton";
                   guna2SkillButton.Size = new System.Drawing.Size(171, 49);
                   guna2SkillButton.TabIndex = 31;
                   guna2SkillButton.TabStop = false;
                   guna2SkillButton.Text = skillDetails.textBoxSkill.Text;
                   guna2SkillButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;



                    flowLayoutPanel3.Controls.Add(guna2SkillButton);
                    guna2SkillButton.BringToFront();
                    skillDetails.Dispose();
                }

            }
            
            
        }

        private void guna2ImageButton7_Click(object sender, EventArgs e)
        {
            int skillPanelSizer=(flowLayoutPanel3.Controls.Count)/6;
            
            if ((flowLayoutPanel3.Controls.Count)%6== 0 && skillPanelSizer >= 3)
            {
                panel6.Size = new Size(panel6.Size.Width,panel6.Size.Height +52);
            }
            UC_SkillDetails uc1 = new UC_SkillDetails();
            uc1.Location = new Point(
                (this.ClientSize.Width - uc1.Width) / 2,
                (this.ClientSize.Height - uc1.Height - 300) / 2
            );
            this.Controls.Add(uc1);
            uc1.BringToFront();
            uc1.guna2Button4.Click += OnPostClicked;

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profilePictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
