﻿using Guna.UI2.WinForms;
using media;
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
    public partial class FormMarketplace : Form
    {
        private Guna2Button selectedButton;
        User userLocal;
        DBImage dbi = new DBImage();
        public FormMarketplace(User user)
        {
            
            InitializeComponent();
            this.userLocal = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGitHub_Click(object sender, EventArgs e)
        {
            UCTaskDetails uc1 = new UCTaskDetails();
            uc1.Location = new Point(
                (this.ClientSize.Width - uc1.Width) / 2,
                (this.ClientSize.Height - uc1.Height-300) / 2
            );
            this.Controls.Add(uc1);
            uc1.BringToFront();
            uc1.guna2Button4.Click += OnPostClicked;
           

        }


        private void OnPostClicked(object sender, EventArgs e)
        {
            // Get the parent control of the sender button
            Control parent = ((Control)sender).Parent;

            // Cast the parent control to a TaskDetails user control
            UCTaskDetails taskDetails = parent as UCTaskDetails;

            
            DateTime clickTime = DateTime.Now;
            if (taskDetails != null)
            {
                
                string userName =userLocal.UserFirstName+" "+userLocal.UserLastName;// get the username from FormProfile
                Image profileImage = dbi.LoadImageFromDataBase(userLocal.Key);

                PostTask postTask = new PostTask(taskDetails.TaskPrice,taskDetails.TaskTitle,taskDetails.TaskDescription, userName, profileImage, clickTime);
                flowLayoutPanel1.Controls.Add(postTask);
                postTask.BringToFront();
                taskDetails.Dispose();
            }
        }


        public void AddTask(UserControl childForm, FlowLayoutPanel parentPanel)
        {
                    
               /* childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;*/
                childForm.Dock = DockStyle.Top;
                parentPanel.Controls.Add(childForm);
                parentPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                
                // childForm.Size = parentPanel.Size;
                  
        }
        private void UpdateButtonColors()
        {
            // Set the background color of all buttons to their default color

            foreach (Guna2Button button in panel2.Controls.OfType<Guna2Button>())
            {
                if (button == buttonCreateTask)
                {

                }
                else
                {
                    if (button != selectedButton)
                    {
                        button.BackColor = Color.Transparent;
                        button.FillColor = Color.Transparent;
                        button.ForeColor = Color.DarkGray;
                    }
                    else
                    {
                        button.BorderRadius = 15;
                        button.FillColor = Color.FromArgb(28, 35, 51);
                        button.BackColor = Color.Transparent;
                        button.ForeColor = Color.WhiteSmoke;
                    }
                }
            }


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            selectedButton=(Guna2Button)sender;
            UpdateButtonColors();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            selectedButton=(Guna2Button)sender;
            UpdateButtonColors();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            selectedButton = (Guna2Button)sender;
            UpdateButtonColors();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
