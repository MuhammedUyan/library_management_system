using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
	public partial class UyeEkrani : Form
	{
		private User loggedInUser;
		public UyeEkrani(User user)
		{
			InitializeComponent();
			loggedInUser = user;
		}

		private void UyeEkrani_Load(object sender, EventArgs e)
		{
			label9.Text = loggedInUser.Name;
			label8.Text = loggedInUser.Surname;
			label7.Text = loggedInUser.UserID.ToString();
			label6.Text = loggedInUser.Parola;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
