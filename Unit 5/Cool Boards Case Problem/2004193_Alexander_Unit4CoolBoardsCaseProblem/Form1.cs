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
			calculateShirts();
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

		private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string summaryString = "Number of shirts:	" + numOfShirts.ToString() + "\n Number of orders:		" + numOfOrders.ToString() + "\n Total Sales:	" + totalSales.ToString("C");
			MessageBox.Show(summaryString, "Summary Information");
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void addToOrderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			calculateShirts();
		}

		private void clearThisItemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBoxQuantity.Clear();
			textBoxPrice.Clear();
		}

		private void orderCompleteToolStripMenuItem_Click(object sender, EventArgs e)
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

		private void fontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Change label font

			//Show dialog box
			fontDialog1.ShowDialog();
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

		private void sloganToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (sloganToolStripMenuItem.Checked)
			{
				labelSlogan.Enabled = true;
			}
			else
			{
				labelSlogan.Enabled = false;
			}
		}

		private void logoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (logoToolStripMenuItem.Checked)
			{
				pictureBox1.Enabled = true;
				labelLogo.Enabled = true;
			}
			else
			{
				pictureBox1.Enabled = false;
				labelLogo.Enabled = false;
			}
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Programmer:	River Alexander\n\nVersion 1.1", "About");
		}
		private void calculateShirts()
		{
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
	}
}
