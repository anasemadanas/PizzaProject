using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Timers;


namespace ProjectPizza
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.lbLogin2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFromFile2 = new System.Windows.Forms.Button();
            this.btnFromFile = new System.Windows.Forms.Button();
            this.btnChangePic2 = new System.Windows.Forms.Button();
            this.btnChangePic1 = new System.Windows.Forms.Button();
            this.picBoxAnimation = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lbLogin1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.lnkCreateNewAccount = new System.Windows.Forms.LinkLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAnimation)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLogin2
            // 
            this.lbLogin2.AutoSize = true;
            this.lbLogin2.BackColor = System.Drawing.Color.Black;
            this.lbLogin2.Font = new System.Drawing.Font("Andalus", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbLogin2.ForeColor = System.Drawing.Color.Red;
            this.lbLogin2.Location = new System.Drawing.Point(1, 65);
            this.lbLogin2.Name = "lbLogin2";
            this.lbLogin2.Size = new System.Drawing.Size(350, 54);
            this.lbLogin2.TabIndex = 1;
            this.lbLogin2.Text = "Welcome Pizza Corner";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnFromFile2);
            this.panel1.Controls.Add(this.btnFromFile);
            this.panel1.Controls.Add(this.btnChangePic2);
            this.panel1.Controls.Add(this.btnChangePic1);
            this.panel1.Controls.Add(this.lbLogin2);
            this.panel1.Controls.Add(this.picBoxAnimation);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 688);
            this.panel1.TabIndex = 5;
            // 
            // btnFromFile2
            // 
            this.btnFromFile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFromFile2.Location = new System.Drawing.Point(363, 631);
            this.btnFromFile2.Name = "btnFromFile2";
            this.btnFromFile2.Size = new System.Drawing.Size(81, 10);
            this.btnFromFile2.TabIndex = 5;
            this.btnFromFile2.Text = "button2";
            this.btnFromFile2.UseVisualStyleBackColor = false;
            this.btnFromFile2.Click += new System.EventHandler(this.btnFromFile2_Click);
            // 
            // btnFromFile
            // 
            this.btnFromFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFromFile.Location = new System.Drawing.Point(276, 631);
            this.btnFromFile.Name = "btnFromFile";
            this.btnFromFile.Size = new System.Drawing.Size(81, 10);
            this.btnFromFile.TabIndex = 4;
            this.btnFromFile.Text = "button2";
            this.btnFromFile.UseVisualStyleBackColor = false;
            this.btnFromFile.Click += new System.EventHandler(this.btnFromFile_Click);
            // 
            // btnChangePic2
            // 
            this.btnChangePic2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnChangePic2.Location = new System.Drawing.Point(189, 631);
            this.btnChangePic2.Name = "btnChangePic2";
            this.btnChangePic2.Size = new System.Drawing.Size(81, 10);
            this.btnChangePic2.TabIndex = 3;
            this.btnChangePic2.Text = "button2";
            this.btnChangePic2.UseVisualStyleBackColor = false;
            this.btnChangePic2.Click += new System.EventHandler(this.btnChangePic2_Click);
            // 
            // btnChangePic1
            // 
            this.btnChangePic1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnChangePic1.Location = new System.Drawing.Point(102, 631);
            this.btnChangePic1.Name = "btnChangePic1";
            this.btnChangePic1.Size = new System.Drawing.Size(81, 10);
            this.btnChangePic1.TabIndex = 2;
            this.btnChangePic1.Text = "button1";
            this.btnChangePic1.UseVisualStyleBackColor = false;
            this.btnChangePic1.Click += new System.EventHandler(this.btnChangePic1_Click);
            // 
            // picBoxAnimation
            // 
            this.picBoxAnimation.Image = global::ProjectPizza.Properties.Resources.picLoginScreen1;
            this.picBoxAnimation.Location = new System.Drawing.Point(0, 0);
            this.picBoxAnimation.Name = "picBoxAnimation";
            this.picBoxAnimation.Size = new System.Drawing.Size(465, 678);
            this.picBoxAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAnimation.TabIndex = 0;
            this.picBoxAnimation.TabStop = false;
            this.picBoxAnimation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoxAnimation_MouseDown);
            this.picBoxAnimation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoxAnimation_MouseMove);
            this.picBoxAnimation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBoxAnimation_MouseUp);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(139, 180);
            this.txtUser.MaxLength = 20;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(295, 31);
            this.txtUser.TabIndex = 0;
            this.txtUser.Text = "admin";
            // 
            // lbLogin1
            // 
            this.lbLogin1.AutoSize = true;
            this.lbLogin1.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin1.Font = new System.Drawing.Font("TI-Nspire", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin1.ForeColor = System.Drawing.Color.White;
            this.lbLogin1.Location = new System.Drawing.Point(178, 117);
            this.lbLogin1.Name = "lbLogin1";
            this.lbLogin1.Size = new System.Drawing.Size(220, 40);
            this.lbLogin1.TabIndex = 7;
            this.lbLogin1.Text = "Login Account";
            this.lbLogin1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Cyan;
            this.btnLogin.Location = new System.Drawing.Point(207, 325);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(172, 55);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lnkForgotPassword
            // 
            this.lnkForgotPassword.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lnkForgotPassword.AutoSize = true;
            this.lnkForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.lnkForgotPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkForgotPassword.LinkColor = System.Drawing.Color.White;
            this.lnkForgotPassword.Location = new System.Drawing.Point(331, 288);
            this.lnkForgotPassword.Name = "lnkForgotPassword";
            this.lnkForgotPassword.Size = new System.Drawing.Size(103, 16);
            this.lnkForgotPassword.TabIndex = 11;
            this.lnkForgotPassword.TabStop = true;
            this.lnkForgotPassword.Text = "Forgot Password";
            // 
            // lnkCreateNewAccount
            // 
            this.lnkCreateNewAccount.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lnkCreateNewAccount.AutoSize = true;
            this.lnkCreateNewAccount.BackColor = System.Drawing.Color.Transparent;
            this.lnkCreateNewAccount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCreateNewAccount.LinkColor = System.Drawing.Color.White;
            this.lnkCreateNewAccount.Location = new System.Drawing.Point(136, 288);
            this.lnkCreateNewAccount.Name = "lnkCreateNewAccount";
            this.lnkCreateNewAccount.Size = new System.Drawing.Size(123, 16);
            this.lnkCreateNewAccount.TabIndex = 12;
            this.lnkCreateNewAccount.TabStop = true;
            this.lnkCreateNewAccount.Text = "Create New Account";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Cyan;
            this.btnExit.Location = new System.Drawing.Point(399, 417);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 55);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(211, 550);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "© 2026 copyright DarkTeam , Inc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(488, 550);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Created by DarkTeam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Contact Info";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::ProjectPizza.Properties.Resources.picLoginScreen3;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.lnkCreateNewAccount);
            this.panel2.Controls.Add(this.lnkForgotPassword);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.lbLogin1);
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Location = new System.Drawing.Point(510, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 576);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(440, 233);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 23);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(139, 233);
            this.txtPass.MaxLength = 20;
            this.txtPass.Name = "txtPass";
            this.txtPass.ShortcutsEnabled = false;
            this.txtPass.Size = new System.Drawing.Size(295, 31);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "1234";
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ProjectPizza.Properties.Resources.picLoginScreen2;
            this.ClientSize = new System.Drawing.Size(1169, 712);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "LoginScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAnimation)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        Image[] images = { Properties.Resources.picLoginScreen1, Properties.Resources.picPizza1, Properties.Resources.picPizza2 };
        int index = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
           
            index++;
            if (index >= images.Length)
                index = 0; 

            picBoxAnimation.Image = images[index]; 
        }
        private void StartAnimation()
        {
            picBoxAnimation.Image = images[0];
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private bool dragging = false;
        private Point dragStartPoint;

        private void picBoxAnimation_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragStartPoint = e.Location;
        }

        private void picBoxAnimation_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                picBoxAnimation.Left += e.X - dragStartPoint.X;
                picBoxAnimation.Top += e.Y - dragStartPoint.Y;
            }
        }

        private void picBoxAnimation_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        //====================================================================





        #endregion
        private System.Windows.Forms.Label lbLogin2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBoxAnimation;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label lbLogin1;
        private Button btnLogin;
        private LinkLabel lnkForgotPassword;
        private LinkLabel lnkCreateNewAccount;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private CheckBox checkBox1;
        private Button btnChangePic2;
        private Button btnChangePic1;
        private Button btnFromFile;
        private Button btnFromFile2;
    }
}

