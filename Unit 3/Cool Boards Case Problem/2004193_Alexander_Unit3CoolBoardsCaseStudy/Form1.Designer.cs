namespace _2004193_Alexander_Unit3CoolBoardsCaseStudy
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxIDNumber = new System.Windows.Forms.TextBox();
			this.textBoxNumOfSnowboards = new System.Windows.Forms.TextBox();
			this.textBoxNumOfSnowboardsWithBoots = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxAmountDue = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBoxAverageSales = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxTotalSales = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxTotalNumOfSnowboardsWithBoots = new System.Windows.Forms.TextBox();
			this.textBoxTotalNumOfSnowboards = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.buttonCaclulate = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.printForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
			this.buttonClearAll = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "ID Number:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Number of Snowboards:";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(160, 17);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(100, 20);
			this.textBoxName.TabIndex = 3;
			// 
			// textBoxIDNumber
			// 
			this.textBoxIDNumber.Location = new System.Drawing.Point(208, 53);
			this.textBoxIDNumber.Name = "textBoxIDNumber";
			this.textBoxIDNumber.Size = new System.Drawing.Size(52, 20);
			this.textBoxIDNumber.TabIndex = 4;
			// 
			// textBoxNumOfSnowboards
			// 
			this.textBoxNumOfSnowboards.Location = new System.Drawing.Point(208, 89);
			this.textBoxNumOfSnowboards.Name = "textBoxNumOfSnowboards";
			this.textBoxNumOfSnowboards.Size = new System.Drawing.Size(52, 20);
			this.textBoxNumOfSnowboards.TabIndex = 5;
			// 
			// textBoxNumOfSnowboardsWithBoots
			// 
			this.textBoxNumOfSnowboardsWithBoots.Location = new System.Drawing.Point(208, 125);
			this.textBoxNumOfSnowboardsWithBoots.Name = "textBoxNumOfSnowboardsWithBoots";
			this.textBoxNumOfSnowboardsWithBoots.Size = new System.Drawing.Size(52, 20);
			this.textBoxNumOfSnowboardsWithBoots.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(167, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Number of Snowboards w/ Boots:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxAmountDue);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textBoxNumOfSnowboardsWithBoots);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBoxNumOfSnowboards);
			this.groupBox1.Controls.Add(this.textBoxIDNumber);
			this.groupBox1.Controls.Add(this.textBoxName);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(269, 199);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Checkout";
			// 
			// textBoxAmountDue
			// 
			this.textBoxAmountDue.Location = new System.Drawing.Point(208, 161);
			this.textBoxAmountDue.Name = "textBoxAmountDue";
			this.textBoxAmountDue.ReadOnly = true;
			this.textBoxAmountDue.Size = new System.Drawing.Size(52, 20);
			this.textBoxAmountDue.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 164);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Amount Due:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBoxAverageSales);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.textBoxTotalSales);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.textBoxTotalNumOfSnowboardsWithBoots);
			this.groupBox2.Controls.Add(this.textBoxTotalNumOfSnowboards);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Location = new System.Drawing.Point(12, 217);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(269, 170);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Summary Information";
			// 
			// textBoxAverageSales
			// 
			this.textBoxAverageSales.Location = new System.Drawing.Point(205, 129);
			this.textBoxAverageSales.Name = "textBoxAverageSales";
			this.textBoxAverageSales.ReadOnly = true;
			this.textBoxAverageSales.Size = new System.Drawing.Size(52, 20);
			this.textBoxAverageSales.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 132);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Average Sales:";
			// 
			// textBoxTotalSales
			// 
			this.textBoxTotalSales.Location = new System.Drawing.Point(205, 93);
			this.textBoxTotalSales.Name = "textBoxTotalSales";
			this.textBoxTotalSales.ReadOnly = true;
			this.textBoxTotalSales.Size = new System.Drawing.Size(52, 20);
			this.textBoxTotalSales.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 96);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Total Sales:";
			// 
			// textBoxTotalNumOfSnowboardsWithBoots
			// 
			this.textBoxTotalNumOfSnowboardsWithBoots.Location = new System.Drawing.Point(205, 57);
			this.textBoxTotalNumOfSnowboardsWithBoots.Name = "textBoxTotalNumOfSnowboardsWithBoots";
			this.textBoxTotalNumOfSnowboardsWithBoots.ReadOnly = true;
			this.textBoxTotalNumOfSnowboardsWithBoots.Size = new System.Drawing.Size(52, 20);
			this.textBoxTotalNumOfSnowboardsWithBoots.TabIndex = 5;
			// 
			// textBoxTotalNumOfSnowboards
			// 
			this.textBoxTotalNumOfSnowboards.Location = new System.Drawing.Point(205, 21);
			this.textBoxTotalNumOfSnowboards.Name = "textBoxTotalNumOfSnowboards";
			this.textBoxTotalNumOfSnowboards.ReadOnly = true;
			this.textBoxTotalNumOfSnowboards.Size = new System.Drawing.Size(52, 20);
			this.textBoxTotalNumOfSnowboards.TabIndex = 4;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 60);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(191, 13);
			this.label8.TabIndex = 2;
			this.label8.Text = "TotalNumber of Snowboards w/ Boots:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 24);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(148, 13);
			this.label9.TabIndex = 1;
			this.label9.Text = "Total Number of Snowboards:";
			// 
			// buttonCaclulate
			// 
			this.buttonCaclulate.Location = new System.Drawing.Point(108, 410);
			this.buttonCaclulate.Name = "buttonCaclulate";
			this.buttonCaclulate.Size = new System.Drawing.Size(75, 35);
			this.buttonCaclulate.TabIndex = 10;
			this.buttonCaclulate.Text = "&Calculate Order";
			this.buttonCaclulate.UseVisualStyleBackColor = true;
			this.buttonCaclulate.Click += new System.EventHandler(this.buttonCaclulate_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonClear.Location = new System.Drawing.Point(12, 393);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 23);
			this.buttonClear.TabIndex = 11;
			this.buttonClear.Text = "C&lear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(206, 422);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 13;
			this.buttonExit.Text = "E&xit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonPrint
			// 
			this.buttonPrint.Location = new System.Drawing.Point(206, 393);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(75, 23);
			this.buttonPrint.TabIndex = 12;
			this.buttonPrint.Text = "&Print";
			this.buttonPrint.UseVisualStyleBackColor = true;
			this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
			// 
			// printForm
			// 
			this.printForm.DocumentName = "document";
			this.printForm.Form = this;
			this.printForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
			this.printForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm.PrinterSettings")));
			this.printForm.PrintFileName = null;
			// 
			// buttonClearAll
			// 
			this.buttonClearAll.Location = new System.Drawing.Point(12, 422);
			this.buttonClearAll.Name = "buttonClearAll";
			this.buttonClearAll.Size = new System.Drawing.Size(75, 23);
			this.buttonClearAll.TabIndex = 14;
			this.buttonClearAll.Text = "Clear &All";
			this.buttonClearAll.UseVisualStyleBackColor = true;
			this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.buttonCaclulate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonClear;
			this.ClientSize = new System.Drawing.Size(290, 451);
			this.Controls.Add(this.buttonClearAll);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonPrint);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonCaclulate);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cool Boards";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxIDNumber;
		private System.Windows.Forms.TextBox textBoxNumOfSnowboards;
		private System.Windows.Forms.TextBox textBoxNumOfSnowboardsWithBoots;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBoxAmountDue;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxAverageSales;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxTotalSales;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxTotalNumOfSnowboardsWithBoots;
		private System.Windows.Forms.TextBox textBoxTotalNumOfSnowboards;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button buttonCaclulate;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonPrint;
		private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm;
		private System.Windows.Forms.Button buttonClearAll;
	}
}

