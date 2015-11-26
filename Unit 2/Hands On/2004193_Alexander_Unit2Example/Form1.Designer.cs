namespace _2004193_Alexander_Unit2Example
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
			this.textBoxStudentID = new System.Windows.Forms.TextBox();
			this.labelStudentID = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButtonWhite = new System.Windows.Forms.RadioButton();
			this.radioButtonBlue = new System.Windows.Forms.RadioButton();
			this.radioButtonGreen = new System.Windows.Forms.RadioButton();
			this.radioButtonRed = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.radioButtonSpades = new System.Windows.Forms.RadioButton();
			this.radioButtonHearts = new System.Windows.Forms.RadioButton();
			this.radioButtonDiamonds = new System.Windows.Forms.RadioButton();
			this.radioButtonClubs = new System.Windows.Forms.RadioButton();
			this.pictureBoxSelectCard = new System.Windows.Forms.PictureBox();
			this.checkBoxShowImage = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectCard)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxStudentID);
			this.groupBox1.Controls.Add(this.labelStudentID);
			this.groupBox1.Controls.Add(this.textBoxName);
			this.groupBox1.Controls.Add(this.labelName);
			this.groupBox1.Location = new System.Drawing.Point(24, 34);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(255, 135);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Student Data";
			// 
			// textBoxStudentID
			// 
			this.textBoxStudentID.Location = new System.Drawing.Point(85, 80);
			this.textBoxStudentID.Name = "textBoxStudentID";
			this.textBoxStudentID.Size = new System.Drawing.Size(100, 20);
			this.textBoxStudentID.TabIndex = 3;
			// 
			// labelStudentID
			// 
			this.labelStudentID.AutoSize = true;
			this.labelStudentID.Location = new System.Drawing.Point(24, 83);
			this.labelStudentID.Name = "labelStudentID";
			this.labelStudentID.Size = new System.Drawing.Size(61, 13);
			this.labelStudentID.TabIndex = 2;
			this.labelStudentID.Text = "Student ID:";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(85, 45);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(100, 20);
			this.textBoxName.TabIndex = 1;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(24, 48);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(38, 13);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Name:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButtonWhite);
			this.groupBox2.Controls.Add(this.radioButtonBlue);
			this.groupBox2.Controls.Add(this.radioButtonGreen);
			this.groupBox2.Controls.Add(this.radioButtonRed);
			this.groupBox2.Location = new System.Drawing.Point(285, 30);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(133, 139);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Background Color";
			// 
			// radioButtonWhite
			// 
			this.radioButtonWhite.AutoSize = true;
			this.radioButtonWhite.Location = new System.Drawing.Point(15, 97);
			this.radioButtonWhite.Name = "radioButtonWhite";
			this.radioButtonWhite.Size = new System.Drawing.Size(53, 17);
			this.radioButtonWhite.TabIndex = 3;
			this.radioButtonWhite.TabStop = true;
			this.radioButtonWhite.Text = "&White";
			this.radioButtonWhite.UseVisualStyleBackColor = true;
			this.radioButtonWhite.CheckedChanged += new System.EventHandler(this.radioButtonWhite_CheckedChanged);
			// 
			// radioButtonBlue
			// 
			this.radioButtonBlue.AutoSize = true;
			this.radioButtonBlue.Location = new System.Drawing.Point(15, 74);
			this.radioButtonBlue.Name = "radioButtonBlue";
			this.radioButtonBlue.Size = new System.Drawing.Size(46, 17);
			this.radioButtonBlue.TabIndex = 2;
			this.radioButtonBlue.TabStop = true;
			this.radioButtonBlue.Text = "&Blue";
			this.radioButtonBlue.UseVisualStyleBackColor = true;
			this.radioButtonBlue.CheckedChanged += new System.EventHandler(this.radioButtonBlue_CheckedChanged);
			// 
			// radioButtonGreen
			// 
			this.radioButtonGreen.AutoSize = true;
			this.radioButtonGreen.Location = new System.Drawing.Point(15, 51);
			this.radioButtonGreen.Name = "radioButtonGreen";
			this.radioButtonGreen.Size = new System.Drawing.Size(54, 17);
			this.radioButtonGreen.TabIndex = 1;
			this.radioButtonGreen.TabStop = true;
			this.radioButtonGreen.Text = "&Green";
			this.radioButtonGreen.UseVisualStyleBackColor = true;
			this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.radioButtonGreen_CheckedChanged);
			// 
			// radioButtonRed
			// 
			this.radioButtonRed.AutoSize = true;
			this.radioButtonRed.Location = new System.Drawing.Point(15, 28);
			this.radioButtonRed.Name = "radioButtonRed";
			this.radioButtonRed.Size = new System.Drawing.Size(45, 17);
			this.radioButtonRed.TabIndex = 0;
			this.radioButtonRed.TabStop = true;
			this.radioButtonRed.Text = "&Red";
			this.radioButtonRed.UseVisualStyleBackColor = true;
			this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButtonRed_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(106, 177);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Select Card:";
			// 
			// radioButtonSpades
			// 
			this.radioButtonSpades.AutoSize = true;
			this.radioButtonSpades.Location = new System.Drawing.Point(114, 199);
			this.radioButtonSpades.Name = "radioButtonSpades";
			this.radioButtonSpades.Size = new System.Drawing.Size(95, 17);
			this.radioButtonSpades.TabIndex = 3;
			this.radioButtonSpades.TabStop = true;
			this.radioButtonSpades.Text = "Ace of Spades";
			this.radioButtonSpades.UseVisualStyleBackColor = true;
			this.radioButtonSpades.CheckedChanged += new System.EventHandler(this.radioButtonSpades_CheckedChanged);
			// 
			// radioButtonHearts
			// 
			this.radioButtonHearts.AutoSize = true;
			this.radioButtonHearts.Location = new System.Drawing.Point(114, 225);
			this.radioButtonHearts.Name = "radioButtonHearts";
			this.radioButtonHearts.Size = new System.Drawing.Size(90, 17);
			this.radioButtonHearts.TabIndex = 4;
			this.radioButtonHearts.TabStop = true;
			this.radioButtonHearts.Text = "Ace of Hearts";
			this.radioButtonHearts.UseVisualStyleBackColor = true;
			this.radioButtonHearts.CheckedChanged += new System.EventHandler(this.radioButtonHearts_CheckedChanged);
			// 
			// radioButtonDiamonds
			// 
			this.radioButtonDiamonds.AutoSize = true;
			this.radioButtonDiamonds.Location = new System.Drawing.Point(114, 251);
			this.radioButtonDiamonds.Name = "radioButtonDiamonds";
			this.radioButtonDiamonds.Size = new System.Drawing.Size(106, 17);
			this.radioButtonDiamonds.TabIndex = 5;
			this.radioButtonDiamonds.TabStop = true;
			this.radioButtonDiamonds.Text = "Ace of Diamonds";
			this.radioButtonDiamonds.UseVisualStyleBackColor = true;
			this.radioButtonDiamonds.CheckedChanged += new System.EventHandler(this.radioButtonDiamonds_CheckedChanged);
			// 
			// radioButtonClubs
			// 
			this.radioButtonClubs.AutoSize = true;
			this.radioButtonClubs.Location = new System.Drawing.Point(114, 277);
			this.radioButtonClubs.Name = "radioButtonClubs";
			this.radioButtonClubs.Size = new System.Drawing.Size(85, 17);
			this.radioButtonClubs.TabIndex = 6;
			this.radioButtonClubs.TabStop = true;
			this.radioButtonClubs.Text = "Ace of Clubs";
			this.radioButtonClubs.UseVisualStyleBackColor = true;
			this.radioButtonClubs.CheckedChanged += new System.EventHandler(this.radioButtonClubs_CheckedChanged);
			// 
			// pictureBoxSelectCard
			// 
			this.pictureBoxSelectCard.Image = global::_2004193_Alexander_Unit2Example.Properties.Resources._as;
			this.pictureBoxSelectCard.Location = new System.Drawing.Point(24, 199);
			this.pictureBoxSelectCard.Name = "pictureBoxSelectCard";
			this.pictureBoxSelectCard.Size = new System.Drawing.Size(255, 121);
			this.pictureBoxSelectCard.TabIndex = 2;
			this.pictureBoxSelectCard.TabStop = false;
			this.pictureBoxSelectCard.Click += new System.EventHandler(this.pictureBoxSelectCard_Click);
			// 
			// checkBoxShowImage
			// 
			this.checkBoxShowImage.AutoSize = true;
			this.checkBoxShowImage.Checked = true;
			this.checkBoxShowImage.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxShowImage.Location = new System.Drawing.Point(114, 303);
			this.checkBoxShowImage.Name = "checkBoxShowImage";
			this.checkBoxShowImage.Size = new System.Drawing.Size(84, 17);
			this.checkBoxShowImage.TabIndex = 7;
			this.checkBoxShowImage.Text = "Show image";
			this.checkBoxShowImage.UseVisualStyleBackColor = true;
			this.checkBoxShowImage.CheckedChanged += new System.EventHandler(this.checkBoxShowImage_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 349);
			this.Controls.Add(this.checkBoxShowImage);
			this.Controls.Add(this.radioButtonClubs);
			this.Controls.Add(this.radioButtonDiamonds);
			this.Controls.Add(this.radioButtonHearts);
			this.Controls.Add(this.radioButtonSpades);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBoxSelectCard);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Unit 2 Example";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectCard)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBoxStudentID;
		private System.Windows.Forms.Label labelStudentID;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButtonBlue;
		private System.Windows.Forms.RadioButton radioButtonGreen;
		private System.Windows.Forms.RadioButton radioButtonRed;
		private System.Windows.Forms.PictureBox pictureBoxSelectCard;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButtonSpades;
		private System.Windows.Forms.RadioButton radioButtonHearts;
		private System.Windows.Forms.RadioButton radioButtonDiamonds;
		private System.Windows.Forms.RadioButton radioButtonClubs;
		private System.Windows.Forms.RadioButton radioButtonWhite;
		private System.Windows.Forms.CheckBox checkBoxShowImage;
	}
}

