using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_46
{
	public partial class Form1 : Form
	{
		//Declare global variables
		int totalPieces;
		int numOfPeople;
		decimal totalPay;
		decimal averagePay;
		decimal amountEarned;
		const decimal PIECES_COMPLETED_ONE = .50m;
		const decimal PIECES_COMPLETED_TWO = .55m;
		const decimal PIECES_COMPLETED_THREE = .60m;
		const decimal PIECES_COMPLETED_FOUR = .66m;


		public Form1()
		{
			InitializeComponent();
		}

		private void buttonCalculate_Click(object sender, EventArgs e)
		{
			//Declare local variables
			int piecesCompleted;

			try
			{
				//Converts input value to variable
				piecesCompleted = int.Parse(textBoxPiecesComplete.Text);

				//Increases number of people by one every time a person calculates
				numOfPeople++;

				//Calculations
				totalPieces += piecesCompleted;
				totalPay += amountEarned;
				averagePay = totalPay / numOfPeople;
				
				if (piecesCompleted <= 199)
				{
					amountEarned = piecesCompleted * PIECES_COMPLETED_ONE;
				}
				
				else if (piecesCompleted >= 200 && piecesCompleted <= 399)
				{
					amountEarned = piecesCompleted * PIECES_COMPLETED_TWO;
				}
				
				else if (piecesCompleted >= 400 && piecesCompleted <= 599)
				{
					amountEarned = piecesCompleted * PIECES_COMPLETED_THREE;
				}
				
				else if (piecesCompleted >= 600)
				{
					amountEarned = piecesCompleted * PIECES_COMPLETED_FOUR;
				}
				if (numOfPeople <= 1)
				{
					buttonSummary.Enabled = false;
				}
				else
				{
					buttonSummary.Enabled = true;
				}
			}
			catch
			{
				//Shows error message if pieces completed textbox has an invalid value
				MessageBox.Show("Invalid value", "Data Error");
				textBoxPiecesComplete.Focus();
				textBoxPiecesComplete.SelectAll();
			}

			//Converts variable to string
			textBoxAmount.Text = amountEarned.ToString("C");

		}

		private void buttonSummary_Click(object sender, EventArgs e)
		{
			//Show variables on Summary Information textboxes
			textBoxTotalPieces.Text = totalPieces.ToString();
			textBoxTotalPay.Text = totalPay.ToString("C");
			textBoxAveragePay.Text = averagePay.ToString("C");
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			//Clear textboxes
			textBoxName.Clear();
			textBoxPiecesComplete.Clear();
			textBoxAmount.Clear();
		}

		private void buttonClearAll_Click(object sender, EventArgs e)
		{
			//Clear global variables after confirming Message Box
				
				DialogResult responseDialogResult;
				string messageString = "Reset Summary Information?";
				responseDialogResult = MessageBox.Show(messageString,
				"Clear All",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);
				if (responseDialogResult == DialogResult.Yes)
				{
					totalPieces = 0;
					numOfPeople = 0;
					totalPay = 0;
					averagePay = 0;
					amountEarned = 0;
				}

			//Clear textboxes
			textBoxName.Clear();
			textBoxPiecesComplete.Clear();
			textBoxAmount.Clear();
			textBoxTotalPieces.Clear();
			textBoxTotalPay.Clear();
			textBoxAveragePay.Clear();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			//Close program
			this.Close();
		}
	}
}
