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
	public partial class UyeGiris : Form
	{
		Library library = new Library();
		public UyeGiris()
		{
			InitializeComponent();
		}

		private void geriButton_Click(object sender, EventArgs e)
		{
			Giris giris = new Giris();
			giris.Show();
			this.Hide();
		}

		private void girisButton_Click(object sender, EventArgs e)
		{
			User loggedInUser = GetLoggedInUser(library.Users, kullaniciAdi_textBox.Text, parola_textBox.Text);

			if (loggedInUser != null)
			{
				UyeEkrani uyeEkrani = new UyeEkrani(loggedInUser);
				uyeEkrani.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Giriş Başarısız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public static User GetLoggedInUser(List<User> users, string username, string password)
		{
			// Kullanıcı adı ve parola kontrolü
			foreach (User user in users)
			{
				if (user.Name == username && user.Parola == password)
				{
					return user; // Giriş yapan kullanıcıyı döndür
				}
			}

			return null; // Kullanıcı adı veya parola hatalı
		}

	}
}
