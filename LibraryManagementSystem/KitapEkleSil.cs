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
	public partial class KitapEkleSil : Form
	{
		List<Book> books;

		public KitapEkleSil(List<Book> books)
		{
			InitializeComponent();
			this.books = books;
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void KitapEkleSil_Load(object sender, EventArgs e)
		{

		}

		private void ekleButton_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(kitapID_textBox.Text) && !kitapID_textBox.Text.All(char.IsDigit))
			{
				MessageBox.Show("Lütfen sayısal değer giriniz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (int.TryParse(kitapID_textBox.Text, out int kitapID))
				{
					Book book = new Book(kitapAdi_textBox.Text, yazarAdi_textBox.Text, kitapID, checkBox1.Checked);
					books.Add(book);
					this.Close();
				}
				else
				{
					MessageBox.Show("Lütfen geçerli bir sayısal değer giriniz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void geriButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void silButton_Click(object sender, EventArgs e)
		{
			string kitapAdi = kitapAdi_textBox.Text;
			if (string.IsNullOrWhiteSpace(kitapAdi))
			{
				MessageBox.Show("Lütfen bir kitap adı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Book bookToRemove = books.Find(book => book.Title == kitapAdi);
			if (bookToRemove != null)
			{
				books.Remove(bookToRemove);
				MessageBox.Show("Kitap silindi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else
			{
				MessageBox.Show("Kitap bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
