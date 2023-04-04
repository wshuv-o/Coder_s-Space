using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coder_s_space;
using Microsoft.Win32;


namespace Coder_s_space
{
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
            //OpenChildForm(this.panel1, 20);
            //RoundPanelCorners(ref panel1, 30);
            RoundTextBoxCorners(ref txtUsername, 13);
            RoundTextBoxCorners(ref txtUsername, 13);
            RoundTextBoxCorners(ref textBox1, 13);
            RoundButtonCorners(ref button1, 13);
            RoundButtonCorners(ref button2, 13);
        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formregistation f = new Formregistation();
            f.ShowDialog();
            this.Close();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void txtComPassword_Click(object sender, EventArgs e) { }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public Form activeForm = null;
        public void OpenChildForm(Form childForm, Panel parentPanel)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(childForm);
                parentPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            else
            {
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(childForm);
                parentPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }


        }
        public void RoundPanelCorners(ref Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(panel.ClientRectangle.Location, new Size(radius * 2, radius * 2)), 180, 90);
            path.AddLine(new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Top), new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Top));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, 0, radius * 2, radius * 2), 270, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Top + radius), new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Bottom - radius));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 0, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Bottom), new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Bottom));
            path.AddArc(new Rectangle(0, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }
        public void RoundButtonCorners(ref Button panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(panel.ClientRectangle.Location, new Size(radius * 2, radius * 2)), 180, 90);
            path.AddLine(new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Top), new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Top));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, 0, radius * 2, radius * 2), 270, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Top + radius), new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Bottom - radius));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 0, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Bottom), new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Bottom));
            path.AddArc(new Rectangle(0, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }
        public void RoundTextBoxCorners(ref TextBox panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(panel.ClientRectangle.Location, new Size(radius * 2, radius * 2)), 180, 90);
            path.AddLine(new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Top), new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Top));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, 0, radius * 2, radius * 2), 270, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Top + radius), new Point(panel.ClientRectangle.Right, panel.ClientRectangle.Bottom - radius));
            path.AddArc(new Rectangle(panel.ClientRectangle.Width - radius * 2, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 0, 90);
            path.AddLine(new Point(panel.ClientRectangle.Right - radius, panel.ClientRectangle.Bottom), new Point(panel.ClientRectangle.Left + radius, panel.ClientRectangle.Bottom));
            path.AddArc(new Rectangle(0, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Formregistation f = new Formregistation();
            f.ShowDialog();
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }
    }
}
