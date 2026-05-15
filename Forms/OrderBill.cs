using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace ProjectPizza.Forms
{
    
    public partial class OrderBill : Form
    {
        PizzaScreen Pizza = new PizzaScreen();

        public OrderBill(string size, string crust, string whereToEat,
                     string toppings, decimal totalPrice, string NumberOfPizza)
        {
            InitializeComponent();

            txtSize.Text = size;
            txtCrustType.Text = crust;
            txtWhereToEat.Text = whereToEat;
            txtToppings.Text = toppings;
            txtTotalPrice.Text = totalPrice.ToString("$ 0.00");
            txtNumberPizza.Text = NumberOfPizza;
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnExitBill_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
