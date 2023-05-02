using media;
using media.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Coder_s_space
{
    public partial class FormProfileEditor : Form
    {
        User user;
        DBImage dbi=new DBImage();
        public FormProfileEditor(User user)
        {
            this.InitializeComponent();
            this.user = user;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            dbi.SaveToDataBase(user.Key, PictureBox2.Image);

            this.Hide();
            Form1 f = new Form1(user);
            f.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSignIn f = new FormSignIn();
            f.ShowDialog();
            this.Close();
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

        private void buttonGitHub_Click(object sender, EventArgs e)
        {
            PictureBox2.Image = dbi.SelectImageFromFile();
            
        }
    }
}
