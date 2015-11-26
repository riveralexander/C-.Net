using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_CoolBoardsCaseStudy
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
		{
			labelSlogan.ForeColor = Color.Red;
		}

		private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
		{
			labelSlogan.ForeColor = Color.Green;
		}

		private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
		{
			labelSlogan.ForeColor = Color.Blue;
		}

		private void checkBoxHideCompanyName_CheckedChanged(object sender, EventArgs e)
		{
			labelCompanyName.Visible = checkBoxHideCompanyName.Checked;
		}

		private void checkBoxHideSlogan_CheckedChanged(object sender, EventArgs e)
		{
			labelSlogan.Visible = checkBoxHideSlogan.Checked;
		}

		private void checkBoxHideLogo_CheckedChanged(object sender, EventArgs e)
		{
			pictureBoxSkateboard.Visible = checkBoxHideLogo.Checked;
		}

		private void buttonPrint_Click(object sender, EventArgs e)
		{
			printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
			printForm1.Print();
		}

		private void toolTip1_Popup(object sender, PopupEventArgs e)
		{
			toolTip1.SetToolTip(labelCompanyName, "Our company name");
			toolTip1.SetToolTip(labelSlogan, "Our slogan");
			toolTip1.SetToolTip(pictureBoxSkateboard, "Our logo");
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
