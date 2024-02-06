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
	public partial class Giris : Form
	{
		public Giris()
		{
			InitializeComponent();

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			AdminGiris form2 = new AdminGiris();
			form2.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void uyeGirisButton_Click(object sender, EventArgs e)
		{
			UyeGiris uyeGiris = new UyeGiris();
			uyeGiris.Show();
			this.Hide();
		}
	}
}
