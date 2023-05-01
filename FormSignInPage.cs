using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coder_s_space;
using Microsoft.Win32;
using MySql.Data.MySqlClient;


namespace Coder_s_space
{
    public partial class FormSignIn : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;
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
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }

            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM loginregister.userinfo WHERE Username = '" + txtUsername.Text + "' AND Password = '" + textBox1.Text + "';";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                    string Query = "update loginregister.userinfo set LastLogin='" + dateTimePicker1.Value + "' where Username='" + this.txtUsername.Text + "';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();

                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    FormCRUD frm2 = new FormCRUD();
                    frm2.ShowDialog();

                }
                else
                {

                    MessageBox.Show("Incorrect Login Information! Try again.");
                }

                connection.Close();
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkboxShowPass_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox1.PasswordChar = textBox1.PasswordChar == '\0' ? '*' : '\0';

            checkboxShowPass.Text = textBox1.PasswordChar == '\0' ? "Hide" : "Show";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            txtUsername.Text = "";
        }
    }
}
