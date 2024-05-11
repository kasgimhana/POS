namespace BILLING_SOFTWARE
{
	partial class User
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
			this.btnM = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.BtnCPass = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnInsert = new System.Windows.Forms.Button();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.txtEMID = new System.Windows.Forms.TextBox();
			this.txtUserN = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// btnM
			// 
			this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnM.Location = new System.Drawing.Point(316, 434);
			this.btnM.Name = "btnM";
			this.btnM.Size = new System.Drawing.Size(110, 30);
			this.btnM.TabIndex = 98;
			this.btnM.Text = "Back";
			this.btnM.UseVisualStyleBackColor = true;
			this.btnM.Click += new System.EventHandler(this.btnM_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(188, 225);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(369, 184);
			this.dataGridView.TabIndex = 97;
			// 
			// BtnCPass
			// 
			this.BtnCPass.Location = new System.Drawing.Point(454, 182);
			this.BtnCPass.Name = "BtnCPass";
			this.BtnCPass.Size = new System.Drawing.Size(103, 23);
			this.BtnCPass.TabIndex = 95;
			this.BtnCPass.Text = "Change password";
			this.BtnCPass.UseVisualStyleBackColor = true;
			this.BtnCPass.Click += new System.EventHandler(this.BtnCPass_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(308, 182);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(83, 23);
			this.btnDelete.TabIndex = 94;
			this.btnDelete.Text = "Delete User";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnInsert
			// 
			this.btnInsert.Location = new System.Drawing.Point(188, 182);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(69, 23);
			this.btnInsert.TabIndex = 93;
			this.btnInsert.Text = "Insert User";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(307, 140);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(216, 20);
			this.txtPass.TabIndex = 92;
			// 
			// txtEMID
			// 
			this.txtEMID.Location = new System.Drawing.Point(308, 112);
			this.txtEMID.Name = "txtEMID";
			this.txtEMID.Size = new System.Drawing.Size(215, 20);
			this.txtEMID.TabIndex = 91;
			// 
			// txtUserN
			// 
			this.txtUserN.Location = new System.Drawing.Point(308, 88);
			this.txtUserN.Name = "txtUserN";
			this.txtUserN.Size = new System.Drawing.Size(215, 20);
			this.txtUserN.TabIndex = 90;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(238, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 89;
			this.label4.Text = "Password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(224, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 88;
			this.label3.Text = "Employee ID";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(238, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 87;
			this.label2.Text = "UserName";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(312, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 33);
			this.label1.TabIndex = 99;
			this.label1.Text = "User Data";
			// 
			// User
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(748, 486);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnM);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.BtnCPass);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtEMID);
			this.Controls.Add(this.txtUserN);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Name = "User";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "User";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnM;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button BtnCPass;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.TextBox txtEMID;
		private System.Windows.Forms.TextBox txtUserN;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}