namespace _2004193_Alexander_ProgrammingExercise54
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxBooks = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPoints = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonCalculate = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonSummary = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointsToolStripMenuItem,
            this.summaryToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// pointsToolStripMenuItem
			// 
			this.pointsToolStripMenuItem.Name = "pointsToolStripMenuItem";
			this.pointsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.pointsToolStripMenuItem.Text = "&Points";
			this.pointsToolStripMenuItem.Click += new System.EventHandler(this.pointsToolStripMenuItem_Click);
			// 
			// summaryToolStripMenuItem
			// 
			this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
			this.summaryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.summaryToolStripMenuItem.Text = "&Summary";
			this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
			// 
			// printToolStripMenuItem
			// 
			this.printToolStripMenuItem.Name = "printToolStripMenuItem";
			this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.printToolStripMenuItem.Text = "Prin&t";
			this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.toolStripSeparator1,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// clearToolStripMenuItem
			// 
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.clearToolStripMenuItem.Text = "C&lear";
			this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
			// 
			// fontToolStripMenuItem
			// 
			this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
			this.fontToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.fontToolStripMenuItem.Text = "&Font...";
			this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
			// 
			// colorToolStripMenuItem
			// 
			this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
			this.colorToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.colorToolStripMenuItem.Text = "&Color...";
			this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// printForm1
			// 
			this.printForm1.DocumentName = "document";
			this.printForm1.Form = this;
			this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
			this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
			this.printForm1.PrintFileName = null;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(69, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name:";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(113, 50);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(100, 20);
			this.textBoxName.TabIndex = 2;
			// 
			// textBoxBooks
			// 
			this.textBoxBooks.Location = new System.Drawing.Point(164, 79);
			this.textBoxBooks.Name = "textBoxBooks";
			this.textBoxBooks.Size = new System.Drawing.Size(49, 20);
			this.textBoxBooks.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(69, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "# of Books Read:";
			// 
			// textBoxPoints
			// 
			this.textBoxPoints.Location = new System.Drawing.Point(164, 108);
			this.textBoxPoints.Name = "textBoxPoints";
			this.textBoxPoints.ReadOnly = true;
			this.textBoxPoints.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textBoxPoints.Size = new System.Drawing.Size(49, 20);
			this.textBoxPoints.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(69, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "# of Bonus Points:";
			// 
			// buttonCalculate
			// 
			this.buttonCalculate.Location = new System.Drawing.Point(12, 146);
			this.buttonCalculate.Name = "buttonCalculate";
			this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
			this.buttonCalculate.TabIndex = 7;
			this.buttonCalculate.Text = "&Calculate";
			this.buttonCalculate.UseVisualStyleBackColor = true;
			this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(12, 175);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 23);
			this.buttonClear.TabIndex = 8;
			this.buttonClear.Text = "C&lear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonSummary
			// 
			this.buttonSummary.Location = new System.Drawing.Point(197, 146);
			this.buttonSummary.Name = "buttonSummary";
			this.buttonSummary.Size = new System.Drawing.Size(75, 23);
			this.buttonSummary.TabIndex = 9;
			this.buttonSummary.Text = "&Summary";
			this.buttonSummary.UseVisualStyleBackColor = true;
			this.buttonSummary.Click += new System.EventHandler(this.buttonSummary_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonExit.Location = new System.Drawing.Point(197, 175);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 10;
			this.buttonExit.Text = "E&xit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.buttonCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonExit;
			this.ClientSize = new System.Drawing.Size(284, 212);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonSummary);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonCalculate);
			this.Controls.Add(this.textBoxPoints);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxBooks);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Library Reading Program";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pointsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.FontDialog fontDialog1;
		private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonSummary;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonCalculate;
		private System.Windows.Forms.TextBox textBoxPoints;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxBooks;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label1;
	}
}

