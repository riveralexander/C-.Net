using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_SportingGoodsStore23
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonDisplayLabelInfo_Click(object sender, EventArgs e)
		{
			richTextBoxMailingLabel.Text = textBoxFirstName.Text + " " + textBoxLastName.Text + System.Environment.NewLine + textBoxAddress1.Text + " " + textBoxAddress2.Text + System.Environment.NewLine + textBoxCity.Text + ", " + textBoxState.Text + ", " + maskedTextBoxPostalCode.Text; 
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			textBoxFirstName.Text = "";
			textBoxLastName.Text = "";
			textBoxAddress1.Text = "";
			textBoxAddress2.Text = "";
			textBoxCity.Text = "";
			textBoxState.Text = "";
			maskedTextBoxPostalCode.Text = "";
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

		private void toolTip1_Popup(object sender, PopupEventArgs e)
		{
			toolTip1.SetToolTip(buttonDisplayLabelInfo, "Put into mailing label");
			toolTip1.SetToolTip(buttonClear, "Clear shipping information");
			toolTip1.SetToolTip(buttonPrint, "Print this program");
			toolTip1.SetToolTip(buttonExit, "Exit program");
		}

	}
}
