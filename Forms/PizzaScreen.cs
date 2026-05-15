using ProjectPizza.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjectPizza
{
    public partial class PizzaScreen : Form
    {


        private decimal TotalPrice = 0m;
        public PizzaScreen()
        {
            InitializeComponent();

            ToppingMap = new Dictionary<CheckBox, enToppings>
            {
                { chkExtraChees, enToppings.ExtraChees },
                { chkGreenPeppers, enToppings.GreenPeppers },
                { chkMushrooms, enToppings.Mushrooms },
                { chkOlives, enToppings.Olives },
                { chkOnion, enToppings.Onion },
                { chkTomatoes, enToppings.Tomatoes }
            };
        }


        void rbSize (object sender)
        {
            RadioButton button = (RadioButton)sender;

            if (!button.Checked) return;

            if (button == rbSmall)
            {
                txtSize.Text = "Small";
                nudSmall.Visible = true;
                nudMedium.Visible = false;
                nudLarge.Visible = false;
            }
            else if (button == rbMedium)
            {
                txtSize.Text = "Medium";
                nudSmall.Visible = false;
                nudMedium.Visible = true;
                nudLarge.Visible = false;
            }
            else if (button == rbLarge)
            {
                txtSize.Text = "Large";
                nudSmall.Visible = false;
                nudMedium.Visible = false;
                nudLarge.Visible = true;
            }

            UpdateTotalPrice();

        }

        private void rbSmall_CheckedChanged(object sender, System.EventArgs e)
        {
 
            rbSize(sender);

        }
        private void rbMedium_CheckedChanged(object sender, System.EventArgs e)
        {

            rbSize(sender);
 
        }
        private void rbLarge_CheckedChanged(object sender, System.EventArgs e)
        {
            rbSize(sender);
        }

        private void rbThinCrust_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbThinCrust.Checked)
            {
                txtCrustType.Text = "Thin";
            }
        }

        private void rbThickCrust_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbThickCrust.Checked)
            {
                txtCrustType.Text = "Thick";
            }
        }

        private void rbEatIn_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbEatIn.Checked)
            {
                txtWhereToEat.Text = "Eat In";
            }

        }

        private void rbTakeOut_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbTakeOut.Checked)
            {
                txtWhereToEat.Text = "Take Out";
            }
            
        }

        private void txtToppings_TextChanged(object sender, System.EventArgs e)
        {
            //CheckBox[] toppings = { chkExtraChees, chkGreenPeppers, chkMushrooms, chkOlives, chkOnion, chkTomatoes };

            // Toppings
            //if (chkExtraChees.Checked) txtToppings.Text = "ExtraChees";
            //if (chkGreenPeppers.Checked)
            //if (chkMushrooms.Checked) 
            //if (chkOlives.Checked) 
            //if (chkOnion.Checked)
            //if (chkTomatoes.Checked)

            UpdateTotalPrice();
        }

        private void txtCrustType_TextChanged(object sender, System.EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void txtWhereToEat_TextChanged(object sender, System.EventArgs e)
        {
            UpdateTotalPrice();
        }


        //=========================== Enum =====================================
        enum enPizzaSize { Small, Medium, Large }
        enum enCrustType { Thin, Thick }
        enum enToppings { ExtraChees, GreenPeppers, Mushrooms, Olives, Onion, Tomatoes }

        Dictionary<enPizzaSize, decimal> PizzaSizePrices = new Dictionary<enPizzaSize, decimal>
        {
            { enPizzaSize.Small, 6m },
            { enPizzaSize.Medium, 10m },
            { enPizzaSize.Large, 15m }

        };

        Dictionary<enCrustType, decimal> CrustPrices = new Dictionary<enCrustType, decimal>
        {
            { enCrustType.Thin, 1m },
            { enCrustType.Thick, 2m }
        };

        Dictionary<enToppings, decimal> ToppingsPrices = new Dictionary<enToppings, decimal>
        {
            { enToppings.ExtraChees, 2m },
            { enToppings.GreenPeppers, 1m },
            { enToppings.Mushrooms, 1m },
            { enToppings.Olives, 1m },
            { enToppings.Onion, 1m },
            { enToppings.Tomatoes, 2m }
        };
        Dictionary<CheckBox, enToppings> ToppingMap;


        private void UpdateTotalPrice()
        {

            //enPizzaSize SelectedSize = rbSmall.Checked ? enPizzaSize.Small :
            //               rbMedium.Checked ? enPizzaSize.Medium : enPizzaSize.Large;
            //enCrustType CrustType = rbThickCrust.Checked ? enCrustType.Thick : enCrustType.Thin;
            //decimal SizePrice = PizzaSizePrices[SelectedSize];
            //decimal CrustPrice = CrustPrices[CrustType];


            decimal SizePrice = 0m;
            decimal CrustPrice = 0m;
            decimal ToppingsPrice = 0m;
            int pizzaCount = (int)numericUpDown1.Value;

            if (rbSmall.Checked) SizePrice = PizzaSizePrices[enPizzaSize.Small];
            if (rbMedium.Checked) SizePrice = PizzaSizePrices[enPizzaSize.Medium];
            if (rbLarge.Checked) SizePrice = PizzaSizePrices[enPizzaSize.Large];

            if (rbThinCrust.Checked) CrustPrice = CrustPrices[enCrustType.Thin];
            if (rbThickCrust.Checked) CrustPrice = CrustPrices[enCrustType.Thick];

            List <string> SelectedToppings = new List<string>();

            foreach (var item in ToppingMap)
            {
                if (item.Key.Checked)
                {
                    ToppingsPrice += ToppingsPrices[item.Value];

                    SelectedToppings.Add(item.Value.ToString());
                }
            }
            txtToppings.Text = string.Join(", ", SelectedToppings);

            decimal singlePizzaPrice = SizePrice + CrustPrice + ToppingsPrice;

            TotalPrice = singlePizzaPrice * pizzaCount;
            txtTotalPrice.Text = TotalPrice.ToString("$  0.00");



        }

  

        private void btnOrderBill_Click(object sender, System.EventArgs e)
        {
            OrderBill Bill = new OrderBill(txtSize.Text, txtCrustType.Text, txtWhereToEat.Text,
                txtToppings.Text,TotalPrice, txtNumberOfPizza.Text);
            Bill.Show();
          
        }

        private void btnResetForm_Click(object sender, System.EventArgs e)
        {
            // Reset Size
            rbSmall.Checked = false;
            rbMedium.Checked = false;
            rbLarge.Checked = false;

            // Reset Crust
            rbThinCrust.Checked = false;
            rbThickCrust.Checked = false;

            // Reset Where To Eat
            rbEatIn.Checked = false;
            rbTakeOut.Checked = false;

            // Reset Toppings
            chkExtraChees.Checked = false;
            chkGreenPeppers.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;

            // Reset TextBoxes
            txtSize.Text = "";
            txtCrustType.Text = "";
            txtWhereToEat.Text = "";
            txtTotalPrice.Text = "0.00 $";
            numericUpDown1.Enabled = true;
            // Enable Groups again
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbWhereToEat.Enabled = true;
            gbToppings.Enabled = true;

            // Disable Order button again
            btnOrderPizza.Enabled = true;

        }


        private bool ValidateOrder ()
        {
            if (!rbSmall.Checked && !rbMedium.Checked && !rbLarge.Checked)
            {
                MessageBox.Show("Please select pizza size first!",
                                "Order Error",
                                MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void btnOrderPizza_Click(object sender, System.EventArgs e)
        {

            if (ValidateOrder())
            {
                return;
            }

            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
          
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gbToppings.Enabled = false;
                gbSize.Enabled = false;
                gbWhereToEat.Enabled = false;
                gbCrustType.Enabled = false;
                btnOrderPizza.Enabled = false;
                numericUpDown1.Enabled = false;

            }

        }

        private void btnExitProgram_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

 

            if (rbSmall.Checked)
                numericUpDown1.Value = nudSmall.Value;

            else if (rbMedium.Checked)
                numericUpDown1.Value =  nudMedium.Value ;

            else if (rbLarge.Checked)
                numericUpDown1.Value =  nudLarge.Value ;

            txtNumberOfPizza.Text = numericUpDown1.Value.ToString();

            UpdateTotalPrice();

        }


    }
}
