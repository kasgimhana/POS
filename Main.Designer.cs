namespace BILLING_SOFTWARE
{
	partial class Main
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
			this.label4 = new System.Windows.Forms.Label();
			this.txtPname = new System.Windows.Forms.TextBox();
			this.txtPPrice = new System.Windows.Forms.TextBox();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.btnInsert = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.BtnUpdateQty = new System.Windows.Forms.Button();
			this.btnM = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(255, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 37);
			this.label1.TabIndex = 12;
			this.label1.Text = "Stock";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(180, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Product Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(184, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Product Price";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(215, 135);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "Quantity";
			// 
			// txtPname
			// 
			this.txtPname.Location = new System.Drawing.Point(262, 76);
			this.txtPname.Name = "txtPname";
			this.txtPname.Size = new System.Drawing.Size(100, 20);
			this.txtPname.TabIndex = 16;
			// 
			// txtPPrice
			// 
			this.txtPPrice.Location = new System.Drawing.Point(262, 100);
			this.txtPPrice.Name = "txtPPrice";
			this.txtPPrice.Size = new System.Drawing.Size(100, 20);
			this.txtPPrice.TabIndex = 17;
			// 
			// txtQty
			// 
			this.txtQty.Location = new System.Drawing.Point(261, 128);
			this.txtQty.Name = "txtQty";
			this.txtQty.Size = new System.Drawing.Size(100, 20);
			this.txtQty.TabIndex = 18;
			// 
			// btnInsert
			// 
			this.btnInsert.Location = new System.Drawing.Point(120, 170);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(69, 23);
			this.btnInsert.TabIndex = 19;
			this.btnInsert.Text = "Insert";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(249, 170);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(69, 23);
			this.btnDelete.TabIndex = 20;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// BtnUpdateQty
			// 
			this.BtnUpdateQty.Location = new System.Drawing.Point(391, 170);
			this.BtnUpdateQty.Name = "BtnUpdateQty";
			this.BtnUpdateQty.Size = new System.Drawing.Size(78, 23);
			this.BtnUpdateQty.TabIndex = 21;
			this.BtnUpdateQty.Text = "Update Qty";
			this.BtnUpdateQty.UseVisualStyleBackColor = true;
			this.BtnUpdateQty.Click += new System.EventHandler(this.BtnupdateQty_Click);
			// 
			// btnM
			// 
			this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnM.Location = new System.Drawing.Point(218, 429);
			this.btnM.Name = "btnM";
			this.btnM.Size = new System.Drawing.Size(110, 30);
			this.btnM.TabIndex = 86;
			this.btnM.Text = "Back";
			this.btnM.UseVisualStyleBackColor = true;
			this.btnM.Click += new System.EventHandler(this.btnM_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(120, 209);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(349, 195);
			this.dataGridView.TabIndex = 23;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(620, 491);
			this.Controls.Add(this.btnM);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.BtnUpdateQty);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.txtQty);
			this.Controls.Add(this.txtPPrice);
			this.Controls.Add(this.txtPname);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPname;
		private System.Windows.Forms.TextBox txtPPrice;
		private System.Windows.Forms.TextBox txtQty;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button BtnUpdateQty;
		private System.Windows.Forms.Button btnM;
		private System.Windows.Forms.DataGridView dataGridView;
	}
}