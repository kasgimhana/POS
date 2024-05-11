namespace BILLING_SOFTWARE
{
	partial class Mangemet
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
			this.btnBM = new System.Windows.Forms.Button();
			this.btnPM = new System.Windows.Forms.Button();
			this.btnUserData = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnBM
			// 
			this.btnBM.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBM.Location = new System.Drawing.Point(452, 118);
			this.btnBM.Name = "btnBM";
			this.btnBM.Size = new System.Drawing.Size(199, 106);
			this.btnBM.TabIndex = 0;
			this.btnBM.Text = "Billing ";
			this.btnBM.UseVisualStyleBackColor = true;
			this.btnBM.Click += new System.EventHandler(this.btnBM_Click);
			// 
			// btnPM
			// 
			this.btnPM.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPM.Location = new System.Drawing.Point(122, 118);
			this.btnPM.Name = "btnPM";
			this.btnPM.Size = new System.Drawing.Size(199, 106);
			this.btnPM.TabIndex = 1;
			this.btnPM.Text = "Stock ";
			this.btnPM.UseVisualStyleBackColor = true;
			this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
			// 
			// btnUserData
			// 
			this.btnUserData.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUserData.Location = new System.Drawing.Point(291, 272);
			this.btnUserData.Name = "btnUserData";
			this.btnUserData.Size = new System.Drawing.Size(199, 106);
			this.btnUserData.TabIndex = 2;
			this.btnUserData.Text = "User Data";
			this.btnUserData.UseVisualStyleBackColor = true;
			this.btnUserData.Click += new System.EventHandler(this.btnUserData_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogout.Location = new System.Drawing.Point(46, 37);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(85, 32);
			this.btnLogout.TabIndex = 3;
			this.btnLogout.Text = "LogOut";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// Mangemet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.btnUserData);
			this.Controls.Add(this.btnPM);
			this.Controls.Add(this.btnBM);
			this.Name = "Mangemet";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Mangement_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnBM;
		private System.Windows.Forms.Button btnPM;
		private System.Windows.Forms.Button btnUserData;
		private System.Windows.Forms.Button btnLogout;
	}
}