using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_BobsBurgers
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			labelDisplayDescription.Text = "";
		}

		private void buttonSoupoftheDay_Click(object sender, EventArgs e)
		{
			labelDisplayDescription.Text = "Today's soup of the day is Hamburger soup!";
		}

		private void buttonChefsSpecial_Click(object sender, EventArgs e)
		{
			labelDisplayDescription.Text = "The chef's special is Jelepeno Cheeseburger.";
		}

		private void buttonDailyFish_Click(object sender, EventArgs e)
		{
			labelDisplayDescription.Text = "Today's daily fish is Samon Cheeseburger.";
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
