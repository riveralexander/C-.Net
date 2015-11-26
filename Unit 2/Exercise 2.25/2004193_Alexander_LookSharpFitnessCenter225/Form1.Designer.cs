namespace _2004193_Alexander_LookSharpFitnessCenter225
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
			this.groupBoxDepartment = new System.Windows.Forms.GroupBox();
			this.radioButtonPersonalTraining = new System.Windows.Forms.RadioButton();
			this.radioButtonMembership = new System.Windows.Forms.RadioButton();
			this.radioButtonJuiceBar = new System.Windows.Forms.RadioButton();
			this.radioButtonEquipment = new System.Windows.Forms.RadioButton();
			this.radioButtonClothing = new System.Windows.Forms.RadioButton();
			this.labelName = new System.Windows.Forms.Label();
			this.labelMemberID = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxPromotions = new System.Windows.Forms.TextBox();
			this.richTextBoxWelcome = new System.Windows.Forms.RichTextBox();
			this.checkBoxImageVisible = new System.Windows.Forms.CheckBox();
			this.buttonSignIn = new System.Windows.Forms.Button();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.maskedTextBoxMemberID = new System.Windows.Forms.MaskedTextBox();
			this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
			this.pictureBoxDepartment = new System.Windows.Forms.PictureBox();
			this.groupBoxDepartment.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepartment)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxDepartment
			// 
			this.groupBoxDepartment.Controls.Add(this.radioButtonPersonalTraining);
			this.groupBoxDepartment.Controls.Add(this.radioButtonMembership);
			this.groupBoxDepartment.Controls.Add(this.radioButtonJuiceBar);
			this.groupBoxDepartment.Controls.Add(this.radioButtonEquipment);
			this.groupBoxDepartment.Controls.Add(this.radioButtonClothing);
			this.groupBoxDepartment.Enabled = false;
			this.groupBoxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxDepartment.Location = new System.Drawing.Point(12, 63);
			this.groupBoxDepartment.Name = "groupBoxDepartment";
			this.groupBoxDepartment.Size = new System.Drawing.Size(214, 170);
			this.groupBoxDepartment.TabIndex = 0;
			this.groupBoxDepartment.TabStop = false;
			this.groupBoxDepartment.Text = "&Department";
			// 
			// radioButtonPersonalTraining
			// 
			this.radioButtonPersonalTraining.AutoSize = true;
			this.radioButtonPersonalTraining.Location = new System.Drawing.Point(19, 136);
			this.radioButtonPersonalTraining.Name = "radioButtonPersonalTraining";
			this.radioButtonPersonalTraining.Size = new System.Drawing.Size(132, 20);
			this.radioButtonPersonalTraining.TabIndex = 4;
			this.radioButtonPersonalTraining.TabStop = true;
			this.radioButtonPersonalTraining.Text = "Personal &Training";
			this.radioButtonPersonalTraining.UseVisualStyleBackColor = true;
			this.radioButtonPersonalTraining.CheckedChanged += new System.EventHandler(this.radioButtonPersonalTraining_CheckedChanged);
			// 
			// radioButtonMembership
			// 
			this.radioButtonMembership.AutoSize = true;
			this.radioButtonMembership.Location = new System.Drawing.Point(19, 110);
			this.radioButtonMembership.Name = "radioButtonMembership";
			this.radioButtonMembership.Size = new System.Drawing.Size(101, 20);
			this.radioButtonMembership.TabIndex = 3;
			this.radioButtonMembership.TabStop = true;
			this.radioButtonMembership.Text = "&Membership";
			this.radioButtonMembership.UseVisualStyleBackColor = true;
			this.radioButtonMembership.CheckedChanged += new System.EventHandler(this.radioButtonMembership_CheckedChanged);
			// 
			// radioButtonJuiceBar
			// 
			this.radioButtonJuiceBar.AutoSize = true;
			this.radioButtonJuiceBar.Location = new System.Drawing.Point(19, 84);
			this.radioButtonJuiceBar.Name = "radioButtonJuiceBar";
			this.radioButtonJuiceBar.Size = new System.Drawing.Size(82, 20);
			this.radioButtonJuiceBar.TabIndex = 2;
			this.radioButtonJuiceBar.TabStop = true;
			this.radioButtonJuiceBar.Text = "&Juice Bar";
			this.radioButtonJuiceBar.UseVisualStyleBackColor = true;
			this.radioButtonJuiceBar.CheckedChanged += new System.EventHandler(this.radioButtonJuiceBar_CheckedChanged);
			// 
			// radioButtonEquipment
			// 
			this.radioButtonEquipment.AutoSize = true;
			this.radioButtonEquipment.Location = new System.Drawing.Point(19, 58);
			this.radioButtonEquipment.Name = "radioButtonEquipment";
			this.radioButtonEquipment.Size = new System.Drawing.Size(169, 20);
			this.radioButtonEquipment.TabIndex = 1;
			this.radioButtonEquipment.TabStop = true;
			this.radioButtonEquipment.Text = "&Equipment/Accessories";
			this.radioButtonEquipment.UseVisualStyleBackColor = true;
			this.radioButtonEquipment.CheckedChanged += new System.EventHandler(this.radioButtonEquipment_CheckedChanged);
			// 
			// radioButtonClothing
			// 
			this.radioButtonClothing.AutoSize = true;
			this.radioButtonClothing.Location = new System.Drawing.Point(19, 32);
			this.radioButtonClothing.Name = "radioButtonClothing";
			this.radioButtonClothing.Size = new System.Drawing.Size(74, 20);
			this.radioButtonClothing.TabIndex = 0;
			this.radioButtonClothing.TabStop = true;
			this.radioButtonClothing.Text = "&Clothing";
			this.radioButtonClothing.UseVisualStyleBackColor = true;
			this.radioButtonClothing.CheckedChanged += new System.EventHandler(this.radioButtonClothing_CheckedChanged);
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(330, 111);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(38, 13);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "&Name:";
			// 
			// labelMemberID
			// 
			this.labelMemberID.AutoSize = true;
			this.labelMemberID.Location = new System.Drawing.Point(330, 137);
			this.labelMemberID.Name = "labelMemberID";
			this.labelMemberID.Size = new System.Drawing.Size(62, 13);
			this.labelMemberID.TabIndex = 2;
			this.labelMemberID.Text = "Member &ID:";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(406, 108);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(129, 20);
			this.textBoxName.TabIndex = 0;
			// 
			// textBoxPromotions
			// 
			this.textBoxPromotions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxPromotions.Location = new System.Drawing.Point(333, 288);
			this.textBoxPromotions.Name = "textBoxPromotions";
			this.textBoxPromotions.Size = new System.Drawing.Size(202, 20);
			this.textBoxPromotions.TabIndex = 5;
			this.textBoxPromotions.TabStop = false;
			this.textBoxPromotions.Visible = false;
			// 
			// richTextBoxWelcome
			// 
			this.richTextBoxWelcome.Location = new System.Drawing.Point(333, 186);
			this.richTextBoxWelcome.Name = "richTextBoxWelcome";
			this.richTextBoxWelcome.Size = new System.Drawing.Size(202, 96);
			this.richTextBoxWelcome.TabIndex = 6;
			this.richTextBoxWelcome.Text = "";
			this.richTextBoxWelcome.Visible = false;
			// 
			// checkBoxImageVisible
			// 
			this.checkBoxImageVisible.AutoSize = true;
			this.checkBoxImageVisible.Location = new System.Drawing.Point(13, 417);
			this.checkBoxImageVisible.Name = "checkBoxImageVisible";
			this.checkBoxImageVisible.Size = new System.Drawing.Size(88, 17);
			this.checkBoxImageVisible.TabIndex = 8;
			this.checkBoxImageVisible.Text = "Image &Visible";
			this.checkBoxImageVisible.UseVisualStyleBackColor = true;
			this.checkBoxImageVisible.Visible = false;
			this.checkBoxImageVisible.CheckedChanged += new System.EventHandler(this.checkBoxImageVisible_CheckedChanged);
			// 
			// buttonSignIn
			// 
			this.buttonSignIn.Location = new System.Drawing.Point(460, 335);
			this.buttonSignIn.Name = "buttonSignIn";
			this.buttonSignIn.Size = new System.Drawing.Size(75, 23);
			this.buttonSignIn.TabIndex = 9;
			this.buttonSignIn.Text = "&Sign In";
			this.buttonSignIn.UseVisualStyleBackColor = true;
			this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
			// 
			// buttonPrint
			// 
			this.buttonPrint.Location = new System.Drawing.Point(460, 367);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(75, 23);
			this.buttonPrint.TabIndex = 10;
			this.buttonPrint.Text = "&Print";
			this.buttonPrint.UseVisualStyleBackColor = true;
			this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonExit.Location = new System.Drawing.Point(460, 399);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 11;
			this.buttonExit.Text = "&Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(174, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(232, 24);
			this.label1.TabIndex = 12;
			this.label1.Text = "Look Sharp Fitness Center";
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
			this.shapeContainer1.Size = new System.Drawing.Size(580, 458);
			this.shapeContainer1.TabIndex = 13;
			this.shapeContainer1.TabStop = false;
			// 
			// lineShape1
			// 
			this.lineShape1.BorderColor = System.Drawing.SystemColors.HotTrack;
			this.lineShape1.BorderWidth = 5;
			this.lineShape1.Name = "lineShape1";
			this.lineShape1.X1 = 0;
			this.lineShape1.X2 = 578;
			this.lineShape1.Y1 = 40;
			this.lineShape1.Y2 = 37;
			// 
			// maskedTextBoxMemberID
			// 
			this.maskedTextBoxMemberID.Location = new System.Drawing.Point(406, 137);
			this.maskedTextBoxMemberID.Mask = "00000";
			this.maskedTextBoxMemberID.Name = "maskedTextBoxMemberID";
			this.maskedTextBoxMemberID.Size = new System.Drawing.Size(100, 20);
			this.maskedTextBoxMemberID.TabIndex = 1;
			// 
			// printForm1
			// 
			this.printForm1.DocumentName = "document";
			this.printForm1.Form = this;
			this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
			this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
			this.printForm1.PrintFileName = null;
			// 
			// pictureBoxDepartment
			// 
			this.pictureBoxDepartment.Image = global::_2004193_Alexander_LookSharpFitnessCenter225.Properties.Resources.ea;
			this.pictureBoxDepartment.Location = new System.Drawing.Point(13, 239);
			this.pictureBoxDepartment.Name = "pictureBoxDepartment";
			this.pictureBoxDepartment.Size = new System.Drawing.Size(214, 151);
			this.pictureBoxDepartment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxDepartment.TabIndex = 7;
			this.pictureBoxDepartment.TabStop = false;
			this.pictureBoxDepartment.Visible = false;
			// 
			// Form1
			// 
			this.AcceptButton = this.buttonSignIn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonExit;
			this.ClientSize = new System.Drawing.Size(580, 458);
			this.Controls.Add(this.pictureBoxDepartment);
			this.Controls.Add(this.maskedTextBoxMemberID);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonPrint);
			this.Controls.Add(this.buttonSignIn);
			this.Controls.Add(this.checkBoxImageVisible);
			this.Controls.Add(this.richTextBoxWelcome);
			this.Controls.Add(this.textBoxPromotions);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelMemberID);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.groupBoxDepartment);
			this.Controls.Add(this.shapeContainer1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Look Sharp Fitness Center";
			this.groupBoxDepartment.ResumeLayout(false);
			this.groupBoxDepartment.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepartment)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxDepartment;
		private System.Windows.Forms.RadioButton radioButtonPersonalTraining;
		private System.Windows.Forms.RadioButton radioButtonMembership;
		private System.Windows.Forms.RadioButton radioButtonJuiceBar;
		private System.Windows.Forms.RadioButton radioButtonEquipment;
		private System.Windows.Forms.RadioButton radioButtonClothing;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelMemberID;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxPromotions;
		private System.Windows.Forms.RichTextBox richTextBoxWelcome;
		private System.Windows.Forms.PictureBox pictureBoxDepartment;
		private System.Windows.Forms.CheckBox checkBoxImageVisible;
		private System.Windows.Forms.Button buttonSignIn;
		private System.Windows.Forms.Button buttonPrint;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Label label1;
		private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
		private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxMemberID;
		private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
	}
}

