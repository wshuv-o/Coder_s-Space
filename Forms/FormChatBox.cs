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
    public partial class FormChatBox : Form
    {
        public FormChatBox()
        {
            InitializeComponent();
            //FunctionsAll.RoundPanel(guna2CustomGradientPanel1, 40);
            FunctionsAll.RoundPanel(guna2CustomGradientPanel2, 40);
            //FunctionsAll.RoundRichTextBox(richTextBox1, 30);
            AdjustPanelHeight(richTextBox1, guna2CustomGradientPanel2);
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AdjustPanelHeight(Guna2TextBox textBox, Guna2CustomGradientPanel panel)
        {
            int lineHeight = TextRenderer.MeasureText("A", textBox.Font).Height; // get the height of one line of text
            int maxLines = 5; // set the maximum number of lines allowed

            // calculate the new height of the panel based on the number of lines in the textbox
            int newHeight = Math.Min(maxLines, textBox.Lines.Length) * lineHeight + panel.Padding.Top + panel.Padding.Bottom;

            // update the panel height
            //panel.Height = newHeight;
            if(lineHeight>panel.Height)
            {
                panel.Height = lineHeight;
            }
        }


    }
}
