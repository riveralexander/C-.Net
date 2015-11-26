namespace _2004193_Alexander_Unit5HandsOn
{
	partial class Form2
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxNumOfOrders = new System.Windows.Forms.TextBox();
			this.textBoxTotalSales = new System.Windows.Forms.TextBox();
			this.textBoxDrinksSold = new System.Windows.Forms.TextBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Drinks Sold";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Number of Orders";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Total Sales";
			// 
			// textBoxNumOfOrders
			// 
			this.textBoxNumOfOrders.Location = new System.Drawing.Point(132, 76);
			this.textBoxNumOfOrders.Name = "textBoxNumOfOrders";
			this.textBoxNumOfOrders.ReadOnly = true;
			this.textBoxNumOfOrders.Size = new System.Drawing.Size(51, 20);
			this.textBoxNumOfOrders.TabIndex = 3;
			this.textBoxNumOfOrders.TabStop = false;
			// 
			// textBoxTotalSales
			// 
			this.textBoxTotalSales.Location = new System.Drawing.Point(132, 109);
			this.textBoxTotalSales.Name = "textBoxTotalSales";
			this.textBoxTotalSales.ReadOnly = true;
			this.textBoxTotalSales.Size = new System.Drawing.Size(51, 20);
			this.textBoxTotalSales.TabIndex = 4;
			this.textBoxTotalSales.TabStop = false;
			// 
			// textBoxDrinksSold
			// 
			this.textBoxDrinksSold.Location = new System.Drawing.Point(132, 43);
			this.textBoxDrinksSold.Name = "textBoxDrinksSold";
			this.textBoxDrinksSold.ReadOnly = true;
			this.textBoxDrinksSold.Size = new System.Drawing.Size(51, 20);
			this.textBoxDrinksSold.TabIndex = 5;
			this.textBoxDrinksSold.TabStop = false;
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(132, 137);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 6;
			this.buttonOK.Text = "&OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// Form2
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(219, 172);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.textBoxDrinksSold);
			this.Controls.Add(this.textBoxTotalSales);
			this.Controls.Add(this.textBoxNumOfOrders);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Summary Info";
			this.Activated += new System.EventHandler(this.SummaryForm_Activated);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxNumOfOrders;
		private System.Windows.Forms.TextBox textBoxTotalSales;
		private System.Windows.Forms.TextBox textBoxDrinksSold;
		private System.Windows.Forms.Button buttonOK;
	}
}