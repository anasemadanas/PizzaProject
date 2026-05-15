namespace ProjectPizza.Forms
{
    partial class OrderBill
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
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtWhereToEat = new System.Windows.Forms.TextBox();
            this.txtCrustType = new System.Windows.Forms.TextBox();
            this.txtToppings = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.btnExitBill = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtNumberPizza = new System.Windows.Forms.TextBox();
            this.lblNumberofPizza = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.LightCoral;
            this.txtTotalPrice.Location = new System.Drawing.Point(279, 457);
            this.txtTotalPrice.Multiline = true;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(186, 43);
            this.txtTotalPrice.TabIndex = 35;
            // 
            // txtWhereToEat
            // 
            this.txtWhereToEat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtWhereToEat.Enabled = false;
            this.txtWhereToEat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhereToEat.ForeColor = System.Drawing.Color.LightCoral;
            this.txtWhereToEat.Location = new System.Drawing.Point(279, 395);
            this.txtWhereToEat.Multiline = true;
            this.txtWhereToEat.Name = "txtWhereToEat";
            this.txtWhereToEat.Size = new System.Drawing.Size(186, 43);
            this.txtWhereToEat.TabIndex = 34;
            // 
            // txtCrustType
            // 
            this.txtCrustType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCrustType.Enabled = false;
            this.txtCrustType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrustType.ForeColor = System.Drawing.Color.LightCoral;
            this.txtCrustType.Location = new System.Drawing.Point(279, 319);
            this.txtCrustType.Multiline = true;
            this.txtCrustType.Name = "txtCrustType";
            this.txtCrustType.Size = new System.Drawing.Size(186, 43);
            this.txtCrustType.TabIndex = 33;
            // 
            // txtToppings
            // 
            this.txtToppings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtToppings.Enabled = false;
            this.txtToppings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToppings.ForeColor = System.Drawing.Color.LightCoral;
            this.txtToppings.Location = new System.Drawing.Point(242, 217);
            this.txtToppings.Multiline = true;
            this.txtToppings.Name = "txtToppings";
            this.txtToppings.Size = new System.Drawing.Size(223, 78);
            this.txtToppings.TabIndex = 32;
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSize.Enabled = false;
            this.txtSize.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.ForeColor = System.Drawing.Color.LightCoral;
            this.txtSize.Location = new System.Drawing.Point(279, 141);
            this.txtSize.Multiline = true;
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(186, 43);
            this.txtSize.TabIndex = 31;
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTotalPrice.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPrice.Location = new System.Drawing.Point(41, 457);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(193, 43);
            this.lblTotalPrice.TabIndex = 30;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblWhereToEat.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.ForeColor = System.Drawing.Color.Black;
            this.lblWhereToEat.Location = new System.Drawing.Point(41, 393);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(217, 43);
            this.lblWhereToEat.TabIndex = 29;
            this.lblWhereToEat.Text = "WhereToEat";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCrustType.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.ForeColor = System.Drawing.Color.Black;
            this.lblCrustType.Location = new System.Drawing.Point(41, 319);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(196, 43);
            this.lblCrustType.TabIndex = 28;
            this.lblCrustType.Text = "Crust Type";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblToppings.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.ForeColor = System.Drawing.Color.Black;
            this.lblToppings.Location = new System.Drawing.Point(41, 223);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(162, 43);
            this.lblToppings.TabIndex = 27;
            this.lblToppings.Text = "Toppings";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblSize.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.Black;
            this.lblSize.Location = new System.Drawing.Point(41, 141);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(85, 43);
            this.lblSize.TabIndex = 26;
            this.lblSize.Text = "Size";
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblOrderSummary.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSummary.ForeColor = System.Drawing.Color.Black;
            this.lblOrderSummary.Location = new System.Drawing.Point(129, 80);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(264, 43);
            this.lblOrderSummary.TabIndex = 25;
            this.lblOrderSummary.Text = "Order Summary";
            // 
            // btnExitBill
            // 
            this.btnExitBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExitBill.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExitBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitBill.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitBill.ForeColor = System.Drawing.Color.Black;
            this.btnExitBill.Location = new System.Drawing.Point(291, 607);
            this.btnExitBill.Name = "btnExitBill";
            this.btnExitBill.Size = new System.Drawing.Size(132, 43);
            this.btnExitBill.TabIndex = 36;
            this.btnExitBill.Text = "Close";
            this.btnExitBill.UseVisualStyleBackColor = false;
            this.btnExitBill.Click += new System.EventHandler(this.btnExitBill_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(96, 607);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(132, 43);
            this.btnPrint.TabIndex = 37;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // txtNumberPizza
            // 
            this.txtNumberPizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNumberPizza.Enabled = false;
            this.txtNumberPizza.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberPizza.ForeColor = System.Drawing.Color.LightCoral;
            this.txtNumberPizza.Location = new System.Drawing.Point(279, 536);
            this.txtNumberPizza.Multiline = true;
            this.txtNumberPizza.Name = "txtNumberPizza";
            this.txtNumberPizza.Size = new System.Drawing.Size(186, 43);
            this.txtNumberPizza.TabIndex = 39;
            // 
            // lblNumberofPizza
            // 
            this.lblNumberofPizza.AutoSize = true;
            this.lblNumberofPizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblNumberofPizza.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberofPizza.ForeColor = System.Drawing.Color.Black;
            this.lblNumberofPizza.Location = new System.Drawing.Point(43, 518);
            this.lblNumberofPizza.Name = "lblNumberofPizza";
            this.lblNumberofPizza.Size = new System.Drawing.Size(161, 72);
            this.lblNumberofPizza.TabIndex = 38;
            this.lblNumberofPizza.Text = "Number of \r\nPizza";
            this.lblNumberofPizza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectPizza.Properties.Resources.picBill;
            this.ClientSize = new System.Drawing.Size(508, 701);
            this.Controls.Add(this.txtNumberPizza);
            this.Controls.Add(this.lblNumberofPizza);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExitBill);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtWhereToEat);
            this.Controls.Add(this.txtCrustType);
            this.Controls.Add(this.txtToppings);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblWhereToEat);
            this.Controls.Add(this.lblCrustType);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblOrderSummary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderBill";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtWhereToEat;
        private System.Windows.Forms.TextBox txtCrustType;
        private System.Windows.Forms.TextBox txtToppings;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.Button btnExitBill;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtNumberPizza;
        private System.Windows.Forms.Label lblNumberofPizza;
    }
}