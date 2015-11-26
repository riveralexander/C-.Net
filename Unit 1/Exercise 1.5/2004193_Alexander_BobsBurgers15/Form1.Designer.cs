namespace _2004193_Alexander_BobsBurgers
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
			this.buttonSoupoftheDay = new System.Windows.Forms.Button();
			this.buttonChefsSpecial = new System.Windows.Forms.Button();
			this.buttonDailyFish = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.labelDisplayDescription = new System.Windows.Forms.Label();
			this.labelProgram = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonSoupoftheDay
			// 
			this.buttonSoupoftheDay.Location = new System.Drawing.Point(40, 40);
			this.buttonSoupoftheDay.Name = "buttonSoupoftheDay";
			this.buttonSoupoftheDay.Size = new System.Drawing.Size(127, 31);
			this.buttonSoupoftheDay.TabIndex = 0;
			this.buttonSoupoftheDay.Text = "Soup of the Day";
			this.buttonSoupoftheDay.UseVisualStyleBackColor = true;
			// 
			// buttonChefsSpecial
			// 
			this.buttonChefsSpecial.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonChefsSpecial.Location = new System.Drawing.Point(40, 101);
			this.buttonChefsSpecial.Name = "buttonChefsSpecial";
			this.buttonChefsSpecial.Size = new System.Drawing.Size(127, 31);
			this.buttonChefsSpecial.TabIndex = 1;
			this.buttonChefsSpecial.Text = "Chef\'s Special";
			this.buttonChefsSpecial.UseVisualStyleBackColor = true;
			this.buttonChefsSpecial.Click += new System.EventHandler(this.buttonChefsSpecial_Click);
			// 
			// buttonDailyFish
			// 
			this.buttonDailyFish.Location = new System.Drawing.Point(40, 162);
			this.buttonDailyFish.Name = "buttonDailyFish";
			this.buttonDailyFish.Size = new System.Drawing.Size(127, 31);
			this.buttonDailyFish.TabIndex = 2;
			this.buttonDailyFish.Text = "Daily Fish";
			this.buttonDailyFish.UseVisualStyleBackColor = true;
			this.buttonDailyFish.Click += new System.EventHandler(this.buttonDailyFish_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonExit.Location = new System.Drawing.Point(40, 223);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(127, 31);
			this.buttonExit.TabIndex = 3;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// labelDisplayDescription
			// 
			this.labelDisplayDescription.AutoSize = true;
			this.labelDisplayDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDisplayDescription.Location = new System.Drawing.Point(227, 72);
			this.labelDisplayDescription.Name = "labelDisplayDescription";
			this.labelDisplayDescription.Size = new System.Drawing.Size(94, 20);
			this.labelDisplayDescription.TabIndex = 4;
			this.labelDisplayDescription.Text = "Display Text";
			// 
			// labelProgram
			// 
			this.labelProgram.AutoSize = true;
			this.labelProgram.Location = new System.Drawing.Point(405, 310);
			this.labelProgram.Name = "labelProgram";
			this.labelProgram.Size = new System.Drawing.Size(158, 13);
			this.labelProgram.TabIndex = 5;
			this.labelProgram.Text = "Programmed by River Alexander";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonExit;
			this.ClientSize = new System.Drawing.Size(575, 332);
			this.Controls.Add(this.labelProgram);
			this.Controls.Add(this.labelDisplayDescription);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonDailyFish);
			this.Controls.Add(this.buttonChefsSpecial);
			this.Controls.Add(this.buttonSoupoftheDay);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bob\'s Burgers";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSoupoftheDay;
		private System.Windows.Forms.Button buttonChefsSpecial;
		private System.Windows.Forms.Button buttonDailyFish;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Label labelDisplayDescription;
		private System.Windows.Forms.Label labelProgram;
	}
}

