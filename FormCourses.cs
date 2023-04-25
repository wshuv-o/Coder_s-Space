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
    public partial class FormCourses : Form
    {
        public FormCourses()
        {
            InitializeComponent();
        }

        private void guna2ImageButton31_Click(object sender, EventArgs e)
        {
            ButtonAdder(sender);
        }
        private void guna2ImageButton29_Click(object sender, EventArgs e)
        {
            ButtonAdder(sender);
        }

        private void guna2ImageButton9_Click(object sender, EventArgs e)
        {
            ButtonAdder(sender);
        }
        private void FormCourses_Load(object sender, EventArgs e)
        {
            MessageBox.Show("gg.");
            foreach (Guna2ImageButton btn in this.Controls.OfType<Guna2ImageButton>())
            {
                btn.ImageRotate = 90;
                //btn.Click += new System.EventHandler(this.ButtonAdder);
            }
        }

        private void ButtonAdder(object sender)
        {
            //MessageBox.Show("gg.");
            
            Guna2ImageButton newButton = new Guna2ImageButton();

            // Set the properties of the new button based on the clicked button
            Guna2ImageButton clickedButton = (Guna2ImageButton)sender;
            newButton.Height = clickedButton.Height;
            newButton.Width = flowLayoutPanel2.Width - 15;
            newButton.Image = clickedButton.Image;
            newButton.ImageSize = clickedButton.ImageSize;

            // Add the new button to the FlowLayoutPanel
            flowLayoutPanel2.Controls.Add(newButton);
        }


    }
}
