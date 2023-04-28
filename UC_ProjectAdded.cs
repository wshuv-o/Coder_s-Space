using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Coder_s_space
{
    public partial class UC_ProjectAdded : UserControl
    {
        public UC_ProjectAdded(string title, string desc, string tools, Image projImage)
        {
            InitializeComponent();

            label5.Text = title;
            labelDesc.Text = desc;
            labelTools.Text = tools;
            guna2PictureBox7.Image = projImage;
        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
