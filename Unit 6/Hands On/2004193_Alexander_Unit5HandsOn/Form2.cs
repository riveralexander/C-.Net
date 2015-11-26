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
	public partial class Form2 : Form
	{	
		public decimal totalSalesDecimal;
		public int numberOrdersInteger, drinksSoldInteger;
		
		public Form2()
		{
			InitializeComponent();
		}
		public decimal TotalSales
		{
			set
			{
				totalSalesDecimal = value;
			}
		}
		public int NumberOrders
		{
			set
			{
				numberOrdersInteger = value;
			}
		}
		public int DrinksSold
		{
			set
			{
				drinksSoldInteger = value;
			}
		}
		private void buttonOK_Click(object sender, EventArgs e)
		{
		// Close the summary form.
		this.Close();
		}
		private void SummaryForm_Activated(object sender, EventArgs e)
		{
		// Get and display the summary data.
		textBoxDrinksSold.Text = drinksSoldInteger.ToString();
		textBoxNumOfOrders.Text = numberOrdersInteger.ToString();
		textBoxTotalSales.Text = totalSalesDecimal.ToString("C");
		}

	}
}
