using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_HYandsOnUnit1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonClothing_Click(object sender, EventArgs e)
		{
			labelPromotions.Text = "Take an extra 30% off the clearance items.";
		}

		private void buttonEquipment_Click(object sender, EventArgs e)
		{
			labelPromotions.Text = "Yoga mats---25% off.";
		}

		private void buttonJuiceBar_Click(object sender, EventArgs e)
		{
			labelPromotions.Text = "Try a free serving of our new WheatBerry Shake.";
		}

		private void buttonMembership_Click(object sender, EventArgs e)
		{
			labelPromotions.Text = "First month personal training included.";
		}

		private void buttonPersonalTraining_Click(object sender, EventArgs e)
		{
			labelPromotions.Text = "3 free sessions with membership renewal.";
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
