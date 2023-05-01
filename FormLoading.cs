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
    public partial class FormLoading : Form
    {
        public FormLoading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Width += 3;
            if (panel3.Width >= 599)
            {
                timer1.Stop();
                FormWelcome f = new FormWelcome();
                f.Show();
                this.Hide();
            }
        }
    }
}
