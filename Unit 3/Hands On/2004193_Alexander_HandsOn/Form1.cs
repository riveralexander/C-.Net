using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_HandsOn
{
	public partial class Form1 : Form
	{
		//Declare constant & summary variables
		private const decimal DISCOUNT_RATE_Decimal = 0.3m;
		private decimal totalAmount;
		private int numberTransactions;

		public Form1()
		{
			InitializeComponent();
		}

		private void toolTip_Popup(object sender, PopupEventArgs e)
		{
			toolTip.SetToolTip(buttonCalculate, "Calculate values");
			toolTip.SetToolTip(buttonClear, "Clear local and global values");
			toolTip.SetToolTip(buttonExit, "Exit program");
		}

		private void buttonCalculate_Click(object sender, EventArgs e)
		{
			//Declare variables
			int quantity;
			decimal price, extendedPrice, discount, amountDue;

			try
			{
				//Convert values to numeric values & assin to variables
				quantity = int.Parse(textBoxQuantity.Text);

				try
				{
					price = decimal.Parse(textBoxPrice.Text);

					//Calculate
					extendedPrice = quantity * price;
					discount = Decimal.Round((extendedPrice * DISCOUNT_RATE_Decimal), 20);
					amountDue = extendedPrice - discount;
					totalAmount += amountDue;
					numberTransactions++;

					//Format & display answers
					textBoxExtendedPrice.Text = extendedPrice.ToString("C");
					textBoxDiscount.Text = discount.ToString("N");
					textBoxAmount.Text = amountDue.ToString("C");

					//Format & display summary info
					textBoxTotalAmount.Text = totalAmount.ToString("C");
					textBoxNumberTransactions.Text = numberTransactions.ToString();
				}//end of nested try
				catch
				{ 
					//Invalid price		
					MessageBox.Show("Invalid price", "Data Error");
					textBoxPrice.Focus();
					textBoxPrice.SelectAll();
				}//end of nested catch
			}//end of outer try
			catch
			{
				MessageBox.Show("Invalid quantity", "Data Error");
				textBoxQuantity.Focus();
				textBoxQuantity.SelectAll();
			}//end of outer catch
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			//Clear textboxes
			textBoxQuantity.Clear();
			textBoxPrice.Clear();
			textBoxDiscount.Clear();
			textBoxExtendedPrice.Clear();
			textBoxAmount.Clear();
			textBoxQuantity.Focus();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
