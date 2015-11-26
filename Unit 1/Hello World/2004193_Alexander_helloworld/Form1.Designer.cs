namespace _2004193_Alexander_helloworld
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
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonSpanish = new System.Windows.Forms.Button();
			this.buttonEnglish = new System.Windows.Forms.Button();
			this.labelMessage = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonExit
			// 
			this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonExit.Location = new System.Drawing.Point(284, 223);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(100, 42);
			this.buttonExit.TabIndex = 0;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonSpanish
			// 
			this.buttonSpanish.Location = new System.Drawing.Point(284, 152);
			this.buttonSpanish.Name = "buttonSpanish";
			this.buttonSpanish.Size = new System.Drawing.Size(100, 42);
			this.buttonSpanish.TabIndex = 1;
			this.buttonSpanish.Text = "Espanol";
			this.buttonSpanish.UseVisualStyleBackColor = true;
			this.buttonSpanish.Click += new System.EventHandler(this.buttonSpanish_Click);
			// 
			// buttonEnglish
			// 
			this.buttonEnglish.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonEnglish.Location = new System.Drawing.Point(284, 80);
			this.buttonEnglish.Name = "buttonEnglish";
			this.buttonEnglish.Size = new System.Drawing.Size(100, 42);
			this.buttonEnglish.TabIndex = 2;
			this.buttonEnglish.Text = "English";
			this.buttonEnglish.UseVisualStyleBackColor = true;
			this.buttonEnglish.Click += new System.EventHandler(this.button3_Click);
			// 
			// labelMessage
			// 
			this.labelMessage.AutoSize = true;
			this.labelMessage.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMessage.Location = new System.Drawing.Point(12, 24);
			this.labelMessage.Name = "labelMessage";
			this.labelMessage.Size = new System.Drawing.Size(194, 33);
			this.labelMessage.TabIndex = 3;
			this.labelMessage.Text = "Display Message";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 238);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Programmed by River Alexander";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Name:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(80, 115);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(173, 20);
			this.textBoxName.TabIndex = 6;
			this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(397, 289);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelMessage);
			this.Controls.Add(this.buttonEnglish);
			this.Controls.Add(this.buttonSpanish);
			this.Controls.Add(this.buttonExit);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form1";
			this.Text = "hello world";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonSpanish;
		private System.Windows.Forms.Button buttonEnglish;
		private System.Windows.Forms.Label labelMessage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxName;
	}
}

