using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_CoolBoards
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			labelDisplayDescription.Text = "";
		}

		private void buttonDowntown_Click(object sender, EventArgs e)
		{
			labelDisplayDescription.Text = "1234 NE Union St., Seattle, WA 9:00 am - 9:00 pm";
		}

		private void buttonMall_Click(object sender, EventArgs e)
		{
			labelDisplayDescription.Text = "5678 NE 102th St., Bellevue, WA 10:00 am - 8:00 pm";
		}

		private void buttonSuburbs_Click(object sender, EventArgs e)
		{
			labelDisplayDescription.Text = "9102 NE 145th St., Kenmore, WA 10:00 am - 6:00 pm";
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
