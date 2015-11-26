namespace _2004193_Alexander_Unit3Example
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.labelQuantity = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.labelTotal = new System.Windows.Forms.Label();
			this.labelNumberofItems = new System.Windows.Forms.Label();
			this.labelTotalSales = new System.Windows.Forms.Label();
			this.textBoxQuantity = new System.Windows.Forms.TextBox();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.textBoxTotal = new System.Windows.Forms.TextBox();
			this.textBoxNumberofItems = new System.Windows.Forms.TextBox();
			this.textBoxTotalSales = new System.Windows.Forms.TextBox();
			this.buttonCalc = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.labelProgrammer = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.checkBoxDiscount = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// labelQuantity
			// 
			this.labelQuantity.AutoSize = true;
			this.labelQuantity.Location = new System.Drawing.Point(12, 54);
			this.labelQuantity.Name = "labelQuantity";
			this.labelQuantity.Size = new System.Drawing.Size(46, 13);
			this.labelQuantity.TabIndex = 0;
			this.labelQuantity.Text = "Quantity";
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Location = new System.Drawing.Point(12, 86);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(31, 13);
			this.labelPrice.TabIndex = 1;
			this.labelPrice.Text = "Price";
			// 
			// labelTotal
			// 
			this.labelTotal.AutoSize = true;
			this.labelTotal.Location = new System.Drawing.Point(12, 118);
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.Size = new System.Drawing.Size(31, 13);
			this.labelTotal.TabIndex = 2;
			this.labelTotal.Text = "Total";
			// 
			// labelNumberofItems
			// 
			this.labelNumberofItems.AutoSize = true;
			this.labelNumberofItems.Location = new System.Drawing.Point(12, 279);
			this.labelNumberofItems.Name = "labelNumberofItems";
			this.labelNumberofItems.Size = new System.Drawing.Size(84, 13);
			this.labelNumberofItems.TabIndex = 3;
			this.labelNumberofItems.Text = "Number of Items";
			// 
			// labelTotalSales
			// 
			this.labelTotalSales.AutoSize = true;
			this.labelTotalSales.Location = new System.Drawing.Point(12, 333);
			this.labelTotalSales.Name = "labelTotalSales";
			this.labelTotalSales.Size = new System.Drawing.Size(60, 13);
			this.labelTotalSales.TabIndex = 4;
			this.labelTotalSales.Text = "Total Sales";
			// 
			// textBoxQuantity
			// 
			this.textBoxQuantity.Location = new System.Drawing.Point(101, 51);
			this.textBoxQuantity.Name = "textBoxQuantity";
			this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
			this.textBoxQuantity.TabIndex = 5;
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(101, 83);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
			this.textBoxPrice.TabIndex = 6;
			// 
			// textBoxTotal
			// 
			this.textBoxTotal.Location = new System.Drawing.Point(101, 115);
			this.textBoxTotal.Name = "textBoxTotal";
			this.textBoxTotal.ReadOnly = true;
			this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
			this.textBoxTotal.TabIndex = 7;
			// 
			// textBoxNumberofItems
			// 
			this.textBoxNumberofItems.Location = new System.Drawing.Point(101, 276);
			this.textBoxNumberofItems.Name = "textBoxNumberofItems";
			this.textBoxNumberofItems.Size = new System.Drawing.Size(100, 20);
			this.textBoxNumberofItems.TabIndex = 8;
			// 
			// textBoxTotalSales
			// 
			this.textBoxTotalSales.Location = new System.Drawing.Point(101, 330);
			this.textBoxTotalSales.Name = "textBoxTotalSales";
			this.textBoxTotalSales.ReadOnly = true;
			this.textBoxTotalSales.Size = new System.Drawing.Size(100, 20);
			this.textBoxTotalSales.TabIndex = 9;
			// 
			// buttonCalc
			// 
			this.buttonCalc.Location = new System.Drawing.Point(238, 88);
			this.buttonCalc.Name = "buttonCalc";
			this.buttonCalc.Size = new System.Drawing.Size(75, 23);
			this.buttonCalc.TabIndex = 10;
			this.buttonCalc.Text = "Calculate";
			this.buttonCalc.UseVisualStyleBackColor = true;
			this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(238, 118);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 23);
			this.buttonClear.TabIndex = 11;
			this.buttonClear.Text = "&Clear";
			this.toolTip1.SetToolTip(this.buttonClear, " ");
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonExit.Location = new System.Drawing.Point(241, 352);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 12;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// labelProgrammer
			// 
			this.labelProgrammer.AutoSize = true;
			this.labelProgrammer.Location = new System.Drawing.Point(158, 388);
			this.labelProgrammer.Name = "labelProgrammer";
			this.labelProgrammer.Size = new System.Drawing.Size(158, 13);
			this.labelProgrammer.TabIndex = 13;
			this.labelProgrammer.Text = "Programmed by River Alexander";
			// 
			// toolTip1
			// 
			this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
			// Form1
			// 
			this.AcceptButton = this.buttonCalc;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonExit;
			this.ClientSize = new System.Drawing.Size(328, 410);
			this.Controls.Add(this.checkBoxDiscount);
			this.Controls.Add(this.labelProgrammer);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonCalc);
			this.Controls.Add(this.textBoxTotalSales);
			this.Controls.Add(this.textBoxNumberofItems);
			this.Controls.Add(this.textBoxTotal);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.textBoxQuantity);
			this.Controls.Add(this.labelTotalSales);
			this.Controls.Add(this.labelNumberofItems);
			this.Controls.Add(this.labelTotal);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelQuantity);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelQuantity;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label labelTotal;
		private System.Windows.Forms.Label labelNumberofItems;
		private System.Windows.Forms.Label labelTotalSales;
		private System.Windows.Forms.TextBox textBoxQuantity;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.TextBox textBoxTotal;
		private System.Windows.Forms.TextBox textBoxNumberofItems;
		private System.Windows.Forms.TextBox textBoxTotalSales;
		private System.Windows.Forms.Button buttonCalc;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Label labelProgrammer;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.CheckBox checkBoxDiscount;
	}
}

