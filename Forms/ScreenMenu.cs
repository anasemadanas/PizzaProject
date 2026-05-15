using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPizza.Forms
{
    public partial class ScreenMenu : Form
    {
        public ScreenMenu()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            PizzaScreen screen = new PizzaScreen();
            screen.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            this.Close();
  
        }
    }
}
