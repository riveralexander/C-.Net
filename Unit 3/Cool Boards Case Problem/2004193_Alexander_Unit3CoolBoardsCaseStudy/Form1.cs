using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_Unit3CoolBoardsCaseStudy
{
	public partial class Form1 : Form
	{
		const int SNOWBOARD_RENTAL_RATE = 20;
		const int SNOWBOARD_WITH_BOOTS_RENTAL_RATE = 30;
		int totalNumOfSnowboards;
		int totalNumOfSnowboardsWithBoots;
		decimal totalSales;
		decimal averageSales;

		public Form1()
		{
			InitializeComponent();
		}

		private void buttonCaclulate_Click(object sender, EventArgs e)
		{
			int numOfSnowboards;
			int numOfSnowboardWithBoots;
			decimal amountDue;

			try
			{
				numOfSnowboards = int.Parse(textBoxNumOfSnowboards.Text);
				try
				{
					numOfSnowboardWithBoots = int.Parse(textBoxNumOfSnowboardsWithBoots.Text);
					//totalNumOfSnowboards = int.Parse(textBoxTotalNumOfSnowboards.Text);
					//totalNumOfSnowboardsWithBoots = int.Parse(textBoxTotalNumOfSnowboardsWithBoots.Text);

					//Calculations
					amountDue = numOfSnowboards * SNOWBOARD_RENTAL_RATE + numOfSnowboardWithBoots * SNOWBOARD_WITH_BOOTS_RENTAL_RATE;
					totalNumOfSnowboards += numOfSnowboards;
					totalNumOfSnowboardsWithBoots += numOfSnowboardWithBoots;
					totalSales = amountDue;
					totalSales++;
					averageSales = totalSales / numOfSnowboards + numOfSnowboardWithBoots;

					//assign variables to textboxes
					textBoxNumOfSnowboards.Text = numOfSnowboards.ToString();
					textBoxNumOfSnowboardsWithBoots.Text = numOfSnowboardWithBoots.ToString();
					textBoxAmountDue.Text = amountDue.ToString("C");
					textBoxTotalNumOfSnowboards.Text = totalNumOfSnowboards.ToString();
					textBoxTotalNumOfSnowboardsWithBoots.Text = totalNumOfSnowboardsWithBoots.ToString();
					textBoxTotalSales.Text = totalSales.ToString("C");
					textBoxAverageSales.Text = averageSales.ToString("C");
				} //nested try
				catch
				{
					MessageBox.Show("Invalid value", "Data Error");
					textBoxNumOfSnowboardsWithBoots.Focus();
					textBoxNumOfSnowboardsWithBoots.SelectAll();
				} //nested catch
			} //outer try
			catch
			{
				MessageBox.Show("Invalid value", "Data Error");
				textBoxNumOfSnowboards.Focus();
				textBoxNumOfSnowboards.SelectAll();
			} //outer catch
		}

		private void buttonClearAll_Click(object sender, EventArgs e)
		{
			textBoxName.Clear();
			textBoxIDNumber.Clear();
			textBoxNumOfSnowboards.Clear();
			textBoxNumOfSnowboardsWithBoots.Clear();
			textBoxAmountDue.Clear();
			textBoxTotalNumOfSnowboards.Clear();
			textBoxTotalNumOfSnowboardsWithBoots.Clear();
			textBoxTotalSales.Clear();
			textBoxAverageSales.Clear();
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			textBoxName.Clear();
			textBoxIDNumber.Clear();
			textBoxNumOfSnowboards.Clear();
			textBoxNumOfSnowboardsWithBoots.Clear();
			textBoxAmountDue.Clear();
		}

		private void buttonPrint_Click(object sender, EventArgs e)
		{
			printForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
			printForm.Print();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
