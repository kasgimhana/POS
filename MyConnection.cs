using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILLING_SOFTWARE
{
	internal class MyConnection
	{
		
		public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Pasidu\source\repos\BILLING SOFTWARE\Billing.mdf"";Integrated Security=True");
	
		public MyConnection() 
		{ 
			con.Open();
		}
		public static string type;
	}
}
