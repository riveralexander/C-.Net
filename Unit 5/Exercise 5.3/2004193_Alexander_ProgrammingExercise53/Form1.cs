using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_ProgrammingExercise53
{
	public partial class Form1 : Form
	{
		//Declare global variables
		const int BASE_PAY = 200;
		const decimal COMMISION = 0.15m;
		decimal weeklySales;
		decimal commissionDecimal;
		decimal payDecimal;
		decimal totalSales;
		decimal totalCommission;
		decimal totalPay;

		public Form1()
		{
			InitializeComponent();
		}

		private void payToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				weeklySales = decimal.Parse(textBoxSales.Text);

				calculateCommission();

				payDecimal = BASE_PAY + calculateCommission();

				totalSales += weeklySales;
				totalCommission += commissionDecimal;
				totalPay += payDecimal;

				textBoxCommission.Text = commissionDecimal.ToString("C");
				textBoxPay.Text = payDecimal.ToString("C");
			}
			catch
			{
				MessageBox.Show("Invalid Weekly Sales value.", "Data Error");
				textBoxSales.Focus();
				textBoxSales.SelectAll();
			}
		}

		private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void printToolStripMenuItem_Click(object sender, EventArgs e)
		{
			printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
			printForm1.Print();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			clearForAll();
		}

		private void fontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Change label font

			//Show dialog box
			fontDialog1.ShowDialog();
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

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string aboutString = "Programmer:	" + "River Alexander" + "\n\n" + "Version 1.1";
			MessageBox.Show(aboutString, "About");
		}

		private void buttonCalculate_Click(object sender, EventArgs e)
		{
			try
			{
				weeklySales = decimal.Parse(textBoxSales.Text);

				calculateCommission();

				payDecimal = BASE_PAY + calculateCommission();

				totalSales += weeklySales;
				totalCommission += commissionDecimal;
				totalPay += payDecimal;

				textBoxPay.Text = payDecimal.ToString("C");

				if (commissionDecimal <= 0)
				{
					textBoxCommission.Clear();
					textBoxCommission.Enabled = false;
				}
				else
				{
					textBoxCommission.Enabled = true;
					textBoxCommission.Text = commissionDecimal.ToString("C");
				}
			}
			catch
			{
				MessageBox.Show("Invalid Weekly Sales value.", "Data Error");
				textBoxSales.Focus();
				textBoxSales.SelectAll();
			}
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			clearForAll();
		}

		private void buttonSummary_Click(object sender, EventArgs e)
		{
			string summaryString = "Total Sales:	" + totalSales.ToString("C") + "\n\nTotal Commission:	" + totalCommission.ToString("C") + "\n\nTotal Pay:		" + totalPay.ToString("C");
			MessageBox.Show(summaryString, "Summary Information");
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private decimal calculateCommission()
		{
			if (weeklySales >= 1000)
			{
				commissionDecimal = weeklySales * COMMISION;
				
			}
			return commissionDecimal;
		}

		private void clearForAll()
		{
			textBoxName.Clear();
			textBoxSales.Clear();
			textBoxCommission.Clear();
			textBoxPay.Clear();
			commissionDecimal = 0.00m;
			payDecimal = 0.00m;
		}
	}
}
