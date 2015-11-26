namespace _2004193_Alexander_RecordingStudio32
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
			this.textBoxGroupName = new System.Windows.Forms.TextBox();
			this.textBoxTimeUsed = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxTotalSales = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxNumberOfGroups = new System.Windows.Forms.TextBox();
			this.textBoxAverageCharge = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.buttonCalculate = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.printForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxAmountDue = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(67, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Group Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(67, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Time used:";
			// 
			// textBoxGroupName
			// 
			this.textBoxGroupName.Location = new System.Drawing.Point(140, 25);
			this.textBoxGroupName.Name = "textBoxGroupName";
			this.textBoxGroupName.Size = new System.Drawing.Size(158, 20);
			this.textBoxGroupName.TabIndex = 2;
			// 
			// textBoxTimeUsed
			// 
			this.textBoxTimeUsed.Location = new System.Drawing.Point(140, 62);
			this.textBoxTimeUsed.Name = "textBoxTimeUsed";
			this.textBoxTimeUsed.Size = new System.Drawing.Size(70, 20);
			this.textBoxTimeUsed.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBoxTimeUsed);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBoxGroupName);
			this.groupBox1.Location = new System.Drawing.Point(11, 45);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(334, 115);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Music Group";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(44, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(269, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "George\'s Recording Studio";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.textBoxAmountDue);
			this.groupBox2.Controls.Add(this.textBoxAverageCharge);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.textBoxTotalSales);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.textBoxNumberOfGroups);
			this.groupBox2.Location = new System.Drawing.Point(11, 166);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(334, 135);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Summary Information";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(150, 46);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Number of Groups:";
			// 
			// textBoxTotalSales
			// 
			this.textBoxTotalSales.Location = new System.Drawing.Point(252, 73);
			this.textBoxTotalSales.Name = "textBoxTotalSales";
			this.textBoxTotalSales.ReadOnly = true;
			this.textBoxTotalSales.Size = new System.Drawing.Size(70, 20);
			this.textBoxTotalSales.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(150, 76);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Total Sales:";
			// 
			// textBoxNumberOfGroups
			// 
			this.textBoxNumberOfGroups.Location = new System.Drawing.Point(252, 43);
			this.textBoxNumberOfGroups.Name = "textBoxNumberOfGroups";
			this.textBoxNumberOfGroups.ReadOnly = true;
			this.textBoxNumberOfGroups.Size = new System.Drawing.Size(70, 20);
			this.textBoxNumberOfGroups.TabIndex = 2;
			// 
			// textBoxAverageCharge
			// 
			this.textBoxAverageCharge.Location = new System.Drawing.Point(252, 103);
			this.textBoxAverageCharge.Name = "textBoxAverageCharge";
			this.textBoxAverageCharge.ReadOnly = true;
			this.textBoxAverageCharge.Size = new System.Drawing.Size(70, 20);
			this.textBoxAverageCharge.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(150, 106);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "Average Charge:";
			// 
			// buttonCalculate
			// 
			this.buttonCalculate.Location = new System.Drawing.Point(11, 307);
			this.buttonCalculate.Name = "buttonCalculate";
			this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
			this.buttonCalculate.TabIndex = 6;
			this.buttonCalculate.Text = "&Calculate";
			this.buttonCalculate.UseVisualStyleBackColor = true;
			this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonClear.Location = new System.Drawing.Point(11, 336);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 23);
			this.buttonClear.TabIndex = 7;
			this.buttonClear.Text = "C&lear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonPrint
			// 
			this.buttonPrint.Location = new System.Drawing.Point(274, 307);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(75, 23);
			this.buttonPrint.TabIndex = 8;
			this.buttonPrint.Text = "&Print";
			this.buttonPrint.UseVisualStyleBackColor = true;
			this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(274, 336);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 9;
			this.buttonExit.Text = "E&xit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// printForm
			// 
			this.printForm.DocumentName = "document";
			this.printForm.Form = this;
			this.printForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
			this.printForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm.PrinterSettings")));
			this.printForm.PrintFileName = null;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(150, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(69, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Amount Due:";
			// 
			// textBoxAmountDue
			// 
			this.textBoxAmountDue.Location = new System.Drawing.Point(252, 13);
			this.textBoxAmountDue.Name = "textBoxAmountDue";
			this.textBoxAmountDue.ReadOnly = true;
			this.textBoxAmountDue.Size = new System.Drawing.Size(70, 20);
			this.textBoxAmountDue.TabIndex = 7;
			// 
			// Form1
			// 
			this.AcceptButton = this.buttonCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonClear;
			this.ClientSize = new System.Drawing.Size(357, 371);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonPrint);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonCalculate);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "George\'s Recording Studio";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxGroupName;
		private System.Windows.Forms.TextBox textBoxTimeUsed;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxAverageCharge;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxTotalSales;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxNumberOfGroups;
		private System.Windows.Forms.Button buttonCalculate;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonPrint;
		private System.Windows.Forms.Button buttonExit;
		private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxAmountDue;
	}
}

