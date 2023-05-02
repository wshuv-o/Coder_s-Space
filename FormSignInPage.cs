using System;
using MySql.Data.MySqlClient;
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
using media.Classes;
using media;

namespace Coder_s_space
{
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
            //OpenChildForm(this.panel1, 20);
            //RoundPanelCorners(ref panel1, 30);
            RoundTextBoxCorners(ref textBoxEmail, 13);
            RoundTextBoxCorners(ref textBoxEmail, 13);
            RoundTextBoxCorners(ref textBoxPass, 13);
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
            FormRegistrationNew f = new FormRegistrationNew();
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
            string email = textBoxEmail.Text;
            /* this.Hide();
             Form1 f = new Form1();
             f.ShowDialog();
             this.Close();*/
            if (email=="admin"&&textBoxPass.Text=="admin")
            { 
                this.Hide();
                FormCRUD cRUD= new FormCRUD();
                cRUD.ShowDialog();
                this.Close();
                
            }
            else
            {
                
                string connString = "server=localhost;user=root;database=csdb;port=3306;password=";
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        conn.Open();
                        string query = "SELECT user_pass FROM user WHERE user_email= @Email";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Email", email);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string password = reader.GetString(0);
                                    if (password.Equals(textBoxPass.Text))
                                    {

                                        this.Hide();
                                        User user = this.GetUserByEmail(email);
                                        //MessageBox.Show("userFound!"+"user name is"+user.UserFirstName);
                                        FormPortfoilo f = new FormPortfoilo(user);
                                        //MessageBox.Show(user.Email+"-"+user.UserName+"kkk"+user.Password);
                                        f.ShowDialog();
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("password not matched");
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("User not found, or maybe died");
                                    return;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        public User GetUserByEmail(string email)
        {
            DBImage dbio = new DBImage();
            User user = new User();
            try
            {
                
                string connectionString;
                connectionString = "server=localhost;user=root;database=csdb;port=3306;password=";



                string query = "SELECT * FROM user WHERE user_email = @Email";
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@Email", email);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    user.Key = reader.GetInt32("user_id");

                    //user.UserFirstName = reader.GetString("userfirstname");
                   // user.UserLastName = reader.GetString("userlastname");
                   // user.Dob = reader.GetDateTime("dob");
                    user.Email = reader.GetString("user_email");
                    user.UserName = reader.GetString("user_name");
                    user.ProfilePhoto = dbio.LoadImageFromDataBase(reader.GetInt32("user_id"));
                    //user.Gender = reader.GetString("gender");
                    //user.Bio = reader.GetString("bio");
                    //MessageBox.Show(" " + user.Key);

                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            return user;
        }  
    }
}
