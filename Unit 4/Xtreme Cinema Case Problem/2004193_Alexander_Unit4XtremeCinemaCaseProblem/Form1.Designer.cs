namespace _2004193_Alexander_Unit4XtremeCinemaCaseProblem
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBoxNewRelease = new System.Windows.Forms.CheckBox();
			this.checkBoxMember = new System.Windows.Forms.CheckBox();
			this.radioButtonBlueray = new System.Windows.Forms.RadioButton();
			this.radioButtonDVD = new System.Windows.Forms.RadioButton();
			this.textBoxMovieTitle = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonClearNext = new System.Windows.Forms.Button();
			this.buttonCalculate = new System.Windows.Forms.Button();
			this.buttonOrderComplete = new System.Windows.Forms.Button();
			this.buttonSummary = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.textBoxAmountDue = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxNewRelease);
			this.groupBox1.Controls.Add(this.checkBoxMember);
			this.groupBox1.Controls.Add(this.radioButtonBlueray);
			this.groupBox1.Controls.Add(this.radioButtonDVD);
			this.groupBox1.Controls.Add(this.textBoxMovieTitle);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(45, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(194, 176);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Movie Rental";
			// 
			// checkBoxNewRelease
			// 
			this.checkBoxNewRelease.AutoSize = true;
			this.checkBoxNewRelease.Location = new System.Drawing.Point(52, 110);
			this.checkBoxNewRelease.Name = "checkBoxNewRelease";
			this.checkBoxNewRelease.Size = new System.Drawing.Size(90, 17);
			this.checkBoxNewRelease.TabIndex = 5;
			this.checkBoxNewRelease.Text = "New Release";
			this.checkBoxNewRelease.UseVisualStyleBackColor = true;
			// 
			// checkBoxMember
			// 
			this.checkBoxMember.AutoSize = true;
			this.checkBoxMember.Location = new System.Drawing.Point(52, 139);
			this.checkBoxMember.Name = "checkBoxMember";
			this.checkBoxMember.Size = new System.Drawing.Size(88, 17);
			this.checkBoxMember.TabIndex = 4;
			this.checkBoxMember.Text = "I\'m a member";
			this.checkBoxMember.UseVisualStyleBackColor = true;
			// 
			// radioButtonBlueray
			// 
			this.radioButtonBlueray.AutoSize = true;
			this.radioButtonBlueray.Location = new System.Drawing.Point(52, 81);
			this.radioButtonBlueray.Name = "radioButtonBlueray";
			this.radioButtonBlueray.Size = new System.Drawing.Size(75, 17);
			this.radioButtonBlueray.TabIndex = 3;
			this.radioButtonBlueray.TabStop = true;
			this.radioButtonBlueray.Text = "BD Format";
			this.radioButtonBlueray.UseVisualStyleBackColor = true;
			// 
			// radioButtonDVD
			// 
			this.radioButtonDVD.AutoSize = true;
			this.radioButtonDVD.Location = new System.Drawing.Point(52, 52);
			this.radioButtonDVD.Name = "radioButtonDVD";
			this.radioButtonDVD.Size = new System.Drawing.Size(83, 17);
			this.radioButtonDVD.TabIndex = 2;
			this.radioButtonDVD.TabStop = true;
			this.radioButtonDVD.Text = "DVD Format";
			this.radioButtonDVD.UseVisualStyleBackColor = true;
			// 
			// textBoxMovieTitle
			// 
			this.textBoxMovieTitle.Location = new System.Drawing.Point(65, 19);
			this.textBoxMovieTitle.Name = "textBoxMovieTitle";
			this.textBoxMovieTitle.Size = new System.Drawing.Size(100, 20);
			this.textBoxMovieTitle.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Title:";
			// 
			// buttonClearNext
			// 
			this.buttonClearNext.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonClearNext.Location = new System.Drawing.Point(105, 232);
			this.buttonClearNext.Name = "buttonClearNext";
			this.buttonClearNext.Size = new System.Drawing.Size(75, 52);
			this.buttonClearNext.TabIndex = 1;
			this.buttonClearNext.Text = "C&lear for Next Item";
			this.buttonClearNext.UseVisualStyleBackColor = true;
			this.buttonClearNext.Click += new System.EventHandler(this.buttonClearNext_Click);
			// 
			// buttonCalculate
			// 
			this.buttonCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCalculate.Location = new System.Drawing.Point(24, 203);
			this.buttonCalculate.Name = "buttonCalculate";
			this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
			this.buttonCalculate.TabIndex = 2;
			this.buttonCalculate.Text = "&Calculate";
			this.buttonCalculate.UseVisualStyleBackColor = true;
			this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
			// 
			// buttonOrderComplete
			// 
			this.buttonOrderComplete.Location = new System.Drawing.Point(186, 232);
			this.buttonOrderComplete.Name = "buttonOrderComplete";
			this.buttonOrderComplete.Size = new System.Drawing.Size(75, 52);
			this.buttonOrderComplete.TabIndex = 3;
			this.buttonOrderComplete.Text = "&Order Complete";
			this.buttonOrderComplete.UseVisualStyleBackColor = true;
			this.buttonOrderComplete.Click += new System.EventHandler(this.buttonOrderComplete_Click);
			// 
			// buttonSummary
			// 
			this.buttonSummary.Location = new System.Drawing.Point(24, 232);
			this.buttonSummary.Name = "buttonSummary";
			this.buttonSummary.Size = new System.Drawing.Size(75, 23);
			this.buttonSummary.TabIndex = 4;
			this.buttonSummary.Text = "&Summary";
			this.buttonSummary.UseVisualStyleBackColor = true;
			this.buttonSummary.Click += new System.EventHandler(this.buttonSummary_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(24, 261);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 5;
			this.buttonExit.Text = "E&xit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// textBoxAmountDue
			// 
			this.textBoxAmountDue.Location = new System.Drawing.Point(190, 205);
			this.textBoxAmountDue.Name = "textBoxAmountDue";
			this.textBoxAmountDue.ReadOnly = true;
			this.textBoxAmountDue.Size = new System.Drawing.Size(53, 20);
			this.textBoxAmountDue.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(115, 208);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Amount Due:";
			// 
			// Form1
			// 
			this.AcceptButton = this.buttonCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonClearNext;
			this.ClientSize = new System.Drawing.Size(284, 297);
			this.Controls.Add(this.textBoxAmountDue);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonSummary);
			this.Controls.Add(this.buttonOrderComplete);
			this.Controls.Add(this.buttonCalculate);
			this.Controls.Add(this.buttonClearNext);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Xtreme Cinema Movie Rental";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBoxNewRelease;
		private System.Windows.Forms.CheckBox checkBoxMember;
		private System.Windows.Forms.RadioButton radioButtonBlueray;
		private System.Windows.Forms.RadioButton radioButtonDVD;
		private System.Windows.Forms.TextBox textBoxMovieTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonClearNext;
		private System.Windows.Forms.Button buttonCalculate;
		private System.Windows.Forms.Button buttonOrderComplete;
		private System.Windows.Forms.Button buttonSummary;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.TextBox textBoxAmountDue;
		private System.Windows.Forms.Label label2;
	}
}

