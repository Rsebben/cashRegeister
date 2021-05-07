using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace cashRegeister
{
    public partial class Form1 : Form
    {
        //state varibles
        double burgerPrice = 0;
        double friePrice = 0;
        double drinkPrice = 0;
        double amountOfBurgers = 0;
        double amountOfFries = 0;
        double amountOfDrinks = 0;
        double totalCost = 0;
        double taxRate = 0;
        double amountOfTax = 0;
        double totalCostWithTax = 0;
        double tenderAmount = 0;
        double amountOfChange = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void calculateTotals_Click(object sender, EventArgs e)
        {
            //Get inputs and put them into the right global varible
            burgerPrice = Convert.ToDouble(burgerAmount.Text);
            friePrice = Convert.ToDouble(frieAmount.Text);
            drinkPrice = Convert.ToDouble(drinkAmount.Text);
            //calc total price before tax
             totalCost = burgerPrice + friePrice + drinkPrice;
            //output total with out tax
            subTotalAmount.Text = $"{totalCost.ToString("C")}";
            //calc tax amount
            taxRate = 0.13;
            amountOfTax = taxRate * totalCost;
            taxAmount.Text = $"{amountOfTax.ToString("C")}";
            //calc total amount with tax
            totalCostWithTax = amountOfTax + totalCost;
            totalAmount.Text = $"{totalCostWithTax.ToString("C")}";

        }

        private void calculateChange_Click(object sender, EventArgs e)
        {
            //get the amount tendered and put into inputs
            tenderAmount = Convert.ToDouble(tenderedAmount.Text);
            //calc change

            amountOfChange = tenderAmount - totalCostWithTax;
            changeAmount.Text = $"{amountOfChange.ToString("C")}";
        }

        private void printReceipt_Click(object sender, EventArgs e)
        {
            //receipt text
            receiptBox.Text = "            Welcome to burger town";
            Thread.Sleep(1000);
            receiptBox.Text += $"\n\nOrder Number 1070";
            receiptBox.Text += $"\nMay 5th 2021";
            receiptBox.Text += $"\n\nHamBurgers      x{burgerAmount.Text}  @{burgerPrice.ToString("C")}";
            receiptBox.Text += $"\nFrench Fries      x{frieAmount.Text}   @{friePrice.ToString("C")}";
            receiptBox.Text += $"\nDrinks                 x{drinkAmount.Text}   @{drinkPrice.ToString("C")}";
            receiptBox.Text += $"\n\nSubtotal                     {totalCost.ToString("C")}";
            receiptBox.Text += $"\nTax                              {amountOfTax.ToString("C")}";
            receiptBox.Text += $"\nTotal                            {totalCostWithTax.ToString("C")}";
            receiptBox.Text += $"\n\nTendered:                      {tenderAmount.ToString("C")}";
            receiptBox.Text += $"\nChange                          {amountOfChange.ToString("C")}";
            receiptBox.Text += $"\n\n\n           Have a nice day :)";
            //play receipt printing sound
            SoundPlayer player = new SoundPlayer(Properties.Resources.printerSound);
            player.Play();
        }

        private void newOrder_Click(object sender, EventArgs e)
        {
            
        }
    }
}
