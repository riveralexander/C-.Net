using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_Unit3XtremeCinemaCaseStudy
{
	public partial class Form1 : Form
	{
		//Declare global variables
		const decimal MOVIE_RENTAL = 4.50m;
		const decimal DISCOUNT = 0.10m;
		int numOfCustomers;
		decimal totalSales;

		public Form1()
		{
			InitializeComponent();
		}

		private void buttonCalculate_Click(object sender, EventArgs e)
		{
			//Declare local variables
			int numOfMovies;
			decimal rentalAmount;
			decimal discount;
			decimal amountDue;

			try
			{
				//Convert to integer
				numOfMovies = int.Parse(textBoxNumOfMovies.Text);

				//Calculations
				rentalAmount = numOfMovies * MOVIE_RENTAL;
				discount = rentalAmount * DISCOUNT;
				amountDue = rentalAmount - discount;
				numOfCustomers++;
				totalSales += amountDue;

				//Assign variables to textboxes
				textBoxRentalAmount.Text = rentalAmount.ToString("C");
				textBoxDiscount.Text = discount.ToString("C");
				textBoxAmountDue.Text = amountDue.ToString("C");
				textBoxNumOfCustomers.Text = numOfCustomers.ToString();
				textBoxTotalSales.Text = totalSales.ToString("C");
			}
			catch
			{
				MessageBox.Show("Invalid value", "Data Error");
				textBoxNumOfMovies.Focus();
				textBoxNumOfMovies.SelectAll();
			}
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			textBoxMemberID.Clear();
			textBoxNumOfMovies.Clear();
			textBoxRentalAmount.Clear();
			textBoxDiscount.Clear();
			textBoxAmountDue.Clear();
		}

		private void buttonPrint_Click(object sender, EventArgs e)
		{
			printForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
			printForm.Print();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			//Close Program
			this.Close();
		}
	}
}
