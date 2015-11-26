using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_EmployeeSales36
{
	public partial class Form1 : Form
	{
		//Declare global variables
		const decimal COMMISSION = 0.06m;
		const decimal DEDUCTION = 0.18m;
		const decimal HOUSING = .30m;
		const decimal FOOD_AND_CLOTHING = 0.15m;
		const decimal ENTERTAINMENT = 0.50m;
		const decimal MISCELLANEOUS = 0.05m;

		public Form1()
		{
			InitializeComponent();
		}

		private void buttonCalculate_Click(object sender, EventArgs e)
		{
			//Declare variables
			int grossPay = 900;
			decimal sales;
			decimal commission;
			decimal deduction;
			decimal netPay;
			decimal housing;
			decimal foodAndClothes;
			decimal entertainment;
			decimal miscellaneous;
			

			try
			{
				//Convert to integer
				sales = decimal.Parse(textBoxEmployeeSales.Text);

				//Calculations
				commission = sales * COMMISSION;
				deduction = grossPay * DEDUCTION;
				netPay = grossPay + commission - deduction;
				housing = HOUSING * netPay;
				foodAndClothes = FOOD_AND_CLOTHING * netPay;
				entertainment = ENTERTAINMENT * netPay;
				miscellaneous = MISCELLANEOUS * netPay;
				textBoxCommission.Text = commission.ToString("C");
				textBoxDeduction.Text = deduction.ToString("C");
				textBoxNetPay.Text = netPay.ToString("C");
				textBoxHousing.Text = housing.ToString("C");
				textBoxFoodAndClothing.Text = foodAndClothes.ToString("C");
				textBoxEntertainment.Text = entertainment.ToString("C");
				textBoxMiscellaneous.Text = miscellaneous.ToString("C");
			}
			catch
			{
				MessageBox.Show("Invalid value", "Data Error");
				textBoxEmployeeSales.Focus();
				textBoxEmployeeSales.SelectAll();
			}
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			//Clear employee textboxes
			textBoxEmployeeName.Clear();
			textBoxEmployeeSales.Clear();
			textBoxCommission.Clear();
			textBoxDeduction.Clear();
			textBoxNetPay.Clear();
			textBoxHousing.Clear();
			textBoxFoodAndClothing.Clear();
			textBoxEntertainment.Clear();
			textBoxMiscellaneous.Clear();
		}

		private void buttonPrint_Click(object sender, EventArgs e)
		{
			//Print to Preview
			printForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
			printForm.Print();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			//Close program
			this.Close();
		}
	}
}
