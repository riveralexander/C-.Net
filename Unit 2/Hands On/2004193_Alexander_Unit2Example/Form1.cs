using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_Unit2Example
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
		{
			//CheckedChanged is the default event for a radio button
			this.BackColor = Color.Red;		
		}

		private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
		{
			this.BackColor = Color.Green;
		}

		private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
		{
			this.BackColor = Color.Blue;
		}

		private void radioButtonSpades_CheckedChanged(object sender, EventArgs e)
		{
			pictureBoxSelectCard.Image = Properties.Resources._as;
		}

		private void radioButtonHearts_CheckedChanged(object sender, EventArgs e)
		{
			pictureBoxSelectCard.Image = Properties.Resources.ah;
		}

		private void radioButtonDiamonds_CheckedChanged(object sender, EventArgs e)
		{
			pictureBoxSelectCard.Image = Properties.Resources.ad;
		}

		private void radioButtonClubs_CheckedChanged(object sender, EventArgs e)
		{
			pictureBoxSelectCard.Image = Properties.Resources.ac;
		}

		private void radioButtonWhite_CheckedChanged(object sender, EventArgs e)
		{
			this.BackColor = Color.WhiteSmoke;
		}

		private void checkBoxShowImage_CheckedChanged(object sender, EventArgs e)
		{
			pictureBoxSelectCard.Visible = checkBoxShowImage.Checked;
		}

		private void pictureBoxSelectCard_Click(object sender, EventArgs e)
		{

		}
	}
}
