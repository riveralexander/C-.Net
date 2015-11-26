using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_LookSharpFitnessCenter225
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonSignIn_Click(object sender, EventArgs e)
		{
			richTextBoxWelcome.Text = "Welcome Member #" + maskedTextBoxMemberID.Text + Environment.NewLine + textBoxName.Text;
			//Visibility properties
			labelMemberID.Visible = false;
			maskedTextBoxMemberID.Visible = false;
			labelName.Visible = false;
			textBoxName.Visible = false;
			richTextBoxWelcome.Visible = true;
			textBoxPromotions.Visible = true;
			checkBoxImageVisible.Visible = true;
			pictureBoxDepartment.Visible = true;

			groupBoxDepartment.Enabled = true;
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

		private void radioButtonClothing_CheckedChanged(object sender, EventArgs e)
		{
			pictureBoxDepartment.Image = Properties.Resources.c;
			textBoxPromotions.Text = "30% off clearance items!";
		}

		private void radioButtonEquipment_CheckedChanged(object sender, EventArgs e)
		{
			pictureBoxDepartment.Image = Properties.Resources.ea;
			textBoxPromotions.Text = "25% off all equipment!";
		}

		private void radioButtonJuiceBar_CheckedChanged(object sender, EventArgs e)
		{
			pictureBoxDepartment.Image = Properties.Resources.jb;
			textBoxPromotions.Text = "Free serving of WheatBerry Shake.";
		}

		private void radioButtonMembership_CheckedChanged(object sender, EventArgs e)
		{
			pictureBoxDepartment.Image = Properties.Resources.m;
			textBoxPromotions.Text = "Free Personal Trainer for 1st month!";
		}

		private void radioButtonPersonalTraining_CheckedChanged(object sender, EventArgs e)
		{
			pictureBoxDepartment.Image = Properties.Resources.pt;
			textBoxPromotions.Text = "3 free sessions with membership renewal.";
		}

		private void checkBoxImageVisible_CheckedChanged(object sender, EventArgs e)
		{
			pictureBoxDepartment.Visible = checkBoxImageVisible.Checked;
		}

	}
}
