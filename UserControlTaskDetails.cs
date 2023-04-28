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
    public partial class UserControlTaskDetails : UserControl
    {
        public UserControlTaskDetails()
        {
            InitializeComponent();
            FunctionsAll.RoundUserControl(this, 25);
        }

        public double TaskPrice
        {
            get
            {
                double result;
                if (double.TryParse(textBoxPrice.Text, out result))
                {
                    return result;
                }
                else
                {
                    // Handle invalid input here
                    return 0.0;
                }
            }
        }

        public string TaskDescription
        {
            get { return textBoxDesc.Text; }
        }
        public string TaskTitle
        {
            get { return textBoxTitle.Text;} 
        }


        public void guna2Button4_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
