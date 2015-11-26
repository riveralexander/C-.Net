using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_RecordingStudio32
{
	public partial class Form1 : Form
	{
		//Declare global variables
		int numOfGroups;
		int totalCost;
		int averageCost;
		const int RENTAL_RATE = 200;

		public Form1()
		{
			InitializeComponent();
		}

		private void buttonCalculate_Click(object sender, EventArgs e)
		{
			//Declare variables
			int minutes;
			int costOfRent;

			try
			{
				//Converts to integer
				minutes = int.Parse(textBoxTimeUsed.Text);

				costOfRent = minutes * RENTAL_RATE / 60;
				textBoxTotalSales.Text = costOfRent.ToString("C");
				numOfGroups++;
				
				//update number of groups
				textBoxNumberOfGroups.Text = numOfGroups.ToString();

				//add cost to total
				totalCost += costOfRent;
				textBoxTotalSales.Text = totalCost.ToString("C");
				
				//find the average cost
				averageCost = totalCost / numOfGroups;
				textBoxAverageCharge.Text = averageCost.ToString("C");

				textBoxAmountDue.Text = costOfRent.ToString("C");

			}
			catch
			{
				MessageBox.Show("Invalid time used value", "Data Error");
				textBoxTimeUsed.Focus();
				textBoxTimeUsed.SelectAll();
			}
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			//Clear the Music Group textboxes
			textBoxGroupName.Clear();
			textBoxTimeUsed.Clear();
		}

		private void buttonPrint_Click(object sender, EventArgs e)
		{
			//Print to preview
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
