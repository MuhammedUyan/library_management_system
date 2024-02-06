using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LibraryManagementSystem
{
	public partial class UyeEkleSil : Form
	{
		List<User> users;
		public UyeEkleSil(List<User> users)
		{
			InitializeComponent();
			this.users = users;
		}

		private void geriButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ekleButton_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(UyeID_textBox.Text) && !UyeID_textBox.Text.All(char.IsDigit))
			{
				MessageBox.Show("Lütfen sayısal değer giriniz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (int.TryParse(UyeID_textBox.Text, out int UyeID))
				{
					User user = new User(UyeAdi_textBox.Text, UyeSoyadi_textBox.Text, UyeID, "0000");
					users.Add(user);
					this.Close();
				}
				else
				{
					MessageBox.Show("Lütfen geçerli bir sayısal değer giriniz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void silButton_Click(object sender, EventArgs e)
		{
			string UyeAdi = UyeAdi_textBox.Text;
			if (string.IsNullOrWhiteSpace(UyeAdi))
			{
				MessageBox.Show("Lütfen bir üye adı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			User userToRemove = users.Find(user => user.Name == UyeAdi);
			if (userToRemove != null)
			{
				users.Remove(userToRemove);
				MessageBox.Show("Üye silindi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else
			{
				MessageBox.Show("Üye bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
