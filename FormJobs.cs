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
    public partial class FormJobs : Form
    {
        public FormJobs()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }     

        private void btmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button4_Click(object sender, EventArgs e)
        {
             formContact1 fc = new formContact1();
            PanelContainer.Controls.Add(fc);
    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var fa = new formAbout();
            PanelContainer.Controls.Add(fa);  
            fa.BringToFront();
            
        }

        private void PanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String imageLocation = " ";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    image1.ImageLocation = imageLocation;

                }
            }
            catch
            {
                MessageBox.Show("An error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Completed","Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

    }
}
