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
    public partial class UserControlProjectDetails : UserControl
    {
        public Image imageProj;
        public UserControlProjectDetails()
        {
            InitializeComponent();
        }

        private void guna2ImageButton7_Click(object sender, EventArgs e)
        {
            String imageLocation = " ";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                   // imageProj.ImageLocation = imageLocation;

                }
            }
            catch
            {
                MessageBox.Show("An error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
