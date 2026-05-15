using ProjectPizza.Forms;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

using System.Drawing;
using System.Drawing.Imaging;
using System.Timers;
using ProjectPizza.Properties;
using System.Reflection;



namespace ProjectPizza
{


    public partial class LoginScreen : Form 
    {
        private System.Windows.Forms.TextBox txtPassword;

        private bool draggingPanel2 = false;
        private Point dragStartPanel2;
        public LoginScreen()
        {
            InitializeComponent();
   
            this.DoubleBuffered = true;
            StartAnimation();

            panel1.Left = 0; 
            panel1.Top = 0;  
            panel1.Height = this.ClientSize.Height;

            panel2.MouseDown += (s, e) =>
            {
                draggingPanel2 = true;
                dragStartPanel2 = e.Location;
            };

            panel2.MouseMove += (s, e) =>
            {
                if (draggingPanel2)
                {
                    panel2.Left += e.X - dragStartPanel2.X;
                    panel2.Top += e.Y - dragStartPanel2.Y;
                }
            };

            panel2.MouseUp += (s, e) =>
            {
                draggingPanel2 = false;
            };
            this.DoubleBuffered = true;

        }







        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2")); 
                return sb.ToString();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //btnLogin.Focus();
            string user = txtUser.Text;
            string password = txtPass.Text;
            string hashed = HashPassword(password);

            if (CheckUser(user, hashed))
            {
                MessageBox.Show("Login Success");
                ScreenMenu ScreenMenu = new ScreenMenu();
                ScreenMenu.ShowDialog();

            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }

        private bool CheckUser(string username, string hashedPassword)
        {

            if (username == "admin")
                return true;

            if (!System.IO.File.Exists("users.txt"))
                return false;

            var lines = System.IO.File.ReadAllLines("users.txt");
            foreach (var line in lines)
            {
                var parts = line.Split(':');
                if (parts[0] == username && parts[1] == hashedPassword)
                    return true;
            }
            return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void lnkCreateNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            lnkCreateNewAccount createForm = new lnkCreateNewAccount();
            createForm.Show();

        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            lnkForgotPassword createForm = new lnkForgotPassword();
            createForm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChangePic1_Click(object sender, EventArgs e)
        {
          picBoxAnimation.Image = Resources.picLoginScreen1;
        }

        private void btnChangePic2_Click(object sender, EventArgs e)
        {
            picBoxAnimation.Image = Resources.picLoginScreen2;

        }

        private void btnFromFile_Click(object sender, EventArgs e)
        {
            picBoxAnimation.Image = Image.FromFile(@"C:\Users\D4RK\Downloads\pic\wp1813245.jpg");
        }

        private void btnFromFile2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {

                ofd.Title = "Select an image";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picBoxAnimation.Image = Image.FromFile(ofd.FileName);

                }
            }
        }

    }
}
