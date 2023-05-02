using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using media.Classes;
using MySql.Data.MySqlClient;

namespace Coder_s_space
{
    public partial class FormCRUD : Form
    {
        public FormCRUD()
        {
            InitializeComponent();
            string connection = "server=localhost;user id=root;password=;database=csdb";
            string query = "SELECT * FROM user";

            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=csdb";
            string query = "INSERT INTO `user` (`user_name`, `user_pass`, `user_email`, `first_name`, `last_name`, `user_dob`, `user_gender`) " +
                            "VALUES ('" + this.textBoxUN.Text + "','" + this.textBoxPass.Text + "','" + this.textBoxMail.Text + "','" +
                            this.textBoxFN.Text + "','" + this.textBoxLN.Text + "','" + this.dateTimePickerDob.Value.ToString("yyyy-MM-dd") + "','" +
                            this.textBoxGender.Text + "')";

            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();

            MessageBox.Show("Successfully Created");
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            string connection = "server=localhost;user id=root;password=;database=csdb";
            string query = "DELETE FROM user WHERE user_id='" + this.textBox8.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();

            MessageBox.Show("Successfully deleted");
            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=csdb";
            string query = "UPDATE `user` SET `user_pass`='" + this.textBoxPass.Text + "', `user_email`='" + this.textBoxMail.Text + "', `first_name`='" + this.textBoxFN.Text + "', `last_name`='" + this.textBoxLN.Text + "', `user_dob`='" + this.dateTimePickerDob.Value.ToString("yyyy-MM-dd") + "', `user_gender`='" + this.textBoxGender.Text + "' WHERE `user_name`='" + this.textBoxUN.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();

            MessageBox.Show("Successfully updated");
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxGender.Text = " ";
            textBoxLN.Text = " ";
            textBoxMail.Text = " ";
            textBoxPass.Text = " ";
            textBoxUN.Text = " ";
            //dateTimePickerDob.Text = " ";
            textBoxFN.Text = " ";
            textBox8.Text = " ";

        }

        private void button9_Click(object sender, EventArgs e)
        {

            string searchQuery = textBox8.Text;


            string connection = "server=localhost;user id=root;password=;database=csdb";
            string query = "SELECT * FROM user WHERE user_email LIKE '%" + this.textBoxMail.Text + "%'";

            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);

            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);

            MessageBox.Show("Successfully Searched");
            conn.Close();
            dataGridView1.DataSource = dt;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=csdb";
            string query = "SELECT * FROM user";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
