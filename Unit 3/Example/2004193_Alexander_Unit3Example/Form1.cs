using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_Unit3Example
{
	public partial class Form1 : Form
	{
		//declare global variables
		int numberoOfItems = 0;
		decimal totalSales = 0.0m;
		const decimal DISCOUNT_RATE = .7m;
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonCalc_Click(object sender, EventArgs e)
		{
			//local variables
			int quantity;
			decimal price;
			decimal total;

			//get info from UI w/#'s, convert info from string to number type
			//try catch statement
			try
			{
				quantity = int.Parse(textBoxQuantity.Text);
				//nested try to see if price is wrong
				try
				{
					price = decimal.Parse(textBoxPrice.Text);

					//do calculation
					total = price * quantity;
					//display the result to UI
					//convert numeric value to string w/formatting ($)
					textBoxTotal.Text = total.ToString("C");

					//update global variables
					numberoOfItems++;		//numberOfItems = numberOfItems +1;
					totalSales += total;	//add the value of total to toalSales

					//display the results to UI
					textBoxNumberofItems.Text = numberoOfItems.ToString();
					textBoxTotalSales.Text = totalSales.ToString("C");


				} //end of nested try
				catch
				{
					MessageBox.Show("Price must have a numeric value.");
					textBoxPrice.SelectAll();
					textBoxPrice.Focus();
				}//end of nestd catch
			}//end of outer try
			catch
			{
				MessageBox.Show("Quantity must have a numeric value.");
				textBoxQuantity.SelectAll();
				textBoxQuantity.Focus();
			}//end of outer catch

		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			//Clear values from textboxes
			textBoxQuantity.Clear();
			textBoxPrice.Clear();
			textBoxTotal.Clear();
			textBoxNumberofItems.Clear();
			textBoxTotalSales.Clear();

			//reset global variables
			numberoOfItems = 0;
			totalSales = 0.0m;

		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void toolTip1_Popup(object sender, PopupEventArgs e)
		{
			toolTip1.SetToolTip(buttonClear, "Clears text and global variables");
		}
	}
}
