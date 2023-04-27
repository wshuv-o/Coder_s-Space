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
    public partial class PostTask : UserControl
    {
        public PostTask(double price, string title, string desc, string tasker, Image taskerImage, DateTime postTime)
        {
            InitializeComponent();
            label2.Text = "$"+price;
            labelTitle.Text = title;
            labelDesc.Text = desc;
            label4.Text = tasker;
            label1.Text = postTime.ToString();
            guna2CirclePictureBox1.Image = taskerImage;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
