using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_ProgrammingExercise54
{
	public partial class Form1 : Form
	{
		//Declare global variables
		int numOfBooks;
		int points;
		int numOfReaders;
		int averageNumOfBooksRead;
		
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonCalculate_Click(object sender, EventArgs e)
		{
			calculatePoints();
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			clearForAll();
		}

		private void buttonSummary_Click(object sender, EventArgs e)
		{
			summaryInformation();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pointsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			calculatePoints();
		}

		private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			summaryInformation();
		}

		private void printToolStripMenuItem_Click(object sender, EventArgs e)
		{
			printToPreview();
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
			MessageBox.Show("Programmer:	River Alexander\n\nVersion 1.1", "About");
		}

		private void printToPreview()
		{ 
			printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
			printForm1.Print();
		}
		
		private void clearForAll()
		{
			textBoxName.Clear();
			textBoxBooks.Clear();
			textBoxPoints.Clear();
			points = 0;
			numOfBooks = 0;
		}

		private void calculatePoints()
		{
			points = 0;
			try
			{
				numOfBooks = int.Parse(textBoxBooks.Text);

				if (numOfBooks <= 3)
				{
					points = numOfBooks * 10;
				}
				if (numOfBooks > 3 && numOfBooks <= 6)
				{
					points = 30;
					points += (numOfBooks - 3) * 15;
				}
				if (numOfBooks > 6)
				{
					points = 75;
					points += (numOfBooks - 6) * 20;
				}
			}
			catch
			{
				MessageBox.Show("Invalid Books Read value", "Data Error");
				textBoxBooks.Focus();
				textBoxBooks.SelectAll();
			}
			numOfReaders++;

			textBoxPoints.Text = points.ToString();
		}

		private void summaryInformation()
		{ 
			averageNumOfBooksRead = numOfBooks / numOfReaders;
			string summaryString = "Average # of books read:	" + averageNumOfBooksRead.ToString();
			MessageBox.Show(summaryString, "Summary Information");
		}
	}
}
