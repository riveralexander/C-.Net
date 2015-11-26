namespace _2004193_Alexander_Unit3XtremeCinemaCaseStudy
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
			this.textBoxMemberID = new System.Windows.Forms.TextBox();
			this.textBoxNumOfMovies = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxAmountDue = new System.Windows.Forms.TextBox();
			this.textBoxDiscount = new System.Windows.Forms.TextBox();
			this.textBoxRentalAmount = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBoxTotalSales = new System.Windows.Forms.TextBox();
			this.textBoxNumOfCustomers = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.buttonCalculate = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.printForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Member &ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "&Number of Movies:";
			// 
			// textBoxMemberID
			// 
			this.textBoxMemberID.Location = new System.Drawing.Point(143, 30);
			this.textBoxMemberID.Name = "textBoxMemberID";
			this.textBoxMemberID.Size = new System.Drawing.Size(47, 20);
			this.textBoxMemberID.TabIndex = 2;
			// 
			// textBoxNumOfMovies
			// 
			this.textBoxNumOfMovies.Location = new System.Drawing.Point(143, 62);
			this.textBoxNumOfMovies.Name = "textBoxNumOfMovies";
			this.textBoxNumOfMovies.Size = new System.Drawing.Size(47, 20);
			this.textBoxNumOfMovies.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxAmountDue);
			this.groupBox1.Controls.Add(this.textBoxDiscount);
			this.groupBox1.Controls.Add(this.textBoxRentalAmount);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(14, 109);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rentals";
			// 
			// textBoxAmountDue
			// 
			this.textBoxAmountDue.Location = new System.Drawing.Point(102, 71);
			this.textBoxAmountDue.Name = "textBoxAmountDue";
			this.textBoxAmountDue.Size = new System.Drawing.Size(47, 20);
			this.textBoxAmountDue.TabIndex = 7;
			// 
			// textBoxDiscount
			// 
			this.textBoxDiscount.Location = new System.Drawing.Point(102, 44);
			this.textBoxDiscount.Name = "textBoxDiscount";
			this.textBoxDiscount.Size = new System.Drawing.Size(47, 20);
			this.textBoxDiscount.TabIndex = 6;
			// 
			// textBoxRentalAmount
			// 
			this.textBoxRentalAmount.Location = new System.Drawing.Point(102, 17);
			this.textBoxRentalAmount.Name = "textBoxRentalAmount";
			this.textBoxRentalAmount.Size = new System.Drawing.Size(47, 20);
			this.textBoxRentalAmount.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "&Amount Due:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "&Discount:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "&Rental Amount:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBoxTotalSales);
			this.groupBox2.Controls.Add(this.textBoxNumOfCustomers);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new System.Drawing.Point(14, 227);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 100);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Summary Information";
			// 
			// textBoxTotalSales
			// 
			this.textBoxTotalSales.Location = new System.Drawing.Point(121, 56);
			this.textBoxTotalSales.Name = "textBoxTotalSales";
			this.textBoxTotalSales.Size = new System.Drawing.Size(47, 20);
			this.textBoxTotalSales.TabIndex = 7;
			// 
			// textBoxNumOfCustomers
			// 
			this.textBoxNumOfCustomers.Location = new System.Drawing.Point(121, 24);
			this.textBoxNumOfCustomers.Name = "textBoxNumOfCustomers";
			this.textBoxNumOfCustomers.Size = new System.Drawing.Size(47, 20);
			this.textBoxNumOfCustomers.TabIndex = 6;
			this.textBoxNumOfCustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "&Total Sales:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 27);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(111, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "N&umber of Customers:";
			// 
			// buttonCalculate
			// 
			this.buttonCalculate.Location = new System.Drawing.Point(14, 341);
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
			this.buttonClear.Location = new System.Drawing.Point(14, 370);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 23);
			this.buttonClear.TabIndex = 7;
			this.buttonClear.Text = "C&lear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonPrint
			// 
			this.buttonPrint.Location = new System.Drawing.Point(139, 341);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(75, 23);
			this.buttonPrint.TabIndex = 8;
			this.buttonPrint.Text = "&Print";
			this.buttonPrint.UseVisualStyleBackColor = true;
			this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(139, 370);
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
			// Form1
			// 
			this.AcceptButton = this.buttonCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonClear;
			this.ClientSize = new System.Drawing.Size(229, 401);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonPrint);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonCalculate);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBoxNumOfMovies);
			this.Controls.Add(this.textBoxMemberID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Xtreme Cinema";
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
		private System.Windows.Forms.TextBox textBoxMemberID;
		private System.Windows.Forms.TextBox textBoxNumOfMovies;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBoxAmountDue;
		private System.Windows.Forms.TextBox textBoxDiscount;
		private System.Windows.Forms.TextBox textBoxRentalAmount;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxTotalSales;
		private System.Windows.Forms.TextBox textBoxNumOfCustomers;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button buttonCalculate;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonPrint;
		private System.Windows.Forms.Button buttonExit;
		private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm;
	}
}

