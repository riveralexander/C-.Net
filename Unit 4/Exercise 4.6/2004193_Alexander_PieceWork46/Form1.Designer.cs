namespace _2004193_Alexander_46
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxPiecesComplete = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxAmount = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonCalculate = new System.Windows.Forms.Button();
			this.buttonSummary = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonClearAll = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBoxAveragePay = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxTotalPay = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxTotalPieces = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Pieces Completed:";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(74, 18);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(100, 20);
			this.textBoxName.TabIndex = 2;
			// 
			// textBoxPiecesComplete
			// 
			this.textBoxPiecesComplete.Location = new System.Drawing.Point(124, 63);
			this.textBoxPiecesComplete.Name = "textBoxPiecesComplete";
			this.textBoxPiecesComplete.Size = new System.Drawing.Size(50, 20);
			this.textBoxPiecesComplete.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxAmount);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBoxPiecesComplete);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBoxName);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(185, 136);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Worker";
			// 
			// textBoxAmount
			// 
			this.textBoxAmount.Location = new System.Drawing.Point(124, 104);
			this.textBoxAmount.Name = "textBoxAmount";
			this.textBoxAmount.ReadOnly = true;
			this.textBoxAmount.Size = new System.Drawing.Size(50, 20);
			this.textBoxAmount.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Amount Earned:";
			// 
			// buttonCalculate
			// 
			this.buttonCalculate.Location = new System.Drawing.Point(13, 327);
			this.buttonCalculate.Name = "buttonCalculate";
			this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
			this.buttonCalculate.TabIndex = 5;
			this.buttonCalculate.Text = "&Calculate";
			this.buttonCalculate.UseVisualStyleBackColor = true;
			this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
			// 
			// buttonSummary
			// 
			this.buttonSummary.Location = new System.Drawing.Point(109, 327);
			this.buttonSummary.Name = "buttonSummary";
			this.buttonSummary.Size = new System.Drawing.Size(75, 23);
			this.buttonSummary.TabIndex = 6;
			this.buttonSummary.Text = "&Summary";
			this.buttonSummary.UseVisualStyleBackColor = true;
			this.buttonSummary.Click += new System.EventHandler(this.buttonSummary_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonClear.Location = new System.Drawing.Point(213, 267);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 23);
			this.buttonClear.TabIndex = 7;
			this.buttonClear.Text = "C&lear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonClearAll
			// 
			this.buttonClearAll.Location = new System.Drawing.Point(213, 296);
			this.buttonClearAll.Name = "buttonClearAll";
			this.buttonClearAll.Size = new System.Drawing.Size(75, 23);
			this.buttonClearAll.TabIndex = 8;
			this.buttonClearAll.Text = "Clear &All";
			this.buttonClearAll.UseVisualStyleBackColor = true;
			this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(213, 327);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 9;
			this.buttonExit.Text = "E&xit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBoxAveragePay);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.textBoxTotalPay);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.textBoxTotalPieces);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(12, 154);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(184, 148);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Summary Information";
			// 
			// textBoxAveragePay
			// 
			this.textBoxAveragePay.Location = new System.Drawing.Point(124, 107);
			this.textBoxAveragePay.Name = "textBoxAveragePay";
			this.textBoxAveragePay.ReadOnly = true;
			this.textBoxAveragePay.Size = new System.Drawing.Size(50, 20);
			this.textBoxAveragePay.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 110);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Average Pay:";
			// 
			// textBoxTotalPay
			// 
			this.textBoxTotalPay.Location = new System.Drawing.Point(124, 65);
			this.textBoxTotalPay.Name = "textBoxTotalPay";
			this.textBoxTotalPay.ReadOnly = true;
			this.textBoxTotalPay.Size = new System.Drawing.Size(50, 20);
			this.textBoxTotalPay.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Total Pay:";
			// 
			// textBoxTotalPieces
			// 
			this.textBoxTotalPieces.Location = new System.Drawing.Point(124, 23);
			this.textBoxTotalPieces.Name = "textBoxTotalPieces";
			this.textBoxTotalPieces.ReadOnly = true;
			this.textBoxTotalPieces.Size = new System.Drawing.Size(50, 20);
			this.textBoxTotalPieces.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Total Pieces:";
			// 
			// Form1
			// 
			this.AcceptButton = this.buttonCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonClear;
			this.ClientSize = new System.Drawing.Size(301, 362);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonClearAll);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonSummary);
			this.Controls.Add(this.buttonCalculate);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pieces Complete";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxPiecesComplete;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonCalculate;
		private System.Windows.Forms.Button buttonSummary;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonClearAll;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxAmount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxAveragePay;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxTotalPay;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxTotalPieces;
		private System.Windows.Forms.Label label6;
	}
}

