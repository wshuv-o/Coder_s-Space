namespace Coder_s_space
{
    partial class FormMarketplace
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonGitHub = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(150, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 699);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonGitHub);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.panel2.Size = new System.Drawing.Size(1066, 129);
            this.panel2.TabIndex = 0;
            // 
            // buttonGitHub
            // 
            this.buttonGitHub.Animated = true;
            this.buttonGitHub.BorderColor = System.Drawing.Color.Red;
            this.buttonGitHub.BorderRadius = 15;
            this.buttonGitHub.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.buttonGitHub.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonGitHub.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonGitHub.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonGitHub.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonGitHub.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(166)))));
            this.buttonGitHub.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.buttonGitHub.ForeColor = System.Drawing.Color.White;
            this.buttonGitHub.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonGitHub.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonGitHub.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.buttonGitHub.Image = global::Coder_s_space.Properties.Resources.github_logo;
            this.buttonGitHub.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonGitHub.ImageOffset = new System.Drawing.Point(-2, 0);
            this.buttonGitHub.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonGitHub.Location = new System.Drawing.Point(896, 20);
            this.buttonGitHub.Name = "buttonGitHub";
            this.buttonGitHub.Size = new System.Drawing.Size(157, 45);
            this.buttonGitHub.TabIndex = 17;
            this.buttonGitHub.Text = "Create a Task";
            this.buttonGitHub.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonGitHub.TextOffset = new System.Drawing.Point(-4, 0);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 34);
            this.label1.TabIndex = 27;
            this.label1.Text = "Marketplace";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(678, 35);
            this.label2.TabIndex = 28;
            this.label2.Text = "Work with top Creators to turn your ideas into reality.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormMarketplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1366, 699);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMarketplace";
            this.Padding = new System.Windows.Forms.Padding(150, 0, 150, 0);
            this.Text = "FormMarketplace";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button buttonGitHub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}