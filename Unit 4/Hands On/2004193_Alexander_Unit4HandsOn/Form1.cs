using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_Unit4HandsOn
{
	public partial class Form1 : Form
	{
		//Declare global variables
		private decimal itemPrice;
		private decimal totalOrder;
		private decimal totalSales;
		private int drinks;
		private int orders;

		public Form1()
		{
			InitializeComponent();
		}

		private void buttonAddtoOrder_Click(object sender, EventArgs e)
		{
			if (radioButtonNoSize.Checked)
			{
				MessageBox.Show("Select a drink size", "Missing Entry");
			}
			else
			{
				try
				{
					int quantity = int.Parse(textBoxQuantity.Text);
					if (quantity != 0)
					{
						drinks += quantity;
						totalOrder += itemPrice * quantity;
						buttonOrderComplete.Enabled = true;

						//Reset defaults
						radioButtonNoSize.Checked = true;
						radioButtonFruit.Checked = true;
						checkBoxVitaminPack.Checked = false;
						checkBoxEnergyBooster.Checked = false;
						checkBoxLadies.Checked = false;
						textBoxItemPrice.Clear();
						textBoxQuantity.Text = "1";
					}
					else
					{
						MessageBox.Show("Please enter a quantity", "Missing Entry");
					}
				}
				catch (FormatException)
				{
					MessageBox.Show("Invalid quantity", "Data Error");
					textBoxQuantity.Focus();
					textBoxQuantity.SelectAll();
				}
			}
		}

		private void buttonOrderComplete_Click(object sender, EventArgs e)
		{
			//When order is complete, add to summary and clear
			//Check if last item was added to total
			
			if (textBoxItemPrice.Text != "")
			{
				DialogResult responseDialogResult;
				string messageString = "Current Item not recorded. Add to order?";
				responseDialogResult = MessageBox.Show(messageString, "Verify Last Drink Purchase");

				if (responseDialogResult == DialogResult.Yes)
				{
					buttonAddtoOrder_Click(sender, e);
				}
			}

			//Display amount due
			string dueString = "Amount Due " + totalOrder.ToString("C");
			MessageBox.Show(dueString, "Order Complete");

			//Add to summary totals
			orders++;
			totalSales += totalOrder;

			//Reset buttons
			buttonSummaryReport.Enabled = true;
			buttonOrderComplete.Enabled = false;
			totalOrder = 0m;
		}

		private void buttonSummaryReport_Click(object sender, EventArgs e)
		{
			//Display summary information in Message Box

			string summaryString = "Drinks Sold:		" + drinks.ToString() + "\n\n" + "Total Sales:		" + totalSales.ToString("C");
			MessageBox.Show(summaryString, "Juice Bar Sales Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			//Close program
			this.Close();
		}

		private void radioButtonTwelveOunce_CheckedChanged(object sender, EventArgs e)
		{
			//Calculate and display price
			//handle all radio buttons and check boxes
			int extras = 0;
			if (radioButtonTwelveOunce.Checked)
			{
				itemPrice = 3m;
			}
			else if (radioButtonSixteenOunce.Checked)
			{
				itemPrice = 3.5m;
			}
			else if (radioButtonTwentyOunce.Checked)
			{
				itemPrice = 4m;
			}
			
			extras = 0;
			if (checkBoxVitaminPack.Checked)
			{
				extras++;
			}
			if (checkBoxEnergyBooster.Checked)
			{
				extras++;
			}
			if (checkBoxLadies.Checked)
			{
				extras++;
			}

			itemPrice += extras * .5m;
			textBoxItemPrice.Text = itemPrice.ToString("C");
		}
	}
}
