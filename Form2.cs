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
	public partial class Mangemet : Form
	{
			
		public Mangemet()
		{
			InitializeComponent();
		}
		string Username;
		string Password;
		
		

		private void btnBM_Click(object sender, EventArgs e)
		{
			this.Hide();
			customer ss = new customer();
			ss.Show();
		}

		private void btnPM_Click(object sender, EventArgs e)
		{
			this.Hide();
			Main ss = new Main();
			ss.Show();
		}

		private void btnUserData_Click(object sender, EventArgs e)
		{
			this.Hide();
			User user = new User();
			user.Show();
		}

		private void Mangement_Load(object sender, EventArgs e)
		{
			if ( MyConnection.type == "U")
			{
				btnUserData.Hide();	
			}
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 form = new Form1();
			form.Show();	
		}
	}
}
