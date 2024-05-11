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
	public partial class Signup : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Pasidu\source\repos\BILLING SOFTWARE\Billing.mdf"";Integrated Security=True");
		private string connectionString;
		private object product;
		private int addedQuantity;
		
		public Signup()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void btnSignUp_Click(object sender, EventArgs e)
		{
			if (txtFName.Text == "")
			{
				MessageBox.Show("Please Enter the Fist Name");
			}
			else if (txtLName.Text == "")
			{
				MessageBox.Show("Please Enter the Last Name");
			}
			else if (txtEmployID.Text == "")
			{
				MessageBox.Show("Please Enter the EmployID");
			}
			else if (txtUName.Text == "")
			{
				MessageBox.Show("Please Enter the username");
			}
			else if (txtpass.Text == "")
			{
				MessageBox.Show("please Enter the Password");
			}
			else
			{
				con.Open();
				SqlCommand cmd = con.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "insert into[Table] values('" + txtFName.Text + "','" + txtLName.Text + "','" + txtEmployID.Text + "','" + txtUName.Text + "','" + txtpass.Text + "')";
				cmd.ExecuteNonQuery();
				con.Close();

				
			}
			this.Hide();
			Form1 ss = new Form1();
			ss.Show();
		}
	}
}
