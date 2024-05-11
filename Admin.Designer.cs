namespace BILLING_SOFTWARE
{
	partial class Admin
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
			this.btnStock = new System.Windows.Forms.Button();
			this.btnBilling = new System.Windows.Forms.Button();
			this.btnUser = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnStock
			// 
			this.btnStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStock.Location = new System.Drawing.Point(140, 124);
			this.btnStock.Name = "btnStock";
			this.btnStock.Size = new System.Drawing.Size(199, 106);
			this.btnStock.TabIndex = 3;
			this.btnStock.Text = "Stock ";
			this.btnStock.UseVisualStyleBackColor = true;
			// 
			// btnBilling
			// 
			this.btnBilling.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBilling.Location = new System.Drawing.Point(463, 124);
			this.btnBilling.Name = "btnBilling";
			this.btnBilling.Size = new System.Drawing.Size(199, 106);
			this.btnBilling.TabIndex = 2;
			this.btnBilling.Text = "Billing ";
			this.btnBilling.UseVisualStyleBackColor = true;
			// 
			// btnUser
			// 
			this.btnUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUser.Location = new System.Drawing.Point(291, 267);
			this.btnUser.Name = "btnUser";
			this.btnUser.Size = new System.Drawing.Size(199, 106);
			this.btnUser.TabIndex = 4;
			this.btnUser.Text = "User Data";
			this.btnUser.UseVisualStyleBackColor = true;
			// 
			// Admin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnUser);
			this.Controls.Add(this.btnStock);
			this.Controls.Add(this.btnBilling);
			this.Name = "Admin";
			this.Text = "Admin";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnStock;
		private System.Windows.Forms.Button btnBilling;
		private System.Windows.Forms.Button btnUser;
	}
}