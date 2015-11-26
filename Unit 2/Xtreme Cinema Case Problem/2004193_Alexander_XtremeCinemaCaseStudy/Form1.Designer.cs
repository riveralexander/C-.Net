namespace _2004193_Alexander_XtremeCinemaCaseStudy
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
			this.groupBoxGenres = new System.Windows.Forms.GroupBox();
			this.radioButtonNewReleases = new System.Windows.Forms.RadioButton();
			this.radioButtonHorror = new System.Windows.Forms.RadioButton();
			this.radioButtonSciFi = new System.Windows.Forms.RadioButton();
			this.radioButtonAction = new System.Windows.Forms.RadioButton();
			this.radioButtonDrama = new System.Windows.Forms.RadioButton();
			this.radioButtonComedy = new System.Windows.Forms.RadioButton();
			this.labelLocation = new System.Windows.Forms.Label();
			this.labelAisle = new System.Windows.Forms.Label();
			this.checkBoxMembersOnly = new System.Windows.Forms.CheckBox();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.labelXtremeCinema = new System.Windows.Forms.Label();
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.labelMembers = new System.Windows.Forms.Label();
			this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBoxGenres.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxGenres
			// 
			this.groupBoxGenres.Controls.Add(this.radioButtonNewReleases);
			this.groupBoxGenres.Controls.Add(this.radioButtonHorror);
			this.groupBoxGenres.Controls.Add(this.radioButtonSciFi);
			this.groupBoxGenres.Controls.Add(this.radioButtonAction);
			this.groupBoxGenres.Controls.Add(this.radioButtonDrama);
			this.groupBoxGenres.Controls.Add(this.radioButtonComedy);
			this.groupBoxGenres.Location = new System.Drawing.Point(25, 61);
			this.groupBoxGenres.Name = "groupBoxGenres";
			this.groupBoxGenres.Size = new System.Drawing.Size(139, 172);
			this.groupBoxGenres.TabIndex = 0;
			this.groupBoxGenres.TabStop = false;
			this.groupBoxGenres.Text = "Genres";
			// 
			// radioButtonNewReleases
			// 
			this.radioButtonNewReleases.AutoSize = true;
			this.radioButtonNewReleases.Location = new System.Drawing.Point(6, 144);
			this.radioButtonNewReleases.Name = "radioButtonNewReleases";
			this.radioButtonNewReleases.Size = new System.Drawing.Size(94, 17);
			this.radioButtonNewReleases.TabIndex = 5;
			this.radioButtonNewReleases.Text = "New Releases";
			this.radioButtonNewReleases.UseVisualStyleBackColor = true;
			this.radioButtonNewReleases.CheckedChanged += new System.EventHandler(this.radioButtonNewReleases_CheckedChanged);
			// 
			// radioButtonHorror
			// 
			this.radioButtonHorror.AutoSize = true;
			this.radioButtonHorror.Location = new System.Drawing.Point(6, 119);
			this.radioButtonHorror.Name = "radioButtonHorror";
			this.radioButtonHorror.Size = new System.Drawing.Size(54, 17);
			this.radioButtonHorror.TabIndex = 4;
			this.radioButtonHorror.Text = "Horror";
			this.radioButtonHorror.UseVisualStyleBackColor = true;
			this.radioButtonHorror.CheckedChanged += new System.EventHandler(this.radioButtonHorror_CheckedChanged);
			// 
			// radioButtonSciFi
			// 
			this.radioButtonSciFi.AutoSize = true;
			this.radioButtonSciFi.Location = new System.Drawing.Point(6, 94);
			this.radioButtonSciFi.Name = "radioButtonSciFi";
			this.radioButtonSciFi.Size = new System.Drawing.Size(51, 17);
			this.radioButtonSciFi.TabIndex = 3;
			this.radioButtonSciFi.Text = "Sci-Fi";
			this.radioButtonSciFi.UseVisualStyleBackColor = true;
			this.radioButtonSciFi.CheckedChanged += new System.EventHandler(this.radioButtonSciFi_CheckedChanged);
			// 
			// radioButtonAction
			// 
			this.radioButtonAction.AutoSize = true;
			this.radioButtonAction.Location = new System.Drawing.Point(6, 69);
			this.radioButtonAction.Name = "radioButtonAction";
			this.radioButtonAction.Size = new System.Drawing.Size(55, 17);
			this.radioButtonAction.TabIndex = 2;
			this.radioButtonAction.Text = "Action";
			this.radioButtonAction.UseVisualStyleBackColor = true;
			this.radioButtonAction.CheckedChanged += new System.EventHandler(this.radioButtonAction_CheckedChanged);
			// 
			// radioButtonDrama
			// 
			this.radioButtonDrama.AutoSize = true;
			this.radioButtonDrama.Location = new System.Drawing.Point(6, 44);
			this.radioButtonDrama.Name = "radioButtonDrama";
			this.radioButtonDrama.Size = new System.Drawing.Size(56, 17);
			this.radioButtonDrama.TabIndex = 1;
			this.radioButtonDrama.Text = "Drama";
			this.radioButtonDrama.UseVisualStyleBackColor = true;
			this.radioButtonDrama.CheckedChanged += new System.EventHandler(this.radioButtonDrama_CheckedChanged);
			// 
			// radioButtonComedy
			// 
			this.radioButtonComedy.AutoSize = true;
			this.radioButtonComedy.Location = new System.Drawing.Point(6, 19);
			this.radioButtonComedy.Name = "radioButtonComedy";
			this.radioButtonComedy.Size = new System.Drawing.Size(63, 17);
			this.radioButtonComedy.TabIndex = 0;
			this.radioButtonComedy.Text = "Comedy";
			this.radioButtonComedy.UseVisualStyleBackColor = true;
			this.radioButtonComedy.CheckedChanged += new System.EventHandler(this.radioButtonComedy_CheckedChanged);
			// 
			// labelLocation
			// 
			this.labelLocation.AutoSize = true;
			this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLocation.Location = new System.Drawing.Point(261, 61);
			this.labelLocation.Name = "labelLocation";
			this.labelLocation.Size = new System.Drawing.Size(94, 25);
			this.labelLocation.TabIndex = 1;
			this.labelLocation.Text = "Location";
			// 
			// labelAisle
			// 
			this.labelAisle.AutoSize = true;
			this.labelAisle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAisle.Location = new System.Drawing.Point(284, 105);
			this.labelAisle.Name = "labelAisle";
			this.labelAisle.Size = new System.Drawing.Size(43, 20);
			this.labelAisle.TabIndex = 2;
			this.labelAisle.Text = "Aisle";
			// 
			// checkBoxMembersOnly
			// 
			this.checkBoxMembersOnly.AutoSize = true;
			this.checkBoxMembersOnly.Location = new System.Drawing.Point(25, 336);
			this.checkBoxMembersOnly.Name = "checkBoxMembersOnly";
			this.checkBoxMembersOnly.Size = new System.Drawing.Size(93, 17);
			this.checkBoxMembersOnly.TabIndex = 3;
			this.checkBoxMembersOnly.Text = "&Members Only";
			this.checkBoxMembersOnly.UseVisualStyleBackColor = true;
			this.checkBoxMembersOnly.CheckedChanged += new System.EventHandler(this.checkBoxMembersOnly_CheckedChanged);
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(405, 283);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 23);
			this.buttonClear.TabIndex = 4;
			this.buttonClear.Text = "&Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonPrint
			// 
			this.buttonPrint.Location = new System.Drawing.Point(405, 312);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(75, 23);
			this.buttonPrint.TabIndex = 5;
			this.buttonPrint.Text = "&Print";
			this.buttonPrint.UseVisualStyleBackColor = true;
			this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonExit.Location = new System.Drawing.Point(405, 341);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 6;
			this.buttonExit.Text = "&Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// labelXtremeCinema
			// 
			this.labelXtremeCinema.AutoSize = true;
			this.labelXtremeCinema.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelXtremeCinema.Location = new System.Drawing.Point(130, 9);
			this.labelXtremeCinema.Name = "labelXtremeCinema";
			this.labelXtremeCinema.Size = new System.Drawing.Size(238, 37);
			this.labelXtremeCinema.TabIndex = 7;
			this.labelXtremeCinema.Text = "Xtreme Cinema";
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
			this.shapeContainer1.Size = new System.Drawing.Size(492, 375);
			this.shapeContainer1.TabIndex = 8;
			this.shapeContainer1.TabStop = false;
			// 
			// lineShape1
			// 
			this.lineShape1.Name = "lineShape1";
			this.lineShape1.X1 = -9;
			this.lineShape1.X2 = 502;
			this.lineShape1.Y1 = 48;
			this.lineShape1.Y2 = 47;
			// 
			// labelMembers
			// 
			this.labelMembers.AutoSize = true;
			this.labelMembers.Location = new System.Drawing.Point(22, 303);
			this.labelMembers.Name = "labelMembers";
			this.labelMembers.Size = new System.Drawing.Size(184, 13);
			this.labelMembers.TabIndex = 9;
			this.labelMembers.Text = "All Members Receive a 10% Discount";
			// 
			// printForm1
			// 
			this.printForm1.DocumentName = "document";
			this.printForm1.Form = this;
			this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
			this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
			this.printForm1.PrintFileName = null;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::_2004193_Alexander_XtremeCinemaCaseStudy.Properties.Resources.cinema;
			this.pictureBox1.Location = new System.Drawing.Point(207, 155);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(207, 105);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AcceptButton = this.buttonClear;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonExit;
			this.ClientSize = new System.Drawing.Size(492, 375);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.labelMembers);
			this.Controls.Add(this.labelXtremeCinema);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonPrint);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.checkBoxMembersOnly);
			this.Controls.Add(this.labelAisle);
			this.Controls.Add(this.labelLocation);
			this.Controls.Add(this.groupBoxGenres);
			this.Controls.Add(this.shapeContainer1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Xtreme Cinema";
			this.groupBoxGenres.ResumeLayout(false);
			this.groupBoxGenres.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxGenres;
		private System.Windows.Forms.RadioButton radioButtonNewReleases;
		private System.Windows.Forms.RadioButton radioButtonHorror;
		private System.Windows.Forms.RadioButton radioButtonSciFi;
		private System.Windows.Forms.RadioButton radioButtonAction;
		private System.Windows.Forms.RadioButton radioButtonDrama;
		private System.Windows.Forms.RadioButton radioButtonComedy;
		private System.Windows.Forms.Label labelLocation;
		private System.Windows.Forms.Label labelAisle;
		private System.Windows.Forms.CheckBox checkBoxMembersOnly;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonPrint;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Label labelXtremeCinema;
		private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
		private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
		private System.Windows.Forms.Label labelMembers;
		private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

