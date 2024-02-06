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
	public partial class AdminGiris : Form
	{
		public AdminGiris()
		{
			InitializeComponent();
		}

		Admin admin = new Admin("Admin", "Admin", "1234");

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Giris form1 = new Giris();
			form1.Show();
			this.Hide();
		}

		private void GirisButton_Click(object sender, EventArgs e)
		{
			string adminName = kullaniciAdi_textBox.Text;
			string adminParola = parola_textBox.Text;
			if (adminName == admin.Name && adminParola == admin.Parola)
			{
				AdminEkrani adminEkrani = new AdminEkrani();
				adminEkrani.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Giriş başarısız ! ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
