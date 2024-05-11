using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BILLING_SOFTWARE
{
	public partial class Form1 : Form
	{
		MyConnection gg = new MyConnection();
		
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Pasidu\source\repos\BILLING SOFTWARE\Billing.mdf"";Integrated Security=True");
			SqlDataAdapter sda = new SqlDataAdapter("select  Count (*) From [User] where USERNAME ='" + txtUserN.Text + "' and PASSWORD ='" + txtPass.Text + "'", con);
			SqlDataAdapter sa = new SqlDataAdapter("select  Count (*) From [Table] where USERNAME ='" + txtUserN.Text + "' and PASSWORD ='" + txtPass.Text + "'", con);
			DataTable dt = new DataTable();
			DataTable df = new DataTable();
			sda.Fill(dt);
			sa.Fill(df);
			
			if (dt.Rows[0][0].ToString() == "1")
			{
				MyConnection.type = "U";
				this.Hide(); 
				Mangemet ss = new Mangemet();
				ss.Show();
				
				
				
			}
			else if(df.Rows[0][0].ToString() == "1")
			{
				MyConnection.type = "A";
				this.Hide();
				Mangemet ss = new Mangemet();
				ss.Show();
				

			}
			
			else
			{
				MessageBox.Show("Please cheak your Username or Password");
			}
		}
		public void User()
		{
			txtUserN.Text = Convert.ToString(txtUserN);
		}
	}
}
