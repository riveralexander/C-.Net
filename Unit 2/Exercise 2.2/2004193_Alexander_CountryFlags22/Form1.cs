using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_CountryFlags22
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonPrint_Click(object sender, EventArgs e)
		{
			printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
			printForm1.Print();
		}

		private void radioButtonUSFlag_CheckedChanged(object sender, EventArgs e)
		{
			pictureBoxFlag.Image = Properties.Resources.us;
			labelFlagName.Text = "United States Flag";
		}

		private void radioButtonMexicoFlag_CheckedChanged(object sender, EventArgs e)
		{
			pictureBoxFlag.Image = Properties.Resources.mexico;
			labelFlagName.Text = "Mexico Flag";
		}

		private void radioButtonCanadaFlag_CheckedChanged(object sender, EventArgs e)
		{
			pictureBoxFlag.Image = Properties.Resources.canada;
			labelFlagName.Text = "Canada Flag";
		}

		private void radioButtonNorthKoreaFlag_CheckedChanged(object sender, EventArgs e)
		{
			pictureBoxFlag.Image = Properties.Resources.nk;
			labelFlagName.Text = "North Korea Flag";
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			label1.Visible = checkBoxHideProgrammed.Checked;
		}

		private void checkBoxHideFlagLabel_CheckedChanged(object sender, EventArgs e)
		{
			labelFlagName.Visible = checkBoxHideFlagLabel.Checked;
		}

		private void checkBoxHideTitle_CheckedChanged(object sender, EventArgs e)
		{
			labelCountries.Visible = checkBoxHideTitle.Checked;
		}
	}
}
