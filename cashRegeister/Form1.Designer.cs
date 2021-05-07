
namespace cashRegeister
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.burgerTown = new System.Windows.Forms.Label();
            this.numberOfBurgers = new System.Windows.Forms.Label();
            this.burgerAmount = new System.Windows.Forms.TextBox();
            this.numberOfFries = new System.Windows.Forms.Label();
            this.numberOfDrinks = new System.Windows.Forms.Label();
            this.frieAmount = new System.Windows.Forms.TextBox();
            this.drinkAmount = new System.Windows.Forms.TextBox();
            this.calculateTotals = new System.Windows.Forms.Button();
            this.subTotal = new System.Windows.Forms.Label();
            this.subTotalAmount = new System.Windows.Forms.Label();
            this.tax = new System.Windows.Forms.Label();
            this.taxAmount = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.totalAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tendered = new System.Windows.Forms.Label();
            this.tenderedAmount = new System.Windows.Forms.TextBox();
            this.calculateChange = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Label();
            this.changeAmount = new System.Windows.Forms.Label();
            this.printReceipt = new System.Windows.Forms.Button();
            this.newOrder = new System.Windows.Forms.Button();
            this.receiptBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // burgerTown
            // 
            this.burgerTown.BackColor = System.Drawing.Color.Blue;
            this.burgerTown.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerTown.ForeColor = System.Drawing.Color.White;
            this.burgerTown.Location = new System.Drawing.Point(-6, 0);
            this.burgerTown.Name = "burgerTown";
            this.burgerTown.Size = new System.Drawing.Size(907, 62);
            this.burgerTown.TabIndex = 0;
            this.burgerTown.Text = "Burger Town";
            // 
            // numberOfBurgers
            // 
            this.numberOfBurgers.AutoSize = true;
            this.numberOfBurgers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfBurgers.Location = new System.Drawing.Point(14, 107);
            this.numberOfBurgers.Name = "numberOfBurgers";
            this.numberOfBurgers.Size = new System.Drawing.Size(191, 24);
            this.numberOfBurgers.TabIndex = 1;
            this.numberOfBurgers.Text = "Number of Burgers";
            // 
            // burgerAmount
            // 
            this.burgerAmount.Location = new System.Drawing.Point(235, 107);
            this.burgerAmount.Name = "burgerAmount";
            this.burgerAmount.Size = new System.Drawing.Size(41, 25);
            this.burgerAmount.TabIndex = 2;
            // 
            // numberOfFries
            // 
            this.numberOfFries.AutoSize = true;
            this.numberOfFries.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfFries.Location = new System.Drawing.Point(14, 163);
            this.numberOfFries.Name = "numberOfFries";
            this.numberOfFries.Size = new System.Drawing.Size(162, 24);
            this.numberOfFries.TabIndex = 3;
            this.numberOfFries.Text = "Number of Fries";
            // 
            // numberOfDrinks
            // 
            this.numberOfDrinks.AutoSize = true;
            this.numberOfDrinks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfDrinks.Location = new System.Drawing.Point(14, 219);
            this.numberOfDrinks.Name = "numberOfDrinks";
            this.numberOfDrinks.Size = new System.Drawing.Size(176, 24);
            this.numberOfDrinks.TabIndex = 4;
            this.numberOfDrinks.Text = "Number of Drinks";
            // 
            // frieAmount
            // 
            this.frieAmount.Location = new System.Drawing.Point(235, 166);
            this.frieAmount.Name = "frieAmount";
            this.frieAmount.Size = new System.Drawing.Size(41, 25);
            this.frieAmount.TabIndex = 5;
            // 
            // drinkAmount
            // 
            this.drinkAmount.Location = new System.Drawing.Point(235, 219);
            this.drinkAmount.Name = "drinkAmount";
            this.drinkAmount.Size = new System.Drawing.Size(41, 25);
            this.drinkAmount.TabIndex = 6;
            // 
            // calculateTotals
            // 
            this.calculateTotals.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTotals.Location = new System.Drawing.Point(51, 274);
            this.calculateTotals.Name = "calculateTotals";
            this.calculateTotals.Size = new System.Drawing.Size(154, 42);
            this.calculateTotals.TabIndex = 7;
            this.calculateTotals.Text = "Calculate Totals";
            this.calculateTotals.UseVisualStyleBackColor = true;
            this.calculateTotals.Click += new System.EventHandler(this.calculateTotals_Click);
            // 
            // subTotal
            // 
            this.subTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotal.Location = new System.Drawing.Point(12, 340);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(171, 35);
            this.subTotal.TabIndex = 8;
            this.subTotal.Text = "Sub Total";
            // 
            // subTotalAmount
            // 
            this.subTotalAmount.Location = new System.Drawing.Point(194, 340);
            this.subTotalAmount.Name = "subTotalAmount";
            this.subTotalAmount.Size = new System.Drawing.Size(112, 26);
            this.subTotalAmount.TabIndex = 9;
            // 
            // tax
            // 
            this.tax.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax.Location = new System.Drawing.Point(12, 375);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(82, 32);
            this.tax.TabIndex = 10;
            this.tax.Text = "Tax";
            // 
            // taxAmount
            // 
            this.taxAmount.Location = new System.Drawing.Point(194, 375);
            this.taxAmount.Name = "taxAmount";
            this.taxAmount.Size = new System.Drawing.Size(112, 29);
            this.taxAmount.TabIndex = 11;
            // 
            // totalPrice
            // 
            this.totalPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(12, 416);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(78, 23);
            this.totalPrice.TabIndex = 12;
            this.totalPrice.Text = "Total:";
            // 
            // totalAmount
            // 
            this.totalAmount.Location = new System.Drawing.Point(183, 416);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(93, 23);
            this.totalAmount.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // tendered
            // 
            this.tendered.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendered.Location = new System.Drawing.Point(17, 503);
            this.tendered.Name = "tendered";
            this.tendered.Size = new System.Drawing.Size(110, 29);
            this.tendered.TabIndex = 15;
            this.tendered.Text = "Tendered:";
            // 
            // tenderedAmount
            // 
            this.tenderedAmount.Location = new System.Drawing.Point(176, 503);
            this.tenderedAmount.Name = "tenderedAmount";
            this.tenderedAmount.Size = new System.Drawing.Size(100, 25);
            this.tenderedAmount.TabIndex = 16;
            // 
            // calculateChange
            // 
            this.calculateChange.Location = new System.Drawing.Point(51, 535);
            this.calculateChange.Name = "calculateChange";
            this.calculateChange.Size = new System.Drawing.Size(154, 39);
            this.calculateChange.TabIndex = 17;
            this.calculateChange.Text = "Calculate Change";
            this.calculateChange.UseVisualStyleBackColor = true;
            this.calculateChange.Click += new System.EventHandler(this.calculateChange_Click);
            // 
            // change
            // 
            this.change.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.Location = new System.Drawing.Point(17, 601);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(92, 23);
            this.change.TabIndex = 18;
            this.change.Text = "Change:";
            // 
            // changeAmount
            // 
            this.changeAmount.Location = new System.Drawing.Point(217, 606);
            this.changeAmount.Name = "changeAmount";
            this.changeAmount.Size = new System.Drawing.Size(59, 18);
            this.changeAmount.TabIndex = 19;
            // 
            // printReceipt
            // 
            this.printReceipt.Location = new System.Drawing.Point(51, 649);
            this.printReceipt.Name = "printReceipt";
            this.printReceipt.Size = new System.Drawing.Size(154, 43);
            this.printReceipt.TabIndex = 20;
            this.printReceipt.Text = "Print Receipt";
            this.printReceipt.UseVisualStyleBackColor = true;
            this.printReceipt.Click += new System.EventHandler(this.printReceipt_Click);
            // 
            // newOrder
            // 
            this.newOrder.Location = new System.Drawing.Point(675, 649);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(111, 45);
            this.newOrder.TabIndex = 22;
            this.newOrder.Text = "New Order";
            this.newOrder.UseVisualStyleBackColor = true;
            this.newOrder.Click += new System.EventHandler(this.newOrder_Click);
            // 
            // receiptBox
            // 
            this.receiptBox.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptBox.Location = new System.Drawing.Point(628, 112);
            this.receiptBox.Name = "receiptBox";
            this.receiptBox.Size = new System.Drawing.Size(243, 449);
            this.receiptBox.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 725);
            this.Controls.Add(this.receiptBox);
            this.Controls.Add(this.newOrder);
            this.Controls.Add(this.printReceipt);
            this.Controls.Add(this.changeAmount);
            this.Controls.Add(this.change);
            this.Controls.Add(this.calculateChange);
            this.Controls.Add(this.tenderedAmount);
            this.Controls.Add(this.tendered);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.taxAmount);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.subTotalAmount);
            this.Controls.Add(this.subTotal);
            this.Controls.Add(this.calculateTotals);
            this.Controls.Add(this.drinkAmount);
            this.Controls.Add(this.frieAmount);
            this.Controls.Add(this.numberOfDrinks);
            this.Controls.Add(this.numberOfFries);
            this.Controls.Add(this.burgerAmount);
            this.Controls.Add(this.numberOfBurgers);
            this.Controls.Add(this.burgerTown);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label burgerTown;
        private System.Windows.Forms.Label numberOfBurgers;
        private System.Windows.Forms.TextBox burgerAmount;
        private System.Windows.Forms.Label numberOfFries;
        private System.Windows.Forms.Label numberOfDrinks;
        private System.Windows.Forms.TextBox frieAmount;
        private System.Windows.Forms.TextBox drinkAmount;
        private System.Windows.Forms.Button calculateTotals;
        private System.Windows.Forms.Label subTotal;
        private System.Windows.Forms.Label subTotalAmount;
        private System.Windows.Forms.Label tax;
        private System.Windows.Forms.Label taxAmount;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label totalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tendered;
        private System.Windows.Forms.TextBox tenderedAmount;
        private System.Windows.Forms.Button calculateChange;
        private System.Windows.Forms.Label change;
        private System.Windows.Forms.Label changeAmount;
        private System.Windows.Forms.Button printReceipt;
        private System.Windows.Forms.Button newOrder;
        private System.Windows.Forms.Label receiptBox;
    }
}

