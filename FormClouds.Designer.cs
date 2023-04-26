namespace Coder_s_space
{
    partial class FormClouds
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
            this.components = new System.ComponentModel.Container();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonJSFiddle = new Guna.UI2.WinForms.Guna2Button();
            this.buttonPasteCode = new Guna.UI2.WinForms.Guna2Button();
            this.buttonGist = new Guna.UI2.WinForms.Guna2Button();
            this.buttonReplIt = new Guna.UI2.WinForms.Guna2Button();
            this.buttonCodePen = new Guna.UI2.WinForms.Guna2Button();
            this.buttonBitBucket = new Guna.UI2.WinForms.Guna2Button();
            this.buttonGitLab = new Guna.UI2.WinForms.Guna2Button();
            this.buttonGitHub = new Guna.UI2.WinForms.Guna2Button();
            this.toolTipCompilers = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panelBrowser = new System.Windows.Forms.Panel();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.chatBoxLabel = new System.Windows.Forms.Label();
            this.buttonCodeSandbox = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.panelBrowser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.buttonCodeSandbox);
            this.guna2Panel1.Controls.Add(this.buttonJSFiddle);
            this.guna2Panel1.Controls.Add(this.buttonPasteCode);
            this.guna2Panel1.Controls.Add(this.buttonGist);
            this.guna2Panel1.Controls.Add(this.buttonReplIt);
            this.guna2Panel1.Controls.Add(this.buttonCodePen);
            this.guna2Panel1.Controls.Add(this.buttonBitBucket);
            this.guna2Panel1.Controls.Add(this.buttonGitLab);
            this.guna2Panel1.Controls.Add(this.buttonGitHub);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel1.CustomizableEdges.BottomLeft = false;
            this.guna2Panel1.CustomizableEdges.TopRight = false;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(1256, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(1, 100, 1, 1);
            this.guna2Panel1.Size = new System.Drawing.Size(94, 729);
            this.guna2Panel1.TabIndex = 4;
            // 
            // buttonJSFiddle
            // 
            this.buttonJSFiddle.BorderRadius = 15;
            this.buttonJSFiddle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonJSFiddle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonJSFiddle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonJSFiddle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonJSFiddle.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonJSFiddle.FillColor = System.Drawing.Color.Transparent;
            this.buttonJSFiddle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonJSFiddle.ForeColor = System.Drawing.Color.White;
            this.buttonJSFiddle.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonJSFiddle.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonJSFiddle.HoverState.FillColor = System.Drawing.Color.Violet;
            this.buttonJSFiddle.Image = global::Coder_s_space.Properties.Resources.html_icon;
            this.buttonJSFiddle.ImageSize = new System.Drawing.Size(32, 32);
            this.buttonJSFiddle.Location = new System.Drawing.Point(1, 443);
            this.buttonJSFiddle.Name = "buttonJSFiddle";
            this.buttonJSFiddle.Size = new System.Drawing.Size(92, 49);
            this.buttonJSFiddle.TabIndex = 23;
            this.toolTipCompilers.SetToolTip(this.buttonJSFiddle, "HTML Editor");
            this.buttonJSFiddle.Click += new System.EventHandler(this.buttonJSFiddle_Click);
            // 
            // buttonPasteCode
            // 
            this.buttonPasteCode.BorderRadius = 15;
            this.buttonPasteCode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPasteCode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonPasteCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonPasteCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonPasteCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPasteCode.FillColor = System.Drawing.Color.Transparent;
            this.buttonPasteCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonPasteCode.ForeColor = System.Drawing.Color.White;
            this.buttonPasteCode.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonPasteCode.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonPasteCode.HoverState.FillColor = System.Drawing.Color.Violet;
            this.buttonPasteCode.Image = global::Coder_s_space.Properties.Resources.php;
            this.buttonPasteCode.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonPasteCode.Location = new System.Drawing.Point(1, 394);
            this.buttonPasteCode.Name = "buttonPasteCode";
            this.buttonPasteCode.Size = new System.Drawing.Size(92, 49);
            this.buttonPasteCode.TabIndex = 22;
            this.toolTipCompilers.SetToolTip(this.buttonPasteCode, "Php Compiler");
            this.buttonPasteCode.Click += new System.EventHandler(this.buttonPasteCode_Click);
            // 
            // buttonGist
            // 
            this.buttonGist.BorderRadius = 15;
            this.buttonGist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonGist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonGist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonGist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonGist.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGist.FillColor = System.Drawing.Color.Transparent;
            this.buttonGist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonGist.ForeColor = System.Drawing.Color.White;
            this.buttonGist.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonGist.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonGist.HoverState.FillColor = System.Drawing.Color.Violet;
            this.buttonGist.Image = global::Coder_s_space.Properties.Resources.icons8_database_32;
            this.buttonGist.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonGist.Location = new System.Drawing.Point(1, 345);
            this.buttonGist.Name = "buttonGist";
            this.buttonGist.Size = new System.Drawing.Size(92, 49);
            this.buttonGist.TabIndex = 21;
            this.toolTipCompilers.SetToolTip(this.buttonGist, "SQL Editor");
            this.buttonGist.Click += new System.EventHandler(this.buttonGist_Click);
            // 
            // buttonReplIt
            // 
            this.buttonReplIt.BorderRadius = 15;
            this.buttonReplIt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonReplIt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonReplIt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonReplIt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonReplIt.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReplIt.FillColor = System.Drawing.Color.Transparent;
            this.buttonReplIt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonReplIt.ForeColor = System.Drawing.Color.White;
            this.buttonReplIt.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonReplIt.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonReplIt.HoverState.FillColor = System.Drawing.Color.Violet;
            this.buttonReplIt.Image = global::Coder_s_space.Properties.Resources.python;
            this.buttonReplIt.ImageSize = new System.Drawing.Size(28, 28);
            this.buttonReplIt.Location = new System.Drawing.Point(1, 296);
            this.buttonReplIt.Name = "buttonReplIt";
            this.buttonReplIt.Size = new System.Drawing.Size(92, 49);
            this.buttonReplIt.TabIndex = 20;
            this.toolTipCompilers.SetToolTip(this.buttonReplIt, "Python Compiler");
            this.buttonReplIt.Click += new System.EventHandler(this.buttonReplIt_Click);
            // 
            // buttonCodePen
            // 
            this.buttonCodePen.BorderRadius = 15;
            this.buttonCodePen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCodePen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCodePen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCodePen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCodePen.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCodePen.FillColor = System.Drawing.Color.Transparent;
            this.buttonCodePen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCodePen.ForeColor = System.Drawing.Color.White;
            this.buttonCodePen.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonCodePen.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonCodePen.HoverState.FillColor = System.Drawing.Color.Violet;
            this.buttonCodePen.Image = global::Coder_s_space.Properties.Resources.java;
            this.buttonCodePen.ImageSize = new System.Drawing.Size(32, 32);
            this.buttonCodePen.Location = new System.Drawing.Point(1, 247);
            this.buttonCodePen.Name = "buttonCodePen";
            this.buttonCodePen.Size = new System.Drawing.Size(92, 49);
            this.buttonCodePen.TabIndex = 19;
            this.toolTipCompilers.SetToolTip(this.buttonCodePen, "JavaCompiler");
            this.buttonCodePen.Click += new System.EventHandler(this.buttonPasteBin_Click);
            // 
            // buttonBitBucket
            // 
            this.buttonBitBucket.BorderRadius = 15;
            this.buttonBitBucket.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBitBucket.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonBitBucket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonBitBucket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonBitBucket.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBitBucket.FillColor = System.Drawing.Color.Transparent;
            this.buttonBitBucket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBitBucket.ForeColor = System.Drawing.Color.White;
            this.buttonBitBucket.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonBitBucket.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonBitBucket.HoverState.FillColor = System.Drawing.Color.Violet;
            this.buttonBitBucket.Image = global::Coder_s_space.Properties.Resources.icons8_c_programming_32__2_;
            this.buttonBitBucket.ImageSize = new System.Drawing.Size(32, 32);
            this.buttonBitBucket.Location = new System.Drawing.Point(1, 198);
            this.buttonBitBucket.Name = "buttonBitBucket";
            this.buttonBitBucket.Size = new System.Drawing.Size(92, 49);
            this.buttonBitBucket.TabIndex = 18;
            this.toolTipCompilers.SetToolTip(this.buttonBitBucket, "C Compiler");
            this.buttonBitBucket.Click += new System.EventHandler(this.buttonBitBucket_Click);
            // 
            // buttonGitLab
            // 
            this.buttonGitLab.BorderRadius = 15;
            this.buttonGitLab.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonGitLab.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonGitLab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonGitLab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonGitLab.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGitLab.FillColor = System.Drawing.Color.Transparent;
            this.buttonGitLab.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.buttonGitLab.ForeColor = System.Drawing.Color.White;
            this.buttonGitLab.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonGitLab.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonGitLab.HoverState.FillColor = System.Drawing.Color.Violet;
            this.buttonGitLab.Image = global::Coder_s_space.Properties.Resources.c_;
            this.buttonGitLab.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonGitLab.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonGitLab.Location = new System.Drawing.Point(1, 149);
            this.buttonGitLab.Name = "buttonGitLab";
            this.buttonGitLab.Size = new System.Drawing.Size(92, 49);
            this.buttonGitLab.TabIndex = 17;
            this.buttonGitLab.Text = "GitLab";
            this.buttonGitLab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTipCompilers.SetToolTip(this.buttonGitLab, "C++ Compiler");
            this.buttonGitLab.Click += new System.EventHandler(this.buttonGitLab_Click);
            // 
            // buttonGitHub
            // 
            this.buttonGitHub.BorderRadius = 15;
            this.buttonGitHub.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonGitHub.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonGitHub.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonGitHub.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonGitHub.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGitHub.FillColor = System.Drawing.Color.Transparent;
            this.buttonGitHub.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.buttonGitHub.ForeColor = System.Drawing.Color.White;
            this.buttonGitHub.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonGitHub.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonGitHub.HoverState.FillColor = System.Drawing.Color.Violet;
            this.buttonGitHub.Image = global::Coder_s_space.Properties.Resources.icons8_c_sharp_logo_32__1_;
            this.buttonGitHub.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonGitHub.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonGitHub.Location = new System.Drawing.Point(1, 100);
            this.buttonGitHub.Name = "buttonGitHub";
            this.buttonGitHub.Size = new System.Drawing.Size(92, 49);
            this.buttonGitHub.TabIndex = 16;
            this.buttonGitHub.Text = "GitHub";
            this.buttonGitHub.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTipCompilers.SetToolTip(this.buttonGitHub, "C# Compiler");
            this.buttonGitHub.Click += new System.EventHandler(this.buttonGitHub_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panel1.Location = new System.Drawing.Point(0, 670);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 59);
            this.panel1.TabIndex = 1;
            // 
            // panelBrowser
            // 
            this.panelBrowser.BackColor = System.Drawing.Color.Transparent;
            this.panelBrowser.Controls.Add(this.webView21);
            this.panelBrowser.Controls.Add(this.guna2CustomGradientPanel1);
            this.panelBrowser.Controls.Add(this.panel1);
            this.panelBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBrowser.Location = new System.Drawing.Point(0, 0);
            this.panelBrowser.Name = "panelBrowser";
            this.panelBrowser.Size = new System.Drawing.Size(1256, 729);
            this.panelBrowser.TabIndex = 5;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 31);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1256, 639);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.Controls.Add(this.chatBoxLabel);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1256, 31);
            this.guna2CustomGradientPanel1.TabIndex = 2;
            // 
            // chatBoxLabel
            // 
            this.chatBoxLabel.BackColor = System.Drawing.Color.Transparent;
            this.chatBoxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatBoxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.chatBoxLabel.Location = new System.Drawing.Point(0, 0);
            this.chatBoxLabel.Name = "chatBoxLabel";
            this.chatBoxLabel.Size = new System.Drawing.Size(1256, 31);
            this.chatBoxLabel.TabIndex = 1;
            this.chatBoxLabel.Text = "Contribute, Store && Share";
            this.chatBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCodeSandbox
            // 
            this.buttonCodeSandbox.BorderRadius = 15;
            this.buttonCodeSandbox.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCodeSandbox.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCodeSandbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCodeSandbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCodeSandbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCodeSandbox.FillColor = System.Drawing.Color.Transparent;
            this.buttonCodeSandbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCodeSandbox.ForeColor = System.Drawing.Color.White;
            this.buttonCodeSandbox.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonCodeSandbox.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonCodeSandbox.HoverState.FillColor = System.Drawing.Color.Violet;
            this.buttonCodeSandbox.Image = global::Coder_s_space.Properties.Resources.html_icon;
            this.buttonCodeSandbox.ImageSize = new System.Drawing.Size(32, 32);
            this.buttonCodeSandbox.Location = new System.Drawing.Point(1, 492);
            this.buttonCodeSandbox.Name = "buttonCodeSandbox";
            this.buttonCodeSandbox.Size = new System.Drawing.Size(92, 49);
            this.buttonCodeSandbox.TabIndex = 24;
            this.toolTipCompilers.SetToolTip(this.buttonCodeSandbox, "HTML Editor");
            this.buttonCodeSandbox.Click += new System.EventHandler(this.buttonCodeSandbox_Click);
            // 
            // FormClouds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panelBrowser);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClouds";
            this.Text = "FormClouds";
            this.guna2Panel1.ResumeLayout(false);
            this.panelBrowser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.ToolTip toolTipCompilers;
        private Guna.UI2.WinForms.Guna2Button buttonJSFiddle;
        private Guna.UI2.WinForms.Guna2Button buttonPasteCode;
        private Guna.UI2.WinForms.Guna2Button buttonGist;
        private Guna.UI2.WinForms.Guna2Button buttonReplIt;
        private Guna.UI2.WinForms.Guna2Button buttonCodePen;
        private Guna.UI2.WinForms.Guna2Button buttonBitBucket;
        private Guna.UI2.WinForms.Guna2Button buttonGitLab;
        private Guna.UI2.WinForms.Guna2Button buttonGitHub;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel1;
        private System.Windows.Forms.Panel panelBrowser;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label chatBoxLabel;
        private Guna.UI2.WinForms.Guna2Button buttonCodeSandbox;
    }
}