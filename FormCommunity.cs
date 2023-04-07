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
    public partial class FormCommunity : Form
    {
        Form activeForm = null;

        public FormCommunity()
        {
            InitializeComponent();
            FunctionsAll.RoundPanel(tableLayoutPanel1, 40);
            FunctionsAll.RoundPanel(tableLayoutPanel2, 40);
            FunctionsAll.RoundPanel(panel7, 40);
            FunctionsAll.RoundPanel(tableLayoutPanel3, 40);
            FunctionsAll.RoundPanel(panel8, 40);
            FunctionsAll.RoundPanel(guna2Panel5, 40);
           // guna2GradientButton2.TextImageRelation = TextImageRelation.ImageBeforeText; // or other desired alignment
            FormProfile form3 = new FormProfile();
            guna2CirclePictureBox1.Image = form3.pictureBox3.Image;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chatBoxLabel_Click(object sender, EventArgs e)
        {
            chatBoxLabel.ForeColor = Color.FromArgb(250, 250, 250);

            OpenChildForm(new FormChatBox(), panel8);
        }

        public void OpenChildForm(Form childForm, Panel parentPanel)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(childForm);
                parentPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                // childForm.Size = parentPanel.Size;
            }
            else
            {
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(childForm);
                parentPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                // childForm.Size = parentPanel.Size;

            }
        }
        private void chatBoxLabel_MouseEnter(object sender, EventArgs e)
        {
            chatBoxLabel.ForeColor = Color.FromArgb(250, 250, 250);
        }

        private void chatBoxLabel_MouseLeave(object sender, EventArgs e)
        {
            chatBoxLabel.ForeColor = Color.FromArgb(155, 155, 155);
        }


        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ShowDialog();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.ForeColor = Color.FromArgb(155, 155, 155);

        }
        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor =  Color.FromArgb(250,250,250);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.FromArgb(155, 155, 155);
        }

        private void voteLabel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormVote(), panel8);
        }
        private void voteLabel_MouseEnter(object sender, EventArgs e)
        {
            voteLabel.ForeColor = Color.FromArgb(250, 250, 250);
        }

        private void voteLabel_MouseLeave(object sender, EventArgs e)
        {
            voteLabel.ForeColor = Color.FromArgb(155, 155, 155);
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            ////

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
