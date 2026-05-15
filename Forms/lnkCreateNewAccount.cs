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

namespace ProjectPizza
{

    public partial class lnkCreateNewAccount : Form
    {
        public lnkCreateNewAccount()
        {
            InitializeComponent();
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
        private void SaveUser(string username, string password)
        {
            string hashed = HashPassword(password);
            string line = $"{username}:{hashed}";
            System.IO.File.AppendAllLines("users.txt", new[] { line });
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {


            //SaveUser(username, password); 

            MessageBox.Show("Account created successfully!");
        }
    }
}
