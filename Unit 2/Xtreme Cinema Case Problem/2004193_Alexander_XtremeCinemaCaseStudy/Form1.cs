using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_XtremeCinemaCaseStudy
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			labelAisle.Text = "";
		}

		private void radioButtonComedy_CheckedChanged(object sender, EventArgs e)
		{
			labelAisle.Text = "Aisle 1";
		}

		private void radioButtonDrama_CheckedChanged(object sender, EventArgs e)
		{
			labelAisle.Text = "Aisle 2";
		}

		private void radioButtonAction_CheckedChanged(object sender, EventArgs e)
		{
			labelAisle.Text = "Aisle 3";
		}

		private void radioButtonSciFi_CheckedChanged(object sender, EventArgs e)
		{
			labelAisle.Text = "Aisle 4";
		}

		private void radioButtonHorror_CheckedChanged(object sender, EventArgs e)
		{
			labelAisle.Text = "Aisle 5";
		}

		private void radioButtonNewReleases_CheckedChanged(object sender, EventArgs e)
		{
			labelAisle.Text = "Back wall";
		}

		private void checkBoxMembersOnly_CheckedChanged(object sender, EventArgs e)
		{
			labelMembers.Visible = checkBoxMembersOnly.Checked;
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			labelAisle.Text = "";
			labelMembers.Text = "";
		}

		private void buttonPrint_Click(object sender, EventArgs e)
		{
			printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
			printForm1.Print();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
