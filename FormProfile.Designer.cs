using Guna.UI2.WinForms;

namespace Coder_s_space
{
    partial class FormProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGitHub = new Guna.UI2.WinForms.Guna2Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.guna2Panel1.Controls.Add(this.guna2CustomGradientPanel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.guna2Panel1.Size = new System.Drawing.Size(1821, 786);
            this.guna2Panel1.TabIndex = 3;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.BorderRadius = 15;
            this.guna2CustomGradientPanel2.Controls.Add(this.panel1);
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.Cyan;
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.Magenta;
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.Aqua;
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.Fuchsia;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(13, 0);
            this.guna2CustomGradientPanel2.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(1795, 268);
            this.guna2CustomGradientPanel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.buttonGitHub);
            this.panel1.Controls.Add(this.labelUserName);
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panel1.Size = new System.Drawing.Size(1781, 256);
            this.panel1.TabIndex = 2;
            // 
            // buttonGitHub
            // 
            this.buttonGitHub.AutoRoundedCorners = true;
            this.buttonGitHub.BackColor = System.Drawing.Color.Transparent;
            this.buttonGitHub.BorderColor = System.Drawing.Color.Red;
            this.buttonGitHub.BorderRadius = 18;
            this.buttonGitHub.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.buttonGitHub.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonGitHub.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonGitHub.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonGitHub.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonGitHub.FillColor = System.Drawing.Color.Transparent;
            this.buttonGitHub.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.buttonGitHub.ForeColor = System.Drawing.Color.White;
            this.buttonGitHub.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonGitHub.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonGitHub.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.buttonGitHub.Image = global::Coder_s_space.Properties.Resources.edit;
            this.buttonGitHub.Location = new System.Drawing.Point(13, 107);
            this.buttonGitHub.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGitHub.Name = "buttonGitHub";
            this.buttonGitHub.Size = new System.Drawing.Size(43, 39);
            this.buttonGitHub.TabIndex = 49;
            this.buttonGitHub.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonGitHub.TextOffset = new System.Drawing.Point(-4, 0);
            this.buttonGitHub.UseTransparentBackground = true;
            // 
            // labelUserName
            // 
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold);
            this.labelUserName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelUserName.Location = new System.Drawing.Point(45, 89);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(723, 71);
            this.labelUserName.TabIndex = 32;
            this.labelUserName.Text = "Rs Rafsan";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelUserName.Click += new System.EventHandler(this.labelUserName_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2CirclePictureBox1.Image = global::Coder_s_space.Properties.Resources.profile_user;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(1548, 25);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(206, 206);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 2;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1821, 786);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProfile";
            this.Text = "Form3";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUserName;
        public Guna2Button buttonGitHub;
    }
}