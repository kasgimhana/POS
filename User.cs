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
	public partial class User : Form
	{
		SqlConnection Con =new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Pasidu\source\repos\BILLING SOFTWARE\Billing.mdf"";Integrated Security=True");
		public User()
		{
			InitializeComponent();
			display_data();
		}
		public void display_data()
		{
			Con.Open();
			SqlCommand cmd = Con.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "Select * from[User]";
			cmd.ExecuteNonQuery();
			DataTable dt = new DataTable();
			SqlDataAdapter sda = new SqlDataAdapter(cmd);
			sda.Fill(dt);
			dataGridView.DataSource = dt;
			Con.Close();
		}

			private void label3_Click(object sender, EventArgs e)
		{

		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			if (txtUserN.Text == "")
			{
				MessageBox.Show("Please Enter the UserName Name");
			}
			else if (txtEMID.Text == "")
			{
				MessageBox.Show("Please Enter the Employe Id");
			}
			else if (txtPass.Text == "")
			{
				MessageBox.Show("please Enter the Quntity");
			}
			else
			{
				Con.Open();
				SqlCommand cmd = Con.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "insert into[User] values('" + txtUserN.Text + "','" + txtEMID.Text + "','" + txtPass.Text + "')";
				cmd.ExecuteNonQuery();
				Con.Close();
				display_data();
				MessageBox.Show("Insert sucessfull");
				txtUserN.Focus();
				txtPass.Text = "";
				txtEMID.Text = "";
				txtPass.Text = "";
			}
		}

		private void BtnCPass_Click(object sender, EventArgs e)
		{
			if (txtUserN.Text == "")
			{
				MessageBox.Show("Please Enter the  UserName to Update Password");
			}
			else
			{
				try
				{
					Con.Open();
					SqlCommand cmd = Con.CreateCommand();
					cmd.CommandType = CommandType.Text;
					cmd.CommandText = "update[User] set Password = '" + txtPass.Text + "' where UserName='" + txtUserN.Text + "' ";
					cmd.ExecuteNonQuery();
					Con.Close();
					display_data();
					txtPass.Text = "";
					txtEMID.Text = "";
					txtPass.Text = "";
					txtUserN.Focus();
					MessageBox.Show(" update Password sucessfully");
				}
				catch { }
			}

		}

	

		private void btnDelete_Click(object sender, EventArgs e)
		{

			if (txtUserN.Text == "")
			{
				MessageBox.Show("Please Enter the  UserName to Delete");
			}
			else
			{
				Con.Open();
				string Sql = "delete from[User]where UserName =('" + txtUserN.Text + "')";
				SqlCommand cmd = new SqlCommand(Sql,Con);
				cmd.ExecuteNonQuery();
				Con.Close();
				display_data();
				txtUserN.Text = "";
				MessageBox.Show("Delete sucessfull");
			}
		}

		private void btnM_Click(object sender, EventArgs e)
		{
			this.Hide();
			Mangemet mangemet = new Mangemet();
			mangemet.Show();
		}
	}
}
