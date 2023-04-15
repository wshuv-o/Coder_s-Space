using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Coder_s_space
{
    public partial class Form1 : Form
    {
        private const int AW_HOR_POSITIVE = 0x0001;
        private const int AW_SLIDE = 0x40000;
        private const int AW_HIDE = 0x10000;
        private const int AW_VER_NEGATIVE = 0x0004;
        private const int AW_VER_POSITIVE = 0x0008;
        private const int AW_BLEND = 0x00070000;


        [DllImport("user32.dll")]
        static extern bool AnimateWindow(IntPtr hWnd, int dwTime, int dwFlags);

        Form activeForm = null;

        public Form1()
        {
            InitializeComponent();

             OpenChildForm(new FormProfile(), panel11);
            // Make the form transparent
            this.BackColor = Color.Magenta;
            this.TransparencyKey = Color.Magenta;
            this.FormBorderStyle = FormBorderStyle.None;

            FormProfile form3= new FormProfile();
            // Make the panel transparent
            panel3.BackColor = Color.Transparent;
            panel3.Parent = this;
            panel3.BackColor = Color.Transparent; // Set the background color of panel3 to transparent
            panel3.BorderStyle = BorderStyle.None; // Set the border style of panel3 to none to remove the frame
            button1.BackgroundImage = FunctionsAll.GetCircularImage(form3.pictureBox3.Image);
            
            // button1.BackgroundImage = Properties.Resources.user__2_;


            // Set the background of gradientPanel to a gradient brush
            //Color color1 = Color.FromArgb(39, 234, 227, 255);
            //Color color1 = ((Bitmap)pictureBox3.Image).GetPixel(pictureBox3.Image.Width/2, pictureBox3.Image.Height /2);
            // Color color2 = ((Bitmap)pictureBox3.Image).GetPixel(pictureBox3.Image.Width / 2, pictureBox3.Image.Height-100);
/*
            Color color1 = GetBackgroundAverageColor((Bitmap)pictureBox3.Image);
            Color color2 = GetClothColor((Bitmap)pictureBox3.Image);
             LinearGradientBrush brush = new LinearGradientBrush(new Point(0, 0), new Point(panel6.Width, panel6.Height), color1, color2);
             panel6.Paint += (s, e) => e.Graphics.FillRectangle(brush, e.ClipRectangle);
             panel6.SendToBack();*/


           FunctionsAll.RoundPanel(panel5, 50);
            FunctionsAll.RoundPanel(panelMenu, 50);
            
            FunctionsAll.RoundButton(button1,50 );
            //RoundButtonParams(50,buttonCourse,buttonArticle, button3,buttonComm,buttonCompile,buttonPortfolio,buttonProblems,buttonJob,buttonWork );
    
            foreach(Button btn in panel2.Controls.OfType<Button>())
            {
                FunctionsAll.RoundButton(btn, 50);
            }




        }
        



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.mac_close;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
             pictureBox1.Image = Properties.Resources.rsz_image_removebg_preview;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {



            // Animate the form out
            AnimateWindow(this.Handle, 200, AW_VER_NEGATIVE | AW_SLIDE | AW_HIDE);
            // Minimize the form
            this.WindowState = FormWindowState.Minimized;
            // Show the form on the taskbar
            this.ShowInTaskbar = true;

        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
              pictureBox2.Image = Properties.Resources.minimizeAfter;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.mac_mix_removebg_preview;
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             OpenChildForm(new FormProfile(), panel11);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        
        

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        private void MouseUpFunction(object sender  , EventArgs e)
        {
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click_3(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_3(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void buttonArticle_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormArticle(), panel11);
        }

        private void buttonPortfolio_Click(object sender, EventArgs e)
        {
             OpenChildForm(new FormProfile(), panel11);
        }

        private void buttonWork_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTypeSpeed(), panel11);
        }

        private void buttonProblems_Click(object sender, EventArgs e)
        {

        }

        private void buttonComm_Click(object sender, EventArgs e)
        {
             OpenChildForm(new FormCommunity(), panel11);
        }

        private void buttonCompile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCompiler(), panel11);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonJob_Click(object sender, EventArgs e)
        {

        }
       

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        public  void OpenChildForm(Form childForm, Panel parentPanel)
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
                // childForm.Size = parentPanel.Size;
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
                // childForm.Size = parentPanel.Size;

            }
        }

        
    }
}
