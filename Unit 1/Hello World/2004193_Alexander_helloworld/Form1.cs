using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004193_Alexander_helloworld
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			/*Assigning a string value to the text property of the object labelMessage
			 String values are always surrounded by double quotes*/
			labelMessage.Text = "Hello " + textBoxName.Text;
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			/*this is how to close an application
			use keyword 'this' refers to the main 'Form1'
			use the methods .Close()
			 All statements end with a ';' semi-colon*/
			this.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void buttonSpanish_Click(object sender, EventArgs e)
		{
			labelMessage.Text = "Hola " + textBoxName.Text;

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void textBoxName_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
