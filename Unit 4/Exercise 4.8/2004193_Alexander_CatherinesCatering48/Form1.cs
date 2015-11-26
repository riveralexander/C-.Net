using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_CatherinesCatering48
{
	public partial class Form1 : Form
	{
		//Declare global variables
		int numOfEvents;
		decimal totalAmount;
		decimal amountDue;
		const decimal PRIME_RIB = 25.95m;
		const decimal CHICKEN = 18.95m;
		const decimal PASTA = 12.95m;
		const decimal OPEN_BAR = 25.00m;
		const decimal WINE_WITH_DINNER = 8.00m;


		public Form1()
		{
			InitializeComponent();
		}

		private void buttonCalculate_Click(object sender, EventArgs e)
		{
			//Declare local variables
			int numOfGuests;

			try
			{
				numOfGuests = int.Parse(textBoxNumOfGuests.Text);
				if (radioButtonPrimeRib.Checked)
				{
					amountDue = numOfGuests * PRIME_RIB;
				}
				
				else if (radioButtonChicken.Checked)
				{
					amountDue = numOfGuests * CHICKEN;
				}
			
				else if (radioButtonPasta.Checked)
				{
					amountDue = numOfGuests * PASTA;
				}

				if (checkBoxOpenBar.Checked)
				{
					amountDue += numOfGuests * OPEN_BAR;
				}

				if (checkBoxWineWithDinner.Checked)
				{
					amountDue += numOfGuests + WINE_WITH_DINNER;
				}
				
				textBoxAmountDue.Text = amountDue.ToString("C");
				numOfEvents++;
				totalAmount += amountDue;
			}
			catch
			{
				MessageBox.Show("Invalid value", "Data Error");
				textBoxNumOfGuests.Focus();
				textBoxNumOfGuests.SelectAll();
			}

		}

		private void buttonSummary_Click(object sender, EventArgs e)
		{
			string summaryString = "Total events:	" + numOfEvents.ToString() + System.Environment.NewLine + "Total Sales		" + totalAmount.ToString("C");
			MessageBox.Show(summaryString, "Summary Information");
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			textBoxNumOfGuests.Clear();
			
			DialogResult responseDialogResult;
			string messageString = "Are you sure you want to clear the summary information?";
			responseDialogResult = MessageBox.Show(messageString, "Verify Summary Information Reset");

			if (responseDialogResult == DialogResult.Yes)
			{
				numOfEvents = 0;
				totalAmount = 0;
			}
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			//Exit program
			this.Close();
		}
	}
}
