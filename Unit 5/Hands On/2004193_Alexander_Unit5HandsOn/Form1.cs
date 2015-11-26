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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void printToolStripMenuItem_Click(object sender, EventArgs e)
		{
			printForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
			printForm.Print();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string aboutString = "Programmer: River Alexander";
			MessageBox.Show(aboutString, "About");
		}
		}
	}
