namespace _2004193_Alexander_CountryFlags22
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
			this.buttonExit = new System.Windows.Forms.Button();
			this.radioButtonUSFlag = new System.Windows.Forms.RadioButton();
			this.radioButtonMexicoFlag = new System.Windows.Forms.RadioButton();
			this.radioButtonCanadaFlag = new System.Windows.Forms.RadioButton();
			this.radioButtonNorthKoreaFlag = new System.Windows.Forms.RadioButton();
			this.groupBoxFlags = new System.Windows.Forms.GroupBox();
			this.pictureBoxFlag = new System.Windows.Forms.PictureBox();
			this.labelFlagName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelCountries = new System.Windows.Forms.Label();
			this.checkBoxHideTitle = new System.Windows.Forms.CheckBox();
			this.checkBoxHideFlagLabel = new System.Windows.Forms.CheckBox();
			this.checkBoxHideProgrammed = new System.Windows.Forms.CheckBox();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
			this.groupBoxFlags.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonExit
			// 
			this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonExit.Location = new System.Drawing.Point(370, 400);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 0;
			this.buttonExit.Text = "&Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// radioButtonUSFlag
			// 
			this.radioButtonUSFlag.AutoSize = true;
			this.radioButtonUSFlag.Location = new System.Drawing.Point(6, 19);
			this.radioButtonUSFlag.Name = "radioButtonUSFlag";
			this.radioButtonUSFlag.Size = new System.Drawing.Size(112, 17);
			this.radioButtonUSFlag.TabIndex = 5;
			this.radioButtonUSFlag.TabStop = true;
			this.radioButtonUSFlag.Text = "&United States Flag";
			this.radioButtonUSFlag.UseVisualStyleBackColor = true;
			this.radioButtonUSFlag.CheckedChanged += new System.EventHandler(this.radioButtonUSFlag_CheckedChanged);
			// 
			// radioButtonMexicoFlag
			// 
			this.radioButtonMexicoFlag.AutoSize = true;
			this.radioButtonMexicoFlag.Location = new System.Drawing.Point(6, 52);
			this.radioButtonMexicoFlag.Name = "radioButtonMexicoFlag";
			this.radioButtonMexicoFlag.Size = new System.Drawing.Size(82, 17);
			this.radioButtonMexicoFlag.TabIndex = 6;
			this.radioButtonMexicoFlag.TabStop = true;
			this.radioButtonMexicoFlag.Text = "&Mexico Flag";
			this.radioButtonMexicoFlag.UseVisualStyleBackColor = true;
			this.radioButtonMexicoFlag.CheckedChanged += new System.EventHandler(this.radioButtonMexicoFlag_CheckedChanged);
			// 
			// radioButtonCanadaFlag
			// 
			this.radioButtonCanadaFlag.AutoSize = true;
			this.radioButtonCanadaFlag.Location = new System.Drawing.Point(6, 85);
			this.radioButtonCanadaFlag.Name = "radioButtonCanadaFlag";
			this.radioButtonCanadaFlag.Size = new System.Drawing.Size(85, 17);
			this.radioButtonCanadaFlag.TabIndex = 7;
			this.radioButtonCanadaFlag.TabStop = true;
			this.radioButtonCanadaFlag.Text = "&Canada Flag";
			this.radioButtonCanadaFlag.UseVisualStyleBackColor = true;
			this.radioButtonCanadaFlag.CheckedChanged += new System.EventHandler(this.radioButtonCanadaFlag_CheckedChanged);
			// 
			// radioButtonNorthKoreaFlag
			// 
			this.radioButtonNorthKoreaFlag.AutoSize = true;
			this.radioButtonNorthKoreaFlag.Location = new System.Drawing.Point(6, 118);
			this.radioButtonNorthKoreaFlag.Name = "radioButtonNorthKoreaFlag";
			this.radioButtonNorthKoreaFlag.Size = new System.Drawing.Size(105, 17);
			this.radioButtonNorthKoreaFlag.TabIndex = 8;
			this.radioButtonNorthKoreaFlag.TabStop = true;
			this.radioButtonNorthKoreaFlag.Text = "&North Korea Flag";
			this.radioButtonNorthKoreaFlag.UseVisualStyleBackColor = true;
			this.radioButtonNorthKoreaFlag.CheckedChanged += new System.EventHandler(this.radioButtonNorthKoreaFlag_CheckedChanged);
			// 
			// groupBoxFlags
			// 
			this.groupBoxFlags.Controls.Add(this.radioButtonUSFlag);
			this.groupBoxFlags.Controls.Add(this.radioButtonNorthKoreaFlag);
			this.groupBoxFlags.Controls.Add(this.radioButtonMexicoFlag);
			this.groupBoxFlags.Controls.Add(this.radioButtonCanadaFlag);
			this.groupBoxFlags.Location = new System.Drawing.Point(12, 12);
			this.groupBoxFlags.Name = "groupBoxFlags";
			this.groupBoxFlags.Size = new System.Drawing.Size(157, 153);
			this.groupBoxFlags.TabIndex = 9;
			this.groupBoxFlags.TabStop = false;
			this.groupBoxFlags.Text = "&Flags:";
			// 
			// pictureBoxFlag
			// 
			this.pictureBoxFlag.Image = global::_2004193_Alexander_CountryFlags22.Properties.Resources.us;
			this.pictureBoxFlag.Location = new System.Drawing.Point(39, 171);
			this.pictureBoxFlag.Name = "pictureBoxFlag";
			this.pictureBoxFlag.Size = new System.Drawing.Size(378, 213);
			this.pictureBoxFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxFlag.TabIndex = 10;
			this.pictureBoxFlag.TabStop = false;
			// 
			// labelFlagName
			// 
			this.labelFlagName.AutoSize = true;
			this.labelFlagName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFlagName.Location = new System.Drawing.Point(166, 393);
			this.labelFlagName.Name = "labelFlagName";
			this.labelFlagName.Size = new System.Drawing.Size(124, 16);
			this.labelFlagName.TabIndex = 11;
			this.labelFlagName.Text = "Display Flag Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(287, 431);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Programmed by River Alexander";
			// 
			// labelCountries
			// 
			this.labelCountries.AutoSize = true;
			this.labelCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCountries.Location = new System.Drawing.Point(176, 31);
			this.labelCountries.Name = "labelCountries";
			this.labelCountries.Size = new System.Drawing.Size(104, 25);
			this.labelCountries.TabIndex = 13;
			this.labelCountries.Text = "Countries";
			// 
			// checkBoxHideTitle
			// 
			this.checkBoxHideTitle.AutoSize = true;
			this.checkBoxHideTitle.Location = new System.Drawing.Point(181, 65);
			this.checkBoxHideTitle.Name = "checkBoxHideTitle";
			this.checkBoxHideTitle.Size = new System.Drawing.Size(71, 17);
			this.checkBoxHideTitle.TabIndex = 14;
			this.checkBoxHideTitle.Text = "&Hide Title";
			this.checkBoxHideTitle.UseVisualStyleBackColor = true;
			this.checkBoxHideTitle.CheckedChanged += new System.EventHandler(this.checkBoxHideTitle_CheckedChanged);
			// 
			// checkBoxHideFlagLabel
			// 
			this.checkBoxHideFlagLabel.AutoSize = true;
			this.checkBoxHideFlagLabel.Location = new System.Drawing.Point(12, 424);
			this.checkBoxHideFlagLabel.Name = "checkBoxHideFlagLabel";
			this.checkBoxHideFlagLabel.Size = new System.Drawing.Size(100, 17);
			this.checkBoxHideFlagLabel.TabIndex = 15;
			this.checkBoxHideFlagLabel.Text = "Hide &Flag Label";
			this.checkBoxHideFlagLabel.UseVisualStyleBackColor = true;
			this.checkBoxHideFlagLabel.CheckedChanged += new System.EventHandler(this.checkBoxHideFlagLabel_CheckedChanged);
			// 
			// checkBoxHideProgrammed
			// 
			this.checkBoxHideProgrammed.AutoSize = true;
			this.checkBoxHideProgrammed.Location = new System.Drawing.Point(12, 400);
			this.checkBoxHideProgrammed.Name = "checkBoxHideProgrammed";
			this.checkBoxHideProgrammed.Size = new System.Drawing.Size(124, 17);
			this.checkBoxHideProgrammed.TabIndex = 16;
			this.checkBoxHideProgrammed.Text = "Hide &Programmed by";
			this.checkBoxHideProgrammed.UseVisualStyleBackColor = true;
			this.checkBoxHideProgrammed.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// buttonPrint
			// 
			this.buttonPrint.Location = new System.Drawing.Point(370, 142);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(75, 23);
			this.buttonPrint.TabIndex = 17;
			this.buttonPrint.Text = "&Print";
			this.buttonPrint.UseVisualStyleBackColor = true;
			this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
			// 
			// printForm1
			// 
			this.printForm1.DocumentName = "document";
			this.printForm1.Form = this;
			this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
			this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
			this.printForm1.PrintFileName = null;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonExit;
			this.ClientSize = new System.Drawing.Size(457, 453);
			this.Controls.Add(this.buttonPrint);
			this.Controls.Add(this.checkBoxHideProgrammed);
			this.Controls.Add(this.checkBoxHideFlagLabel);
			this.Controls.Add(this.checkBoxHideTitle);
			this.Controls.Add(this.labelCountries);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelFlagName);
			this.Controls.Add(this.pictureBoxFlag);
			this.Controls.Add(this.groupBoxFlags);
			this.Controls.Add(this.buttonExit);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Country Flags";
			this.groupBoxFlags.ResumeLayout(false);
			this.groupBoxFlags.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.RadioButton radioButtonUSFlag;
		private System.Windows.Forms.RadioButton radioButtonMexicoFlag;
		private System.Windows.Forms.RadioButton radioButtonCanadaFlag;
		private System.Windows.Forms.RadioButton radioButtonNorthKoreaFlag;
		private System.Windows.Forms.GroupBox groupBoxFlags;
		private System.Windows.Forms.PictureBox pictureBoxFlag;
		private System.Windows.Forms.Label labelFlagName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelCountries;
		private System.Windows.Forms.CheckBox checkBoxHideTitle;
		private System.Windows.Forms.CheckBox checkBoxHideFlagLabel;
		private System.Windows.Forms.CheckBox checkBoxHideProgrammed;
		private System.Windows.Forms.Button buttonPrint;
		private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
	}
}

