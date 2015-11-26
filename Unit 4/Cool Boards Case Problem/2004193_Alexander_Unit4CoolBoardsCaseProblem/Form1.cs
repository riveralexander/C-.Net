using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_Unit4CoolBoardsCaseProblem
{
	public partial class Form1 : Form
	{
		//Declare global variables
		const int S_M_L = 10;
		const int EXTRA_LARGE = 11;
		const int XXL = 12;
		const int MONOGRAM = 2;
		const int POCKET = 1;
		decimal price;
		decimal totalPrice;
		decimal totalSales;
		int numOfShirts;
		int numOfOrders;
		

		public Form1()
		{
			InitializeComponent();
		}

		private void buttonAddOrder_Click(object sender, EventArgs e)
		{
			//Declare local variables
			int quantity;

			try
			{
				quantity = int.Parse(textBoxQuantity.Text);

				if (radioButtonSmall.Checked || radioButtonMedium.Checked || radioButtonLarge.Checked)
				{
					price = quantity * S_M_L;
					numOfShirts++;
				}
				else if (radioButtonExtraLarge.Checked)
				{
					price = quantity * EXTRA_LARGE;
					numOfShirts++;
				}
				else if (radioButtonXXL.Checked)
				{
					price = quantity * XXL;
					numOfShirts++;
				}

				if (checkBoxMonogram.Checked)
				{
					price += MONOGRAM;
				}
				if (checkBoxPocket.Checked)
				{
					price += POCKET;
				}
			}
			catch
			{
				MessageBox.Show("Invalid quantity value", "Data Error");
				textBoxQuantity.Focus();
				textBoxQuantity.SelectAll();
			}

			totalPrice += price;

			totalSales += totalPrice;

			textBoxPrice.Text = price.ToString("C");
			textBoxTotal.Text = totalPrice.ToString("C");

			buttonSummary.Enabled = false;

			numOfOrders++;
		}

		private void buttonClearItem_Click(object sender, EventArgs e)
		{
			textBoxQuantity.Clear();
			textBoxPrice.Clear();
		}

		private void buttonOrderComplete_Click(object sender, EventArgs e)
		{
			buttonSummary.Enabled = true;

			DialogResult responseDialogResult;
			string messageString = "Comfirm order?" + "\n Subtotal:	" + totalPrice.ToString("C");
			responseDialogResult = MessageBox.Show(messageString, "Confirm Order");

			if (responseDialogResult == DialogResult.Yes)
			{
				textBoxName.Clear();
				textBoxOrderNumber.Clear();
				textBoxQuantity.Clear();
				textBoxPrice.Clear();
				price = 0;
				totalPrice = 0;
			}
		}

		private void buttonSummary_Click(object sender, EventArgs e)
		{
			string summaryString = "Number of shirts:	" + numOfShirts.ToString() + "\n Number of orders:		" + numOfOrders.ToString() + "\n Total Sales:	" + totalSales.ToString("C");
			MessageBox.Show(summaryString, "Summary Information");
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
