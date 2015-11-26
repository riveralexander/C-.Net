namespace _2004193_Alexander_EmployeeSales36
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
			this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
			this.textBoxEmployeeSales = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBoxNetPay = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonCalculate = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxCommission = new System.Windows.Forms.TextBox();
			this.textBoxDeduction = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.printForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.textBoxMiscellaneous = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxHousing = new System.Windows.Forms.TextBox();
			this.textBoxFoodAndClothing = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxEntertainment = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// textBoxEmployeeName
			// 
			this.textBoxEmployeeName.Location = new System.Drawing.Point(81, 19);
			this.textBoxEmployeeName.Name = "textBoxEmployeeName";
			this.textBoxEmployeeName.Size = new System.Drawing.Size(100, 20);
			this.textBoxEmployeeName.TabIndex = 1;
			// 
			// textBoxEmployeeSales
			// 
			this.textBoxEmployeeSales.Location = new System.Drawing.Point(81, 61);
			this.textBoxEmployeeSales.Name = "textBoxEmployeeSales";
			this.textBoxEmployeeSales.Size = new System.Drawing.Size(54, 20);
			this.textBoxEmployeeSales.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Sales:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.textBoxEmployeeName);
			this.groupBox2.Controls.Add(this.textBoxEmployeeSales);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(15, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 100);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Employee";
			// 
			// textBoxNetPay
			// 
			this.textBoxNetPay.Location = new System.Drawing.Point(87, 85);
			this.textBoxNetPay.Name = "textBoxNetPay";
			this.textBoxNetPay.ReadOnly = true;
			this.textBoxNetPay.Size = new System.Drawing.Size(54, 20);
			this.textBoxNetPay.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Net Pay:";
			// 
			// buttonCalculate
			// 
			this.buttonCalculate.Location = new System.Drawing.Point(15, 246);
			this.buttonCalculate.Name = "buttonCalculate";
			this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
			this.buttonCalculate.TabIndex = 8;
			this.buttonCalculate.Text = "&Calculate";
			this.buttonCalculate.UseVisualStyleBackColor = true;
			this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonClear.Location = new System.Drawing.Point(15, 283);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 23);
			this.buttonClear.TabIndex = 9;
			this.buttonClear.Text = "C&lear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonPrint
			// 
			this.buttonPrint.Location = new System.Drawing.Point(346, 246);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(75, 23);
			this.buttonPrint.TabIndex = 10;
			this.buttonPrint.Text = "&Print";
			this.buttonPrint.UseVisualStyleBackColor = true;
			this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(346, 283);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 11;
			this.buttonExit.Text = "E&xit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBoxCommission);
			this.groupBox1.Controls.Add(this.textBoxDeduction);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textBoxNetPay);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(15, 118);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 122);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Summary Information";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Commission:";
			// 
			// textBoxCommission
			// 
			this.textBoxCommission.Location = new System.Drawing.Point(87, 17);
			this.textBoxCommission.Name = "textBoxCommission";
			this.textBoxCommission.ReadOnly = true;
			this.textBoxCommission.Size = new System.Drawing.Size(54, 20);
			this.textBoxCommission.TabIndex = 1;
			// 
			// textBoxDeduction
			// 
			this.textBoxDeduction.Location = new System.Drawing.Point(87, 51);
			this.textBoxDeduction.Name = "textBoxDeduction";
			this.textBoxDeduction.ReadOnly = true;
			this.textBoxDeduction.Size = new System.Drawing.Size(54, 20);
			this.textBoxDeduction.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 54);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Deduction:";
			// 
			// printForm
			// 
			this.printForm.DocumentName = "document";
			this.printForm.Form = this;
			this.printForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
			this.printForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm.PrinterSettings")));
			this.printForm.PrintFileName = null;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.textBoxMiscellaneous);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.textBoxHousing);
			this.groupBox3.Controls.Add(this.textBoxFoodAndClothing);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.textBoxEntertainment);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Location = new System.Drawing.Point(221, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 228);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Budget";
			// 
			// textBoxMiscellaneous
			// 
			this.textBoxMiscellaneous.Location = new System.Drawing.Point(125, 191);
			this.textBoxMiscellaneous.Name = "textBoxMiscellaneous";
			this.textBoxMiscellaneous.ReadOnly = true;
			this.textBoxMiscellaneous.Size = new System.Drawing.Size(54, 20);
			this.textBoxMiscellaneous.TabIndex = 9;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(13, 196);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(77, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "Miscellaneous:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 19);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Housing:";
			// 
			// textBoxHousing
			// 
			this.textBoxHousing.Location = new System.Drawing.Point(118, 16);
			this.textBoxHousing.Name = "textBoxHousing";
			this.textBoxHousing.ReadOnly = true;
			this.textBoxHousing.Size = new System.Drawing.Size(54, 20);
			this.textBoxHousing.TabIndex = 1;
			// 
			// textBoxFoodAndClothing
			// 
			this.textBoxFoodAndClothing.Location = new System.Drawing.Point(118, 75);
			this.textBoxFoodAndClothing.Name = "textBoxFoodAndClothing";
			this.textBoxFoodAndClothing.ReadOnly = true;
			this.textBoxFoodAndClothing.Size = new System.Drawing.Size(54, 20);
			this.textBoxFoodAndClothing.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 78);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "Food and Clothing:";
			// 
			// textBoxEntertainment
			// 
			this.textBoxEntertainment.Location = new System.Drawing.Point(118, 134);
			this.textBoxEntertainment.Name = "textBoxEntertainment";
			this.textBoxEntertainment.ReadOnly = true;
			this.textBoxEntertainment.Size = new System.Drawing.Size(54, 20);
			this.textBoxEntertainment.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(13, 137);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(75, 13);
			this.label8.TabIndex = 6;
			this.label8.Text = "Entertainment:";
			// 
			// Form1
			// 
			this.AcceptButton = this.buttonCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonClear;
			this.ClientSize = new System.Drawing.Size(431, 323);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonPrint);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonCalculate);
			this.Controls.Add(this.groupBox2);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Employee Sales";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxEmployeeName;
		private System.Windows.Forms.TextBox textBoxEmployeeSales;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxNetPay;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonCalculate;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonPrint;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxCommission;
		private System.Windows.Forms.TextBox textBoxDeduction;
		private System.Windows.Forms.Label label5;
		private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textBoxMiscellaneous;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxHousing;
		private System.Windows.Forms.TextBox textBoxFoodAndClothing;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxEntertainment;
		private System.Windows.Forms.Label label8;
	}
}

