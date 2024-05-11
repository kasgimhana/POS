using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BILLING_SOFTWARE
{
	public partial class customer : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Pasidu\source\repos\BILLING SOFTWARE\Billing.mdf"";Integrated Security=True");
		private string connectionString;
		private object product;
		private int addedQuantity;
		public object Quantity { get; private set; }
		public object Product { get; private set; }
		public customer()
		{
			InitializeComponent();
		}
		private void customer_Load(object sender, EventArgs e)
		{
			display_data();
			Ibldt.Text = DateTime.Now.ToString();

		}
		public void display_data()
		{
			con.Open();
			SqlCommand cmd = con.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "Select * from[Stock]";
			cmd.ExecuteNonQuery();
			DataTable dt = new DataTable();
			SqlDataAdapter sda = new SqlDataAdapter(cmd);
			sda.Fill(dt);
			con.Close();
		}
		void dispcmb()
		{
			string constring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Pasidu\source\repos\BILLING SOFTWARE\Billing.mdf"";Integrated Security=True");
			string QUERY = "select * from [Stock]";
			SqlConnection conDatabase = new SqlConnection(constring);
			SqlCommand cmdDatabase = new SqlCommand(QUERY, conDatabase);
			SqlDataReader Reader;
			try
			{
				conDatabase.Open();
				Reader = cmdDatabase.ExecuteReader();
				while (Reader.Read())
				{
					string strn = Reader.GetString(0);
					cmbproduct.Items.Add(strn);

				}
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			dispcmb();
			MessageBox.Show("Database connected");
		}

		private void cmbproduct_SelectedIndexChanged(object sender, EventArgs e)
		{
			string constring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Pasidu\source\repos\BILLING SOFTWARE\Billing.mdf"";Integrated Security=True
");
			string Query = "select * from[Stock] where Product ='" + cmbproduct.Text + "'";
			SqlConnection conDatabase = new SqlConnection(constring);
			SqlCommand cmdDatabase = new SqlCommand(Query, conDatabase);
			SqlDataReader Reader;
			try
			{
				conDatabase.Open();
				Reader = cmdDatabase.ExecuteReader();
				while (Reader.Read())
				{
					string Price = Reader.GetInt32(1).ToString();
					string Quantity = Reader.GetInt32(2).ToString();
					Iblprice.Text = Price;
					Iblstock.Text = Quantity;
				}
				tbqty.Focus();
				tbqty.Text = "";
				cmbDiscount.Text = "";
				Ibltotal.Text = "";
				Iblsubtotal.Text = "";


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void tbqty_TextChanged(object sender, EventArgs e)
		{
			if (!tbqty.Text.Equals("") && !Iblprice.Text.Equals(""))
			{
				decimal totalprice = Convert.ToInt32(Iblprice.Text) * Convert.ToInt32(tbqty.Text);
				Ibltotal.Text = totalprice.ToString();
			}
		}

		private void cmbDiscount_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (!Ibltotal.Text.Equals("") && !cmbDiscount.Text.Equals("")) ;
				{
					decimal totalprice = Convert.ToInt32(Ibltotal.Text) - Convert.ToInt32(Ibltotal.Text) * Convert.ToInt32(cmbDiscount.Text) / 100;
					Iblsubtotal.Text = totalprice.ToString();

				}
			}
			catch 
			{
				
			}
			
			btnadd.Focus();
		}

		private void btnadd_Click(object sender, EventArgs e)
		{
			try
			{
				string[] arr = new string[6];
				arr[0] = cmbproduct.SelectedItem.ToString();
				arr[1] = Iblprice.Text;
				arr[2] = tbqty.Text;
				arr[3] = Ibltotal.Text;
				arr[4] = cmbDiscount.Text;
				arr[5] = Iblsubtotal.Text;

				ListViewItem listItems = new ListViewItem(arr);
				listView1.Items.Add(listItems);
				iblBtotal.Text = (Convert.ToInt32(Iblsubtotal.Text) + Convert.ToInt32(iblBtotal.Text)).ToString();
				decimal BTotal = 0;
				decimal BDiscount = 0;
				foreach (ListViewItem item in listView1.Items)
				{
					decimal Total = decimal.Parse(item.SubItems[3].Text);
					BTotal += Total;
					decimal subtotal = decimal.Parse(item.SubItems[5].Text);
					decimal BD = Total - subtotal;
					BDiscount += BD;
				}

				IblBT.Text = "" + BTotal.ToString();
				IblBD.Text = "" + BDiscount.ToString();
			}
			catch { }
		}

		private void btnremoveitem_Click(object sender, EventArgs e)
		{
			try
			{

				for (int i = 0; i < listView1.SelectedItems.Count;)
				{
					if (listView1.SelectedItems[i].Selected)
						listView1.SelectedItems[i].Remove();
					decimal totalAmount = 0;
					decimal BTotal = 0;
					decimal BDiscount = 0;
					foreach (ListViewItem item in listView1.Items)
					{
						decimal price = decimal.Parse(item.SubItems[5].Text);
						totalAmount += price;
						decimal Total = decimal.Parse(item.SubItems[3].Text);
						BTotal += Total;
						decimal BD = Total - price;
						BDiscount += BD;
					}

					// Update the label with the new total amount
					try
					{
						iblBtotal.Text = "" + totalAmount.ToString();
						IblBT.Text = "" + BTotal.ToString();
						IblBD.Text = "" + BDiscount.ToString();
						txtrefund.Text = (Convert.ToInt32(txtpaidamount.Text) - Convert.ToInt32(iblBtotal.Text)).ToString();
					}

					catch
					{

					}
				}
			}
			catch { }
		}

		private void txtpaidamount_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (iblBtotal.Text.Length > 0)
				{
					txtrefund.Text = (Convert.ToInt32(txtpaidamount.Text) - Convert.ToInt32(iblBtotal.Text)).ToString();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				txtrefund.Text = "";
			}
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			printPreviewDialog1.Document = printDocument1;
			printPreviewDialog1.ShowDialog();
		}

		private void Btnnext_Click(object sender, EventArgs e)
		{
			printDocument1.Print();
		}

		private void btnnew_Click(object sender, EventArgs e)
		{
			IblBT.Text = string.Empty;
			IblBD.Text = string.Empty;
			Iblstock.Text = String.Empty;
			Iblprice.Text = String.Empty;
			cmbproduct.SelectedIndex = 0;
			cmbDiscount.SelectedIndex = 0;
			Ibltotal.Text = String.Empty;
			Iblsubtotal.Text = String.Empty;
			iblBtotal.Text = String.Empty;
			txtpaidamount.Text = String.Empty;
			txtrefund.Text = String.Empty;
			tbqty.Text = String.Empty;
			tbqty.Text = String.Empty;
			tbqty.Text = String.Empty;
			listView1.Items.Clear();
		}

		private void Ibldt_Click(object sender, EventArgs e)
		{

			display_data();
			Ibldt.Text = DateTime.Now.ToString();
		}

		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			int startx = 190;
			int starty = 40;
			int offset = 30;
			float leftmargin = e.MarginBounds.Left;
			float topmargin = e.MarginBounds.Top;
			String dashLine = "---------------------------------------------------------------------------------------------------------------------------------------------------------";
			Bitmap bitmap = Properties.Resources.mm;
			Image image = new Bitmap(bitmap);
			e.Graphics.DrawImage(image, 25, 25, 800, 250);
			e.Graphics.DrawString("Invoice Number: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(25, 300));
			e.Graphics.DrawString("User Name : " , new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(25, 325));
			e.Graphics.DrawString("Date: " + Ibldt.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(550, 300));

			e.Graphics.DrawString(dashLine, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(25, 350));
			e.Graphics.DrawString("ITEMS  ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(25, 375));
			e.Graphics.DrawString("PRICE ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(150, 375));
			e.Graphics.DrawString("QTY", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(250, 375));
			e.Graphics.DrawString("DISCOUNT", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(375, 375));
			e.Graphics.DrawString("TOTAL", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(550, 375));
			e.Graphics.DrawString(dashLine, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(25, 400));
			int y = 430;
			for (int x = 0; x < listView1.Items.Count; x++)
			{

				e.Graphics.DrawString(listView1.Items[x].SubItems[0].Text + ' ', new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(25, y));
				e.Graphics.DrawString(listView1.Items[x].SubItems[1].Text + ' ', new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(150, y));
				e.Graphics.DrawString(listView1.Items[x].SubItems[2].Text + ' ', new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(250, y));
				e.Graphics.DrawString(listView1.Items[x].SubItems[4].Text + '%', new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(375, y));
				e.Graphics.DrawString(listView1.Items[x].SubItems[5].Text + ' ', new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(550, y));
				y = y + 20;

			}

			e.Graphics.DrawString(dashLine, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(25, y));
			y = y + 20;
			e.Graphics.DrawString("TOTAL", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(25, y));
			e.Graphics.DrawString("" + IblBT.Text + ".00", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(550, y)); y = y + 20;
			e.Graphics.DrawString("DISCOUNT", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(25, y));
			e.Graphics.DrawString("" + IblBD.Text + ".00", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(550, y)); y = y + 20;
			e.Graphics.DrawString(dashLine, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(25, y)); y = y + 20;

			e.Graphics.DrawString("SUB TOTAL", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(25, y));
			e.Graphics.DrawString("" + iblBtotal.Text + ".00", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(550, y)); y = y + 20;
			e.Graphics.DrawString("CASH", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(25, y));
			e.Graphics.DrawString("" + txtpaidamount.Text + ".00", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(550, y)); y = y + 20;
			e.Graphics.DrawString("BALANCE", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(25, y));
			e.Graphics.DrawString("" + txtrefund.Text + ".00", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(550, y)); y = y + 20;

			e.Graphics.DrawString(dashLine, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(25, y)); y = y + 20;
			e.Graphics.DrawString("THANK YOU COME AGAIN !!! ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(300, y)); y = y + 20;
			e.Graphics.DrawString(dashLine, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(25, y)); y = y + 20;
			e.Graphics.DrawString("Software By Group 57 ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(325,y)); y = y + 20;
		}

		private void txtrefund_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void iblBtotal_Click(object sender, EventArgs e)
		{
			try
			{
				if (iblBtotal.Text.Length > 0)
				{
					txtrefund.Text = (Convert.ToInt32(txtpaidamount.Text) - Convert.ToInt32(iblBtotal.Text)).ToString();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				txtrefund.Text = "";
			}
		}

		private void btnM_Click(object sender, EventArgs e)
		{
			this.Hide();
			Mangemet ss = new Mangemet();
			ss.Show();
		}
	}
}
