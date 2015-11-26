namespace _2004193_Alexander_Exercise_44_45_46
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
			this.radioButtonDeposit = new System.Windows.Forms.RadioButton();
			this.radioButtonCheck = new System.Windows.Forms.RadioButton();
			this.radioButtonServiceCharge = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxBalance = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxAmount = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonCaclulate = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.printForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBoxTotalDeposited = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxTotalNumOfDeposits = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxTotalNumOfChecks = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxTotalWithdrawn = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// radioButtonDeposit
			// 
			this.radioButtonDeposit.AutoSize = true;
			this.radioButtonDeposit.Location = new System.Drawing.Point(31, 26);
			this.radioButtonDeposit.Name = "radioButtonDeposit";
			this.radioButtonDeposit.Size = new System.Drawing.Size(61, 17);
			this.radioButtonDeposit.TabIndex = 0;
			this.radioButtonDeposit.TabStop = true;
			this.radioButtonDeposit.Text = "Deposit";
			this.radioButtonDeposit.UseVisualStyleBackColor = true;
			// 
			// radioButtonCheck
			// 
			this.radioButtonCheck.AutoSize = true;
			this.radioButtonCheck.Location = new System.Drawing.Point(31, 55);
			this.radioButtonCheck.Name = "radioButtonCheck";
			this.radioButtonCheck.Size = new System.Drawing.Size(56, 17);
			this.radioButtonCheck.TabIndex = 1;
			this.radioButtonCheck.TabStop = true;
			this.radioButtonCheck.Text = "Check";
			this.radioButtonCheck.UseVisualStyleBackColor = true;
			// 
			// radioButtonServiceCharge
			// 
			this.radioButtonServiceCharge.AutoSize = true;
			this.radioButtonServiceCharge.Location = new System.Drawing.Point(31, 84);
			this.radioButtonServiceCharge.Name = "radioButtonServiceCharge";
			this.radioButtonServiceCharge.Size = new System.Drawing.Size(98, 17);
			this.radioButtonServiceCharge.TabIndex = 2;
			this.radioButtonServiceCharge.TabStop = true;
			this.radioButtonServiceCharge.Text = "Service Charge";
			this.radioButtonServiceCharge.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxBalance);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBoxAmount);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.radioButtonServiceCharge);
			this.groupBox1.Controls.Add(this.radioButtonDeposit);
			this.groupBox1.Controls.Add(this.radioButtonCheck);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(161, 174);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Transaction";
			// 
			// textBoxBalance
			// 
			this.textBoxBalance.Location = new System.Drawing.Point(89, 143);
			this.textBoxBalance.Name = "textBoxBalance";
			this.textBoxBalance.ReadOnly = true;
			this.textBoxBalance.Size = new System.Drawing.Size(60, 20);
			this.textBoxBalance.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 146);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Balance:";
			// 
			// textBoxAmount
			// 
			this.textBoxAmount.Location = new System.Drawing.Point(89, 116);
			this.textBoxAmount.Name = "textBoxAmount";
			this.textBoxAmount.Size = new System.Drawing.Size(60, 20);
			this.textBoxAmount.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 119);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Amount:";
			// 
			// buttonCaclulate
			// 
			this.buttonCaclulate.Location = new System.Drawing.Point(12, 207);
			this.buttonCaclulate.Name = "buttonCaclulate";
			this.buttonCaclulate.Size = new System.Drawing.Size(75, 23);
			this.buttonCaclulate.TabIndex = 4;
			this.buttonCaclulate.Text = "&Calculate";
			this.buttonCaclulate.UseVisualStyleBackColor = true;
			this.buttonCaclulate.Click += new System.EventHandler(this.buttonCaclulate_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonClear.Location = new System.Drawing.Point(12, 235);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 23);
			this.buttonClear.TabIndex = 5;
			this.buttonClear.Text = "C&lear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(255, 235);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 7;
			this.buttonExit.Text = "E&xit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonPrint
			// 
			this.buttonPrint.Location = new System.Drawing.Point(255, 207);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(75, 23);
			this.buttonPrint.TabIndex = 6;
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
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBoxTotalWithdrawn);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.textBoxTotalNumOfChecks);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.textBoxTotalDeposited);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.textBoxTotalNumOfDeposits);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(181, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(149, 174);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Summary Information";
			// 
			// textBoxTotalDeposited
			// 
			this.textBoxTotalDeposited.Location = new System.Drawing.Point(97, 58);
			this.textBoxTotalDeposited.Name = "textBoxTotalDeposited";
			this.textBoxTotalDeposited.ReadOnly = true;
			this.textBoxTotalDeposited.Size = new System.Drawing.Size(47, 20);
			this.textBoxTotalDeposited.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Total Deposited:";
			// 
			// textBoxTotalNumOfDeposits
			// 
			this.textBoxTotalNumOfDeposits.Location = new System.Drawing.Point(97, 20);
			this.textBoxTotalNumOfDeposits.Name = "textBoxTotalNumOfDeposits";
			this.textBoxTotalNumOfDeposits.ReadOnly = true;
			this.textBoxTotalNumOfDeposits.Size = new System.Drawing.Size(47, 20);
			this.textBoxTotalNumOfDeposits.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Total Deposits:";
			// 
			// textBoxTotalNumOfChecks
			// 
			this.textBoxTotalNumOfChecks.Location = new System.Drawing.Point(96, 96);
			this.textBoxTotalNumOfChecks.Name = "textBoxTotalNumOfChecks";
			this.textBoxTotalNumOfChecks.ReadOnly = true;
			this.textBoxTotalNumOfChecks.Size = new System.Drawing.Size(47, 20);
			this.textBoxTotalNumOfChecks.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 99);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Total Checks:";
			// 
			// textBoxTotalWithdrawn
			// 
			this.textBoxTotalWithdrawn.Location = new System.Drawing.Point(97, 134);
			this.textBoxTotalWithdrawn.Name = "textBoxTotalWithdrawn";
			this.textBoxTotalWithdrawn.ReadOnly = true;
			this.textBoxTotalWithdrawn.Size = new System.Drawing.Size(47, 20);
			this.textBoxTotalWithdrawn.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 137);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Total Withdrawn:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(131, 207);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 48);
			this.button1.TabIndex = 10;
			this.button1.Text = "&Summary";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.buttonCaclulate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonClear;
			this.ClientSize = new System.Drawing.Size(342, 264);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonPrint);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonCaclulate);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Image Consulting Shop";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RadioButton radioButtonDeposit;
		private System.Windows.Forms.RadioButton radioButtonCheck;
		private System.Windows.Forms.RadioButton radioButtonServiceCharge;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBoxBalance;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxAmount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonCaclulate;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonPrint;
		private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxTotalWithdrawn;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxTotalNumOfChecks;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxTotalDeposited;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxTotalNumOfDeposits;
		private System.Windows.Forms.Label label4;
	}
}

