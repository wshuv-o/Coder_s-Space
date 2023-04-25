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
            FlowLayoutPanel[] flowPanels = { flowLayoutPanel3,flowLayoutPanel4, flowLayoutPanel5, flowLayoutPanel6, flowLayoutPanel7, flowLayoutPanel8 };
            foreach (FlowLayoutPanel flowPanel in flowPanels)
            {
                foreach (Guna2CustomGradientPanel pnl in flowPanel.Controls.OfType<Guna2CustomGradientPanel>())
                {
                    Guna2ImageButton button = pnl.Controls.OfType<Guna2ImageButton>().FirstOrDefault();
                    if (button != null)
                    {
                        button.Click += ButtonAdder;
                    }
                }
            }



        }



        private List<Guna2ImageButton> addedButtons = new List<Guna2ImageButton>();

        private void ButtonAdder(object sender, EventArgs e)
        {
            Guna2ImageButton clickedButton = (Guna2ImageButton)sender;

            // Check if the button has already been added
            if (!addedButtons.Contains(clickedButton))
            {
                // Create a new button and add it to the list of added buttons
                Guna2ImageButton newButton = new Guna2ImageButton();
                newButton.Height = clickedButton.Height;
                newButton.Width = flowLayoutPanel2.Width - 30;
                newButton.Image = clickedButton.Image;
                newButton.HoverState.ImageSize = new System.Drawing.Size(220, 125);
                newButton.ImageSize = clickedButton.ImageSize;
                addedButtons.Add(clickedButton);

                // Add the new button to the FlowLayoutPanel
                flowLayoutPanel2.Controls.Add(newButton);
            }
            else
            {
                MessageBox.Show("This course has Already been Owned");
            }
        }



    }
}
