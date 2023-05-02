using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using media;
using media.Classes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;


namespace Coder_s_space
{
    public partial class FormRegistrationNew : Form
    {
        
        public DBImage dbi= new DBImage();
        byte[] imageBytes=null;
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=;database=csdb");
        public FormRegistrationNew()
        {
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Female");
            comboBox1.Items.Add("Male");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtComPassword_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonGitHub_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            if (!this.textBox3.Text.Contains('@') || !this.textBox3.Text.Contains('.'))
            {
                this.textBox3.ForeColor = Color.Red;
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.textBox3.ForeColor = Color.Black;

            }
            if (textBox4.Text != textBox5.Text)
            {
                MessageBox.Show("Password doesn't match!", "Error");
                return;
            }

            else if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            else
            {
                
                
                connection.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM csdb.user WHERE user_name = @UserName", connection),
                cmd2 = new MySqlCommand("SELECT * FROM csdb.user WHERE user_email = @UserEmail", connection);


                cmd1.Parameters.AddWithValue("@UserName", txtUsername.Text);
                cmd2.Parameters.AddWithValue("@UserEmail", textBox3.Text);

                bool userExists = false, mailExists = false;

                using (var dr1 = cmd1.ExecuteReader())
                    if (userExists = dr1.HasRows)
                    {
                        //userExists= true;
                        MessageBox.Show("Username not available!");
                    }

                using (var dr2 = cmd2.ExecuteReader())
                    if (mailExists = dr2.HasRows)
                    {
                        MessageBox.Show("Email not available!");
                        //mailExists=true;
                    }


                if (!(userExists || mailExists))
                {
                    //MessageBox.Show("you are the super failure");
                    string iquery = "INSERT INTO csdb.user(`first_name`,`last_name`,`user_gender`,`user_dob`,`user_email`,`user_name`, `user_pass`)" +
                        "VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + comboBox1.Text + "', '" + dateTimePicker1.Value.Date + "', " +
                        "'" + textBox3.Text + "', '" + txtUsername.Text + "', '" + textBox4.Text + "');";
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                    commandDatabase.CommandTimeout = 60;
                    //INSERT INTO `user` (`user_id`, `user_name`, `user_pass`, `user_email`, `user_photo`, `first_name`, `last_name`, `user_gender`, `user_dob`) VALUES(NULL, 'a', '1', 'a', 'b', 'Imtiaj', 'Sajin', 'Male', '2023-05-04');
                    try
                    {
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        MessageBox.Show("Account Successfully Created!");

                        this.Hide();
                        FormSignIn f = new FormSignIn();
                        f.ShowDialog();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                    }

                    
                }

                connection.Close();
            }

        }

        private void label5_Click_2(object sender, EventArgs e)
        {

            this.Hide();
            FormSignIn f = new FormSignIn();
            f.ShowDialog();
            this.Close();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            txtUsername.Text = "";
        }
    }
}
