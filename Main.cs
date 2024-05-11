using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BILLING_SOFTWARE
{
	public partial class Main : Form
	{

		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Pasidu\source\repos\BILLING SOFTWARE\Billing.mdf"";Integrated Security=True");
		private string connectionString;
		private object product;
		private int addedQuantity;
		public Main()
		{
			InitializeComponent();
			display_data();
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
			dataGridView.DataSource = dt;
			con.Close();


		}

		private void BtnupdateQty_Click(object sender, EventArgs e)
		{
			if (txtPname.Text == "")
			{
				MessageBox.Show("Please Enter the Product Name to Update Quntity");
			}
			else
			{
				con.Open();
				SqlCommand cmd = con.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "update[Stock] set Quantity = '" + txtQty.Text + "' where Product='" + txtPname.Text + "' ";
				cmd.ExecuteNonQuery();
				con.Close();
				display_data();
				txtPname.Text = "";
				txtPPrice.Text = "";
				txtQty.Text = "";
				txtPname.Focus();
				MessageBox.Show("Quntity update sucessfully");
			}
		}

		private void btnCuBi_Click(object sender, EventArgs e)
		{
			this.Hide();
			customer ss = new customer();
			ss.Show();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (txtPname.Text == "")
			{
				MessageBox.Show("Please Enter the Product Name to Delete");
			}
			else
			{
				con.Open();
				SqlCommand cmd = con.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "delete from[Stock] where Product =('" + txtPname.Text + "')";
				cmd.ExecuteNonQuery();
				con.Close();
				display_data();
				txtPname.Text = "";
				MessageBox.Show("Delete sucessfull");
			}
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			if (txtPname.Text == "")
			{
				MessageBox.Show("Please Enter the Product Name");
			}
			else if (txtPPrice.Text == "")
			{
				MessageBox.Show("Please Enter the product Price");
			}
			else if (txtQty.Text == "")
			{
				MessageBox.Show("please Enter the Quntity");
			}
			else
			{
				con.Open();
				SqlCommand cmd = con.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "insert into[Stock] values('" + txtPname.Text + "','" + txtPPrice.Text + "','" + txtQty.Text + "')";
				cmd.ExecuteNonQuery();
				con.Close();
				display_data();
				MessageBox.Show("Insert sucessfull");
				txtPname.Focus();
				txtPname.Text = "";
				txtPPrice.Text = "";
				txtQty.Text = "";
			}
		}

		private void btnDisplay_Click(object sender, EventArgs e)
		{
			display_data();
		}

		private void btnM_Click(object sender, EventArgs e)
		{
			this.Hide();
			Mangemet ss = new Mangemet();
			ss.Show();
		}
	}
}
