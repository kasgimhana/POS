namespace BILLING_SOFTWARE
{
	partial class customer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer));
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.IblBD = new System.Windows.Forms.Label();
			this.IblBT = new System.Windows.Forms.Label();
			this.cmbproduct = new System.Windows.Forms.ComboBox();
			this.btnnew = new System.Windows.Forms.Button();
			this.tbqty = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.Ibldt = new System.Windows.Forms.Label();
			this.btnremoveitem = new System.Windows.Forms.Button();
			this.Btnnext = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtrefund = new System.Windows.Forms.TextBox();
			this.txtpaidamount = new System.Windows.Forms.TextBox();
			this.iblBtotal = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnadd = new System.Windows.Forms.Button();
			this.cmbDiscount = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.Iblsubtotal = new System.Windows.Forms.Label();
			this.Ibltotal = new System.Windows.Forms.Label();
			this.Iblprice = new System.Windows.Forms.Label();
			this.Iblstock = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.btnM = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.SuspendLayout();
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(568, 228);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(31, 13);
			this.label18.TabIndex = 84;
			this.label18.Text = "Total";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(568, 251);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(49, 13);
			this.label17.TabIndex = 83;
			this.label17.Text = "Discount";
			// 
			// IblBD
			// 
			this.IblBD.BackColor = System.Drawing.Color.White;
			this.IblBD.Location = new System.Drawing.Point(640, 251);
			this.IblBD.Name = "IblBD";
			this.IblBD.Size = new System.Drawing.Size(95, 19);
			this.IblBD.TabIndex = 82;
			this.IblBD.Text = "0";
			this.IblBD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// IblBT
			// 
			this.IblBT.BackColor = System.Drawing.Color.White;
			this.IblBT.Location = new System.Drawing.Point(640, 225);
			this.IblBT.Name = "IblBT";
			this.IblBT.Size = new System.Drawing.Size(95, 19);
			this.IblBT.TabIndex = 81;
			this.IblBT.Text = "0";
			this.IblBT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmbproduct
			// 
			this.cmbproduct.FormattingEnabled = true;
			this.cmbproduct.Items.AddRange(new object[] {
            ""});
			this.cmbproduct.Location = new System.Drawing.Point(194, 120);
			this.cmbproduct.Name = "cmbproduct";
			this.cmbproduct.Size = new System.Drawing.Size(166, 21);
			this.cmbproduct.TabIndex = 80;
			this.cmbproduct.SelectedIndexChanged += new System.EventHandler(this.cmbproduct_SelectedIndexChanged);
			// 
			// btnnew
			// 
			this.btnnew.Location = new System.Drawing.Point(595, 390);
			this.btnnew.Name = "btnnew";
			this.btnnew.Size = new System.Drawing.Size(119, 23);
			this.btnnew.TabIndex = 79;
			this.btnnew.Text = "New Customer";
			this.btnnew.UseVisualStyleBackColor = true;
			this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
			// 
			// tbqty
			// 
			this.tbqty.Location = new System.Drawing.Point(65, 167);
			this.tbqty.Name = "tbqty";
			this.tbqty.Size = new System.Drawing.Size(53, 20);
			this.tbqty.TabIndex = 78;
			this.tbqty.TextChanged += new System.EventHandler(this.tbqty_TextChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(611, 167);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(84, 24);
			this.label16.TabIndex = 77;
			this.label16.Text = "Invoice";
			// 
			// Ibldt
			// 
			this.Ibldt.AutoSize = true;
			this.Ibldt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Ibldt.Location = new System.Drawing.Point(557, 38);
			this.Ibldt.Name = "Ibldt";
			this.Ibldt.Size = new System.Drawing.Size(34, 14);
			this.Ibldt.TabIndex = 76;
			this.Ibldt.Text = "Date";
			this.Ibldt.Click += new System.EventHandler(this.Ibldt_Click);
			// 
			// btnremoveitem
			// 
			this.btnremoveitem.Location = new System.Drawing.Point(448, 167);
			this.btnremoveitem.Name = "btnremoveitem";
			this.btnremoveitem.Size = new System.Drawing.Size(96, 23);
			this.btnremoveitem.TabIndex = 75;
			this.btnremoveitem.Text = "Remove Item";
			this.btnremoveitem.UseVisualStyleBackColor = true;
			this.btnremoveitem.Click += new System.EventHandler(this.btnremoveitem_Click);
			// 
			// Btnnext
			// 
			this.Btnnext.Location = new System.Drawing.Point(660, 361);
			this.Btnnext.Name = "Btnnext";
			this.Btnnext.Size = new System.Drawing.Size(75, 23);
			this.Btnnext.TabIndex = 74;
			this.Btnnext.Text = "Print";
			this.Btnnext.UseVisualStyleBackColor = true;
			this.Btnnext.Click += new System.EventHandler(this.Btnnext_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(560, 361);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(94, 23);
			this.btnPrint.TabIndex = 73;
			this.btnPrint.Text = "Print Preview";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(568, 333);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(46, 13);
			this.label15.TabIndex = 72;
			this.label15.Text = "Balance";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(568, 307);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(67, 13);
			this.label14.TabIndex = 71;
			this.label14.Text = "Paid Amount";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(568, 279);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(50, 13);
			this.label9.TabIndex = 70;
			this.label9.Text = "SubTotal";
			// 
			// txtrefund
			// 
			this.txtrefund.Location = new System.Drawing.Point(641, 330);
			this.txtrefund.Name = "txtrefund";
			this.txtrefund.Size = new System.Drawing.Size(92, 20);
			this.txtrefund.TabIndex = 69;
			this.txtrefund.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtrefund.TextChanged += new System.EventHandler(this.txtrefund_TextChanged);
			// 
			// txtpaidamount
			// 
			this.txtpaidamount.Location = new System.Drawing.Point(641, 304);
			this.txtpaidamount.Name = "txtpaidamount";
			this.txtpaidamount.Size = new System.Drawing.Size(92, 20);
			this.txtpaidamount.TabIndex = 68;
			this.txtpaidamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtpaidamount.TextChanged += new System.EventHandler(this.txtpaidamount_TextChanged);
			// 
			// iblBtotal
			// 
			this.iblBtotal.BackColor = System.Drawing.Color.White;
			this.iblBtotal.Location = new System.Drawing.Point(640, 276);
			this.iblBtotal.Name = "iblBtotal";
			this.iblBtotal.Size = new System.Drawing.Size(95, 19);
			this.iblBtotal.TabIndex = 67;
			this.iblBtotal.Text = "0";
			this.iblBtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.iblBtotal.Click += new System.EventHandler(this.iblBtotal_Click);
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.Color.Silver;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(79, 206);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(454, 195);
			this.listView1.TabIndex = 66;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Item Name";
			this.columnHeader1.Width = 150;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "price";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Qty";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Total";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Discount";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Subtotal";
			// 
			// btnadd
			// 
			this.btnadd.Location = new System.Drawing.Point(364, 167);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(75, 23);
			this.btnadd.TabIndex = 65;
			this.btnadd.Text = "Add Item";
			this.btnadd.UseVisualStyleBackColor = true;
			this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
			// 
			// cmbDiscount
			// 
			this.cmbDiscount.FormattingEnabled = true;
			this.cmbDiscount.Items.AddRange(new object[] {
            "",
            "0",
            "5",
            "10",
            "15",
            "20",
            "30",
            "50"});
			this.cmbDiscount.Location = new System.Drawing.Point(136, 168);
			this.cmbDiscount.Name = "cmbDiscount";
			this.cmbDiscount.Size = new System.Drawing.Size(54, 21);
			this.cmbDiscount.TabIndex = 64;
			this.cmbDiscount.SelectedIndexChanged += new System.EventHandler(this.cmbDiscount_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(141, 149);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(49, 13);
			this.label8.TabIndex = 63;
			this.label8.Text = "Discount";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(76, 149);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(23, 13);
			this.label7.TabIndex = 62;
			this.label7.Text = "Qty";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(292, 149);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(53, 13);
			this.label13.TabIndex = 61;
			this.label13.Text = "Sub Total";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(223, 149);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(31, 13);
			this.label12.TabIndex = 60;
			this.label12.Text = "Total";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(329, 75);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(31, 13);
			this.label11.TabIndex = 59;
			this.label11.Text = "Price";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(222, 75);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(77, 13);
			this.label10.TabIndex = 58;
			this.label10.Text = "Avalable stock";
			// 
			// Iblsubtotal
			// 
			this.Iblsubtotal.BackColor = System.Drawing.Color.White;
			this.Iblsubtotal.Location = new System.Drawing.Point(288, 170);
			this.Iblsubtotal.Name = "Iblsubtotal";
			this.Iblsubtotal.Size = new System.Drawing.Size(57, 17);
			this.Iblsubtotal.TabIndex = 57;
			this.Iblsubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Ibltotal
			// 
			this.Ibltotal.BackColor = System.Drawing.Color.White;
			this.Ibltotal.Location = new System.Drawing.Point(212, 169);
			this.Ibltotal.Name = "Ibltotal";
			this.Ibltotal.Size = new System.Drawing.Size(57, 17);
			this.Ibltotal.TabIndex = 56;
			this.Ibltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Iblprice
			// 
			this.Iblprice.BackColor = System.Drawing.Color.White;
			this.Iblprice.Location = new System.Drawing.Point(319, 92);
			this.Iblprice.Name = "Iblprice";
			this.Iblprice.Size = new System.Drawing.Size(57, 17);
			this.Iblprice.TabIndex = 55;
			this.Iblprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Iblstock
			// 
			this.Iblstock.BackColor = System.Drawing.Color.White;
			this.Iblstock.Location = new System.Drawing.Point(229, 92);
			this.Iblstock.Name = "Iblstock";
			this.Iblstock.Size = new System.Drawing.Size(57, 17);
			this.Iblstock.TabIndex = 54;
			this.Iblstock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(378, 118);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 53;
			this.button1.Text = "Connect";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(288, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(130, 40);
			this.label6.TabIndex = 52;
			this.label6.Text = "Billing ";
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// btnM
			// 
			this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnM.Location = new System.Drawing.Point(326, 426);
			this.btnM.Name = "btnM";
			this.btnM.Size = new System.Drawing.Size(85, 31);
			this.btnM.TabIndex = 85;
			this.btnM.Text = "Back";
			this.btnM.UseVisualStyleBackColor = true;
			this.btnM.Click += new System.EventHandler(this.btnM_Click);
			// 
			// customer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(810, 483);
			this.Controls.Add(this.btnM);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.IblBD);
			this.Controls.Add(this.IblBT);
			this.Controls.Add(this.cmbproduct);
			this.Controls.Add(this.btnnew);
			this.Controls.Add(this.tbqty);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.Ibldt);
			this.Controls.Add(this.btnremoveitem);
			this.Controls.Add(this.Btnnext);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtrefund);
			this.Controls.Add(this.txtpaidamount);
			this.Controls.Add(this.iblBtotal);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btnadd);
			this.Controls.Add(this.cmbDiscount);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.Iblsubtotal);
			this.Controls.Add(this.Ibltotal);
			this.Controls.Add(this.Iblprice);
			this.Controls.Add(this.Iblstock);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Name = "customer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "customer";
			this.Load += new System.EventHandler(this.customer_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label IblBD;
		private System.Windows.Forms.Label IblBT;
		private System.Windows.Forms.ComboBox cmbproduct;
		private System.Windows.Forms.Button btnnew;
		private System.Windows.Forms.TextBox tbqty;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label Ibldt;
		private System.Windows.Forms.Button btnremoveitem;
		private System.Windows.Forms.Button Btnnext;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtrefund;
		private System.Windows.Forms.TextBox txtpaidamount;
		private System.Windows.Forms.Label iblBtotal;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.Button btnadd;
		private System.Windows.Forms.ComboBox cmbDiscount;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label Iblsubtotal;
		private System.Windows.Forms.Label Ibltotal;
		private System.Windows.Forms.Label Iblprice;
		private System.Windows.Forms.Label Iblstock;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label6;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.Button btnM;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}