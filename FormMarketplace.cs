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
        
        public FormMarketplace()
        {
            InitializeComponent();
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
            TaskDetails taskDetails = new TaskDetails();
            taskDetails.Location = new Point(
                (this.ClientSize.Width - taskDetails.Width) / 2,
                (this.ClientSize.Height - taskDetails.Height-300) / 2
            );
            this.Controls.Add(taskDetails);
            taskDetails.BringToFront();
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
    }
}
