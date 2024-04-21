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
    public partial class FormTest : Form
    {
        private User user;
        public FormTest(User user)
        {
            InitializeComponent();
            this.user = user;
            labelDesc.Text = user.UserName;
            guna2CirclePictureBox1.Image = user.ProfilePhoto;
            pictureBox1.Image= user.ProfilePhoto;
        }

        private void labelDesc_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
