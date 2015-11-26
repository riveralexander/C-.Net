using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_Unit5HandsOn
{
	public partial class Form1 : Form
	{
		//Declare global variables
		decimal itemSize, totalOrder, totalSales;
		decimal drink;
		int drinks, orders;

		public Form1()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void printToolStripMenuItem_Click(object sender, EventArgs e)
		{
			printForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
			printForm.Print();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutBox1 aboutForm = new AboutBox1();
			aboutForm.ShowDialog();
		}

		private void buttonAddToOrder_Click(object sender, EventArgs e)
		{
			if (radioButtonNoSize.Checked)
			{
				MessageBox.Show("Missing drink and size value.", "Missing Required Entry");
			}
			else
			{
				try
				{
					int quantity = int.Parse(textBoxQuantity.Text);

					if (quantity > 0)
					{
						drinks += quantity;
						totalOrder += drink * quantity;
						clearForNextItem();
						buttonOrderComplete.Enabled = true;
					}
					else
					{
						MessageBox.Show("Missing quantity value", "Missing Required Entry");
					}
				}
				catch
				{
					MessageBox.Show("Invalid quantity value", "Data Error");
					textBoxQuantity.Focus();
					textBoxQuantity.SelectAll();
				}
			}
		}

		private void buttonOrderComplete_Click(object sender, EventArgs e)
		{
			if (textBoxItemPrice.Text != "")
			{
				DialogResult responseDialogResult;
				string messageString = "Current item not recorded. Add to order?";
				responseDialogResult = MessageBox.Show(messageString, "Verify Last Drink Purchase", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (responseDialogResult == DialogResult.Yes)
				{
					buttonAddToOrder_Click(sender, e);
				}

				//Show amount due
				string dueString = "Amount Due  " + totalOrder.ToString("C");
				MessageBox.Show(dueString, "Order Complete");

				//Add to summary totals
				orders++;
				totalSales += totalOrder;

				//Reset for new order
				buttonSummary.Enabled = true;
				summaryToolStripMenuItem.Enabled = true;
				buttonOrderComplete.Enabled = false;
				orderCompleteToolStripMenuItem.Enabled = false;
				totalOrder = 0m;
			}
		}

		private void buttonSummary_Click(object sender, EventArgs e)
		{
			//Show summary information in a Message box
			Form2 aFormSummary = new Form2();
			aFormSummary.TotalSales = totalSales;
			aFormSummary.NumberOrders = orders;
			aFormSummary.DrinksSold = drinks;

			aFormSummary.ShowDialog();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			//Close application
			this.Close();
		}

		private void radioButtonTwelveOunce_CheckedChanged(object sender, EventArgs e)
		{
			//Calculate and show price for selected item
			//Handles all check boxes and radio buttons

			//Cast the sender to a radio button type
			RadioButton selectedSizeRadioButton = (RadioButton)sender;

			switch (selectedSizeRadioButton.Name)
			{
				case "radioButtonTwelveOunce":
					itemSize = 3m;
					break;
				case "radioButtonSixteenOunce":
					itemSize = 3.5m;
					break;
				case "radioButtonTwentyOunce":
					itemSize = 4m;
					break;
			}

			drink = itemSize + findExtrasPrice();
			textBoxItemPrice.Text = drink.ToString("C");
		}

		private void clearForNextItem()
		{
			//Clear radio buttons, checkboxes, and textboxes
			radioButtonNoSize.Checked = true;
			radioButtonFruitJuice.Checked = true;
			checkBoxVitaminPack.Checked = false;
			checkBoxEnergyBooster.Checked = false;
			checkBoxLadies.Checked = false;
			textBoxItemPrice.Clear();
			textBoxQuantity.Text = "1";
		}

		private decimal findExtrasPrice()
		{
			//Find price for add-ons
			decimal extras = 0m;

			if (checkBoxVitaminPack.Checked)
				extras += .5m;
			if (checkBoxEnergyBooster.Checked)
				extras += .5m;
			if (checkBoxLadies.Checked)
				extras += .5m;

			return extras;
		}

		private void checkBoxVitaminPack_CheckedChanged(object sender, EventArgs e)
		{
			//Check price of add-ons and show current price
			//Handles all checkboxes

			drink = itemSize + findExtrasPrice();
			textBoxItemPrice.Text = drink.ToString("C");
		}

		private void fontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Change label font

			fontDialog1.Font = textBoxQuantity.Font;
			//Show dialog box
			fontDialog1.ShowDialog();

			textBoxQuantity.Font = fontDialog1.Font;
		}

		private void colorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Changes the form color
			//Applies to all the controls that aren't modified

			//Pull up dialog box
			colorDialog1.Color = this.ForeColor;

			//Show dialog box
			colorDialog1.ShowDialog();

			//Assign new color
			this.ForeColor = colorDialog1.Color;
		}

		private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Show summary information in a Message box
			Form2 aFormSummary = new Form2();
			aFormSummary.TotalSales = totalSales;
			aFormSummary.NumberOrders = orders;
			aFormSummary.DrinksSold = drinks;

			aFormSummary.ShowDialog();
		}
	}
}
