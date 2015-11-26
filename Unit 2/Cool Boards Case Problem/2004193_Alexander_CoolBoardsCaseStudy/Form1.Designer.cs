namespace _2004193_Alexander_CoolBoardsCaseStudy
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
			this.labelCompanyName = new System.Windows.Forms.Label();
			this.labelProgrammer = new System.Windows.Forms.Label();
			this.labelSlogan = new System.Windows.Forms.Label();
			this.pictureBoxSkateboard = new System.Windows.Forms.PictureBox();
			this.radioButtonRed = new System.Windows.Forms.RadioButton();
			this.radioButtonGreen = new System.Windows.Forms.RadioButton();
			this.radioButtonBlue = new System.Windows.Forms.RadioButton();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.checkBoxHideLogo = new System.Windows.Forms.CheckBox();
			this.checkBoxHideSlogan = new System.Windows.Forms.CheckBox();
			this.checkBoxHideCompanyName = new System.Windows.Forms.CheckBox();
			this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
			this.buttonExit = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkateboard)).BeginInit();
			this.SuspendLayout();
			// 
			// labelCompanyName
			// 
			this.labelCompanyName.AutoSize = true;
			this.labelCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCompanyName.Location = new System.Drawing.Point(179, 33);
			this.labelCompanyName.Name = "labelCompanyName";
			this.labelCompanyName.Size = new System.Drawing.Size(130, 25);
			this.labelCompanyName.TabIndex = 0;
			this.labelCompanyName.Text = "Cool Boards";
			this.toolTip1.SetToolTip(this.labelCompanyName, " ");
			// 
			// labelProgrammer
			// 
			this.labelProgrammer.AutoSize = true;
			this.labelProgrammer.Location = new System.Drawing.Point(319, 371);
			this.labelProgrammer.Name = "labelProgrammer";
			this.labelProgrammer.Size = new System.Drawing.Size(158, 13);
			this.labelProgrammer.TabIndex = 1;
			this.labelProgrammer.Text = "Programmed by River Alexander";
			// 
			// labelSlogan
			// 
			this.labelSlogan.AutoSize = true;
			this.labelSlogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSlogan.Location = new System.Drawing.Point(165, 68);
			this.labelSlogan.Name = "labelSlogan";
			this.labelSlogan.Size = new System.Drawing.Size(159, 16);
			this.labelSlogan.TabIndex = 2;
			this.labelSlogan.Text = "\"The very best in boards\"";
			this.toolTip1.SetToolTip(this.labelSlogan, " ");
			// 
			// pictureBoxSkateboard
			// 
			this.pictureBoxSkateboard.Image = global::_2004193_Alexander_CoolBoardsCaseStudy.Properties.Resources.skateboard;
			this.pictureBoxSkateboard.Location = new System.Drawing.Point(90, 103);
			this.pictureBoxSkateboard.Name = "pictureBoxSkateboard";
			this.pictureBoxSkateboard.Size = new System.Drawing.Size(308, 168);
			this.pictureBoxSkateboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxSkateboard.TabIndex = 3;
			this.pictureBoxSkateboard.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBoxSkateboard, " ");
			// 
			// radioButtonRed
			// 
			this.radioButtonRed.AutoSize = true;
			this.radioButtonRed.Location = new System.Drawing.Point(12, 12);
			this.radioButtonRed.Name = "radioButtonRed";
			this.radioButtonRed.Size = new System.Drawing.Size(81, 17);
			this.radioButtonRed.TabIndex = 4;
			this.radioButtonRed.TabStop = true;
			this.radioButtonRed.Text = "&Red Slogan";
			this.radioButtonRed.UseVisualStyleBackColor = true;
			this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButtonRed_CheckedChanged);
			// 
			// radioButtonGreen
			// 
			this.radioButtonGreen.AutoSize = true;
			this.radioButtonGreen.Location = new System.Drawing.Point(12, 35);
			this.radioButtonGreen.Name = "radioButtonGreen";
			this.radioButtonGreen.Size = new System.Drawing.Size(90, 17);
			this.radioButtonGreen.TabIndex = 5;
			this.radioButtonGreen.TabStop = true;
			this.radioButtonGreen.Text = "&Green Slogan";
			this.radioButtonGreen.UseVisualStyleBackColor = true;
			this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.radioButtonGreen_CheckedChanged);
			// 
			// radioButtonBlue
			// 
			this.radioButtonBlue.AutoSize = true;
			this.radioButtonBlue.Location = new System.Drawing.Point(12, 58);
			this.radioButtonBlue.Name = "radioButtonBlue";
			this.radioButtonBlue.Size = new System.Drawing.Size(82, 17);
			this.radioButtonBlue.TabIndex = 6;
			this.radioButtonBlue.TabStop = true;
			this.radioButtonBlue.Text = "&Blue Slogan";
			this.radioButtonBlue.UseVisualStyleBackColor = true;
			this.radioButtonBlue.CheckedChanged += new System.EventHandler(this.radioButtonBlue_CheckedChanged);
			// 
			// buttonPrint
			// 
			this.buttonPrint.Location = new System.Drawing.Point(12, 282);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(75, 23);
			this.buttonPrint.TabIndex = 7;
			this.buttonPrint.Text = "Print";
			this.buttonPrint.UseVisualStyleBackColor = true;
			this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
			// 
			// checkBoxHideLogo
			// 
			this.checkBoxHideLogo.AutoSize = true;
			this.checkBoxHideLogo.Checked = true;
			this.checkBoxHideLogo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxHideLogo.Location = new System.Drawing.Point(7, 370);
			this.checkBoxHideLogo.Name = "checkBoxHideLogo";
			this.checkBoxHideLogo.Size = new System.Drawing.Size(80, 17);
			this.checkBoxHideLogo.TabIndex = 8;
			this.checkBoxHideLogo.Text = "Show Logo";
			this.checkBoxHideLogo.UseVisualStyleBackColor = true;
			this.checkBoxHideLogo.CheckedChanged += new System.EventHandler(this.checkBoxHideLogo_CheckedChanged);
			// 
			// checkBoxHideSlogan
			// 
			this.checkBoxHideSlogan.AutoSize = true;
			this.checkBoxHideSlogan.Checked = true;
			this.checkBoxHideSlogan.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxHideSlogan.Location = new System.Drawing.Point(7, 347);
			this.checkBoxHideSlogan.Name = "checkBoxHideSlogan";
			this.checkBoxHideSlogan.Size = new System.Drawing.Size(89, 17);
			this.checkBoxHideSlogan.TabIndex = 9;
			this.checkBoxHideSlogan.Text = "Show Slogan";
			this.checkBoxHideSlogan.UseVisualStyleBackColor = true;
			this.checkBoxHideSlogan.CheckedChanged += new System.EventHandler(this.checkBoxHideSlogan_CheckedChanged);
			// 
			// checkBoxHideCompanyName
			// 
			this.checkBoxHideCompanyName.AutoSize = true;
			this.checkBoxHideCompanyName.Checked = true;
			this.checkBoxHideCompanyName.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxHideCompanyName.Location = new System.Drawing.Point(7, 324);
			this.checkBoxHideCompanyName.Name = "checkBoxHideCompanyName";
			this.checkBoxHideCompanyName.Size = new System.Drawing.Size(131, 17);
			this.checkBoxHideCompanyName.TabIndex = 10;
			this.checkBoxHideCompanyName.Text = "Show Company Name";
			this.checkBoxHideCompanyName.UseVisualStyleBackColor = true;
			this.checkBoxHideCompanyName.CheckedChanged += new System.EventHandler(this.checkBoxHideCompanyName_CheckedChanged);
			// 
			// printForm1
			// 
			this.printForm1.DocumentName = "document";
			this.printForm1.Form = this;
			this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
			this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
			this.printForm1.PrintFileName = null;
			// 
			// buttonExit
			// 
			this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonExit.Location = new System.Drawing.Point(402, 341);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 11;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// toolTip1
			// 
			this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonExit;
			this.ClientSize = new System.Drawing.Size(489, 393);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.checkBoxHideCompanyName);
			this.Controls.Add(this.checkBoxHideSlogan);
			this.Controls.Add(this.checkBoxHideLogo);
			this.Controls.Add(this.buttonPrint);
			this.Controls.Add(this.radioButtonBlue);
			this.Controls.Add(this.radioButtonGreen);
			this.Controls.Add(this.radioButtonRed);
			this.Controls.Add(this.pictureBoxSkateboard);
			this.Controls.Add(this.labelSlogan);
			this.Controls.Add(this.labelProgrammer);
			this.Controls.Add(this.labelCompanyName);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cool Boards";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkateboard)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelCompanyName;
		private System.Windows.Forms.Label labelProgrammer;
		private System.Windows.Forms.Label labelSlogan;
		private System.Windows.Forms.PictureBox pictureBoxSkateboard;
		private System.Windows.Forms.RadioButton radioButtonRed;
		private System.Windows.Forms.RadioButton radioButtonGreen;
		private System.Windows.Forms.RadioButton radioButtonBlue;
		private System.Windows.Forms.Button buttonPrint;
		private System.Windows.Forms.CheckBox checkBoxHideLogo;
		private System.Windows.Forms.CheckBox checkBoxHideSlogan;
		private System.Windows.Forms.CheckBox checkBoxHideCompanyName;
		private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}

