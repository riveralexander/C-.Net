namespace _2004193_Alexander_CoolBoards
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
			this.buttonDowntown = new System.Windows.Forms.Button();
			this.buttonMall = new System.Windows.Forms.Button();
			this.buttonSuburbs = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.labelStoreBranches = new System.Windows.Forms.Label();
			this.labelHoursLocation = new System.Windows.Forms.Label();
			this.labelDisplayDescription = new System.Windows.Forms.Label();
			this.labelProgram = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonDowntown
			// 
			this.buttonDowntown.Location = new System.Drawing.Point(12, 83);
			this.buttonDowntown.Name = "buttonDowntown";
			this.buttonDowntown.Size = new System.Drawing.Size(148, 38);
			this.buttonDowntown.TabIndex = 0;
			this.buttonDowntown.Text = "Downtown";
			this.buttonDowntown.UseVisualStyleBackColor = true;
			this.buttonDowntown.Click += new System.EventHandler(this.buttonDowntown_Click);
			// 
			// buttonMall
			// 
			this.buttonMall.Location = new System.Drawing.Point(12, 139);
			this.buttonMall.Name = "buttonMall";
			this.buttonMall.Size = new System.Drawing.Size(148, 38);
			this.buttonMall.TabIndex = 1;
			this.buttonMall.Text = "Mall";
			this.buttonMall.UseVisualStyleBackColor = true;
			this.buttonMall.Click += new System.EventHandler(this.buttonMall_Click);
			// 
			// buttonSuburbs
			// 
			this.buttonSuburbs.Location = new System.Drawing.Point(12, 195);
			this.buttonSuburbs.Name = "buttonSuburbs";
			this.buttonSuburbs.Size = new System.Drawing.Size(148, 38);
			this.buttonSuburbs.TabIndex = 2;
			this.buttonSuburbs.Text = "Suburbs";
			this.buttonSuburbs.UseVisualStyleBackColor = true;
			this.buttonSuburbs.Click += new System.EventHandler(this.buttonSuburbs_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(12, 251);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(148, 38);
			this.buttonExit.TabIndex = 3;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// labelStoreBranches
			// 
			this.labelStoreBranches.AutoSize = true;
			this.labelStoreBranches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStoreBranches.Location = new System.Drawing.Point(21, 43);
			this.labelStoreBranches.Name = "labelStoreBranches";
			this.labelStoreBranches.Size = new System.Drawing.Size(124, 20);
			this.labelStoreBranches.TabIndex = 4;
			this.labelStoreBranches.Text = "Store Branches:";
			// 
			// labelHoursLocation
			// 
			this.labelHoursLocation.AutoSize = true;
			this.labelHoursLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelHoursLocation.Location = new System.Drawing.Point(166, 83);
			this.labelHoursLocation.Name = "labelHoursLocation";
			this.labelHoursLocation.Size = new System.Drawing.Size(152, 20);
			this.labelHoursLocation.TabIndex = 5;
			this.labelHoursLocation.Text = "Location and Hours:";
			// 
			// labelDisplayDescription
			// 
			this.labelDisplayDescription.AutoSize = true;
			this.labelDisplayDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDisplayDescription.Location = new System.Drawing.Point(166, 118);
			this.labelDisplayDescription.Name = "labelDisplayDescription";
			this.labelDisplayDescription.Size = new System.Drawing.Size(203, 20);
			this.labelDisplayDescription.TabIndex = 6;
			this.labelDisplayDescription.Text = "Display Location and Hours";
			// 
			// labelProgram
			// 
			this.labelProgram.AutoSize = true;
			this.labelProgram.Location = new System.Drawing.Point(382, 294);
			this.labelProgram.Name = "labelProgram";
			this.labelProgram.Size = new System.Drawing.Size(158, 13);
			this.labelProgram.TabIndex = 7;
			this.labelProgram.Text = "Programmed by River Alexander";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonExit;
			this.ClientSize = new System.Drawing.Size(552, 316);
			this.Controls.Add(this.labelProgram);
			this.Controls.Add(this.labelDisplayDescription);
			this.Controls.Add(this.labelHoursLocation);
			this.Controls.Add(this.labelStoreBranches);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonSuburbs);
			this.Controls.Add(this.buttonMall);
			this.Controls.Add(this.buttonDowntown);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cool Boards";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonDowntown;
		private System.Windows.Forms.Button buttonMall;
		private System.Windows.Forms.Button buttonSuburbs;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Label labelStoreBranches;
		private System.Windows.Forms.Label labelHoursLocation;
		private System.Windows.Forms.Label labelDisplayDescription;
		private System.Windows.Forms.Label labelProgram;
	}
}

