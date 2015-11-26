using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_Exercise_44_45_46
{
	public partial class Form1 : Form
	{
		// Declare global variables
		int totalNumOfDeposits;
		int totalNumOfChecks;
		decimal totalDeposited;
		decimal totalWithdrawn;
		decimal amount;
		decimal balance = 500;

		public Form1()
		{
			InitializeComponent();
		}

		private void buttonCaclulate_Click(object sender, EventArgs e)
		{
			//Declare local variables

			try
			{
				//Convert to integer
				amount = decimal.Parse(textBoxAmount.Text);
			}
			catch
			{
				MessageBox.Show("Invalid value", "Data Error");
				textBoxAmount.Focus();
				textBoxAmount.SelectAll();
			}

			if (radioButtonDeposit.Checked)
			{
				balance += amount;
				totalDeposited += amount;
				totalNumOfDeposits++;
			}

			if (radioButtonCheck.Checked)
			{
				if (amount <= balance)
				{
					balance -= amount;
					totalWithdrawn += amount;
					totalNumOfChecks++;
				}
				
				else
				{
					MessageBox.Show("Insufficient Funds.", "Insufficient Funds");
					balance = balance - 10;
					totalWithdrawn += 10;
				}
			}

			textBoxBalance.Text = balance.ToString("C");
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			//Clear textboxes
			textBoxAmount.Clear();
			textBoxBalance.Clear();
			textBoxTotalNumOfDeposits.Clear();
			textBoxTotalDeposited.Clear();
			textBoxTotalNumOfChecks.Clear();
			textBoxTotalWithdrawn.Clear();
		}

		private void buttonPrint_Click(object sender, EventArgs e)
		{
			//Print to preview
			printForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
			printForm.Print();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			//Exit program
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBoxTotalNumOfDeposits.Text = totalNumOfDeposits.ToString();
			textBoxTotalDeposited.Text = totalDeposited.ToString("C");
			textBoxTotalNumOfChecks.Text = totalNumOfChecks.ToString();
			textBoxTotalWithdrawn.Text = totalWithdrawn.ToString("C");
		}
	}
}
