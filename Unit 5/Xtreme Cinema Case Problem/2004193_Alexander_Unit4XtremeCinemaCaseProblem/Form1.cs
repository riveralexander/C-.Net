using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_Unit4XtremeCinemaCaseProblem
{
	public partial class Form1 : Form
	{
		//Declare global variable
		const decimal BD_RENT = 5.00m;
		const decimal DVD_RENT = 4.50m;
		const decimal NEW_RELEASE = 1.00m;
		const decimal MEMBER_DISCOUNT = 0.10m;
		int numOfCustomers;
		decimal totalSales;
		decimal amountDue;
		decimal subTotal;

		public Form1()
		{
			InitializeComponent();
		}

		private void buttonCalculate_Click(object sender, EventArgs e)
		{
			calculateRental();
		}

		private void buttonClearNext_Click(object sender, EventArgs e)
		{
			textBoxMovieTitle.Clear();
			textBoxAmountDue.Clear();
			checkBoxNewRelease.Checked = false;
			checkBoxMember.Enabled = false;
			
		}

		private void buttonOrderComplete_Click(object sender, EventArgs e)
		{
			DialogResult responseDialogResult;
			string messageString = "Comfirm order?" + System.Environment.NewLine + "Subtotal:	" + subTotal.ToString("C");
			responseDialogResult = MessageBox.Show(messageString, "Confirm Order");

			if (responseDialogResult == DialogResult.Yes)
			{
				textBoxMovieTitle.Clear();
				textBoxAmountDue.Clear();
				checkBoxNewRelease.Checked = false;
				checkBoxMember.Checked = false;
				amountDue = 0;
				subTotal = 0;
			}
		}

		private void buttonSummary_Click(object sender, EventArgs e)
		{
			string summaryString = "# of Customers:		" + numOfCustomers.ToString() + System.Environment.NewLine + "Total Sales:	" + totalSales.ToString("C");
			MessageBox.Show(summaryString, "Summary Information");
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void calculateRental()
		{
			int movieTitle;

			try
			{
				movieTitle = int.Parse(textBoxMovieTitle.Text);

				if (radioButtonDVD.Checked)
				{
					amountDue += DVD_RENT;
					totalSales += DVD_RENT;
				}
				else if (radioButtonBlueray.Checked)
				{
					amountDue += BD_RENT;
					totalSales += BD_RENT;
				}
				if (checkBoxNewRelease.Checked)
				{
					amountDue += NEW_RELEASE;
					totalSales += NEW_RELEASE;
				}
				if (checkBoxMember.Checked)
				{
					amountDue -= amountDue * MEMBER_DISCOUNT;
					totalSales -= amountDue * MEMBER_DISCOUNT;
				}

				textBoxAmountDue.Text = amountDue.ToString("C");
				subTotal += amountDue;
				numOfCustomers++;
			}

			catch
			{
				MessageBox.Show("Invalid movie quantity", "Data Error");
				textBoxMovieTitle.Focus();
				textBoxMovieTitle.SelectAll();
			}
		}

		private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string summaryString = "# of Customers:		" + numOfCustomers.ToString() + System.Environment.NewLine + "Total Sales:	" + totalSales.ToString("C");
			MessageBox.Show(summaryString, "Summary Information");
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			calculateRental();
		}

		private void clearForNextItemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBoxMovieTitle.Clear();
			textBoxAmountDue.Clear();
			checkBoxNewRelease.Checked = false;
			checkBoxMember.Enabled = false;
		}

		private void orderCompleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult responseDialogResult;
			string messageString = "Comfirm order?" + System.Environment.NewLine + "Subtotal:	" + subTotal.ToString("C");
			responseDialogResult = MessageBox.Show(messageString, "Confirm Order");

			if (responseDialogResult == DialogResult.Yes)
			{
				textBoxMovieTitle.Clear();
				textBoxAmountDue.Clear();
				checkBoxNewRelease.Checked = false;
				checkBoxMember.Checked = false;
				amountDue = 0;
				subTotal = 0;
			}
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

		private void fontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Change label font

			//Show dialog box
			fontDialog1.ShowDialog();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Programmer:	River Alexander\n\nVersion 1.1", "About");
		}
	}
}
