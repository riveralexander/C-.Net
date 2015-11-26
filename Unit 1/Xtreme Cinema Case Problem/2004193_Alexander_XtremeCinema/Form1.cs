using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_XtremeCinema
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			labelAisle.Text = "";
		}

		private void buttonComedy_Click(object sender, EventArgs e)
		{
			labelAisle.Text = "Aisle 1";
		}

		private void buttonDrama_Click(object sender, EventArgs e)
		{
			labelAisle.Text = "Aisle 2";
		}

		private void buttonAction_Click(object sender, EventArgs e)
		{
			labelAisle.Text = "Aisle 3";
		}

		private void buttonSciFi_Click(object sender, EventArgs e)
		{
			labelAisle.Text = "Aisle 4";
		}

		private void buttonHorror_Click(object sender, EventArgs e)
		{
			labelAisle.Text = "Aisle 5";
		}

		private void buttonNewReleases_Click(object sender, EventArgs e)
		{
			labelAisle.Text = "Back Wall";
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
