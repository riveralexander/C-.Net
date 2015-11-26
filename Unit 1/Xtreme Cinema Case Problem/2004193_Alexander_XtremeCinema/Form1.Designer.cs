namespace _2004193_Alexander_XtremeCinema
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
			this.buttonComedy = new System.Windows.Forms.Button();
			this.buttonDrama = new System.Windows.Forms.Button();
			this.buttonAction = new System.Windows.Forms.Button();
			this.buttonSciFi = new System.Windows.Forms.Button();
			this.buttonHorror = new System.Windows.Forms.Button();
			this.buttonNewReleases = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.labelAisle = new System.Windows.Forms.Label();
			this.labelProgram = new System.Windows.Forms.Label();
			this.labelLocation = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonComedy
			// 
			this.buttonComedy.Location = new System.Drawing.Point(12, 9);
			this.buttonComedy.Name = "buttonComedy";
			this.buttonComedy.Size = new System.Drawing.Size(96, 25);
			this.buttonComedy.TabIndex = 0;
			this.buttonComedy.Text = "Comedy";
			this.buttonComedy.UseVisualStyleBackColor = true;
			this.buttonComedy.Click += new System.EventHandler(this.buttonComedy_Click);
			// 
			// buttonDrama
			// 
			this.buttonDrama.Location = new System.Drawing.Point(12, 50);
			this.buttonDrama.Name = "buttonDrama";
			this.buttonDrama.Size = new System.Drawing.Size(96, 25);
			this.buttonDrama.TabIndex = 1;
			this.buttonDrama.Text = "Drama";
			this.buttonDrama.UseVisualStyleBackColor = true;
			this.buttonDrama.Click += new System.EventHandler(this.buttonDrama_Click);
			// 
			// buttonAction
			// 
			this.buttonAction.Location = new System.Drawing.Point(12, 91);
			this.buttonAction.Name = "buttonAction";
			this.buttonAction.Size = new System.Drawing.Size(96, 25);
			this.buttonAction.TabIndex = 2;
			this.buttonAction.Text = "Action";
			this.buttonAction.UseVisualStyleBackColor = true;
			this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
			// 
			// buttonSciFi
			// 
			this.buttonSciFi.Location = new System.Drawing.Point(12, 132);
			this.buttonSciFi.Name = "buttonSciFi";
			this.buttonSciFi.Size = new System.Drawing.Size(96, 25);
			this.buttonSciFi.TabIndex = 3;
			this.buttonSciFi.Text = "Sci-Fi";
			this.buttonSciFi.UseVisualStyleBackColor = true;
			this.buttonSciFi.Click += new System.EventHandler(this.buttonSciFi_Click);
			// 
			// buttonHorror
			// 
			this.buttonHorror.Location = new System.Drawing.Point(12, 173);
			this.buttonHorror.Name = "buttonHorror";
			this.buttonHorror.Size = new System.Drawing.Size(96, 25);
			this.buttonHorror.TabIndex = 4;
			this.buttonHorror.Text = "Horror";
			this.buttonHorror.UseVisualStyleBackColor = true;
			this.buttonHorror.Click += new System.EventHandler(this.buttonHorror_Click);
			// 
			// buttonNewReleases
			// 
			this.buttonNewReleases.Location = new System.Drawing.Point(12, 214);
			this.buttonNewReleases.Name = "buttonNewReleases";
			this.buttonNewReleases.Size = new System.Drawing.Size(96, 25);
			this.buttonNewReleases.TabIndex = 5;
			this.buttonNewReleases.Text = "New Releases";
			this.buttonNewReleases.UseVisualStyleBackColor = true;
			this.buttonNewReleases.Click += new System.EventHandler(this.buttonNewReleases_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonExit.Location = new System.Drawing.Point(12, 255);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(96, 25);
			this.buttonExit.TabIndex = 6;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// labelAisle
			// 
			this.labelAisle.AutoSize = true;
			this.labelAisle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAisle.Location = new System.Drawing.Point(177, 77);
			this.labelAisle.Name = "labelAisle";
			this.labelAisle.Size = new System.Drawing.Size(136, 25);
			this.labelAisle.TabIndex = 7;
			this.labelAisle.Text = "Display Aisle";
			// 
			// labelProgram
			// 
			this.labelProgram.AutoSize = true;
			this.labelProgram.Location = new System.Drawing.Point(247, 274);
			this.labelProgram.Name = "labelProgram";
			this.labelProgram.Size = new System.Drawing.Size(158, 13);
			this.labelProgram.TabIndex = 8;
			this.labelProgram.Text = "Programmed by River Alexander";
			// 
			// labelLocation
			// 
			this.labelLocation.AutoSize = true;
			this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLocation.Location = new System.Drawing.Point(177, 47);
			this.labelLocation.Name = "labelLocation";
			this.labelLocation.Size = new System.Drawing.Size(100, 25);
			this.labelLocation.TabIndex = 9;
			this.labelLocation.Text = "Location:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonExit;
			this.ClientSize = new System.Drawing.Size(417, 296);
			this.Controls.Add(this.labelLocation);
			this.Controls.Add(this.labelProgram);
			this.Controls.Add(this.labelAisle);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonNewReleases);
			this.Controls.Add(this.buttonHorror);
			this.Controls.Add(this.buttonSciFi);
			this.Controls.Add(this.buttonAction);
			this.Controls.Add(this.buttonDrama);
			this.Controls.Add(this.buttonComedy);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Xtreme Cinema";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonComedy;
		private System.Windows.Forms.Button buttonDrama;
		private System.Windows.Forms.Button buttonAction;
		private System.Windows.Forms.Button buttonSciFi;
		private System.Windows.Forms.Button buttonHorror;
		private System.Windows.Forms.Button buttonNewReleases;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Label labelAisle;
		private System.Windows.Forms.Label labelProgram;
		private System.Windows.Forms.Label labelLocation;
	}
}

