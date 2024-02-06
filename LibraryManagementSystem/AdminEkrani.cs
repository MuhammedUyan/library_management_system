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
	public partial class AdminEkrani : Form
	{
		Library library = new Library();

		public AdminEkrani()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void AramaButton_Click(object sender, EventArgs e)
		{
			string kitapAdi = KitapAdi_textBox.Text.ToLower();
			string kitapYazari = YazarAdi_textBox.Text.ToLower();
			string kitapID = KitapID_textBox.Text.ToLower();

			listView1.Items.Clear();

			var aramaSonuclari = library.Books.Where(book =>
				(string.IsNullOrEmpty(kitapAdi) || book.Title.ToLower().Contains(kitapAdi)) &&
				(string.IsNullOrEmpty(kitapYazari) || book.Author.ToLower().Contains(kitapYazari)) &&
				(string.IsNullOrEmpty(kitapID) || book.BookID.ToString().Contains(kitapID))
			);

			foreach (Book book in aramaSonuclari)
			{
				ListViewItem item = new ListViewItem(book.BookID.ToString());
				item.SubItems.Add(book.Title);
				item.SubItems.Add(book.Author);
				if (book.CheckedOut)
				{
					item.SubItems.Add("Mevcut");
				}
				else
				{
					item.SubItems.Add("Mevcut değil");
				}
				listView1.Items.Add(item);
			}

		}

		private void AdminEkrani_Load(object sender, EventArgs e)
		{

			foreach (Book book in library.Books)
			{
				ListViewItem item = new ListViewItem(book.BookID.ToString());
				item.SubItems.Add(book.Title);
				item.SubItems.Add(book.Author);
				if(book.CheckedOut== true)
				{
					item.SubItems.Add("Mevcut");
				}
				else
				{
					item.SubItems.Add("Mevcut değil");
				}
				listView1.Items.Add(item);
			}

			foreach(User user in library.Users)
			{
				ListViewItem item2 = new ListViewItem(user.UserID.ToString());
				item2.SubItems.Add(user.Name);
				item2.SubItems.Add(user.Surname);
				listView2.Items.Add(item2);
			}


		}

		private void button4_Click(object sender, EventArgs e)
		{

		}

		private void UyeAramaButton_Click(object sender, EventArgs e)
		{
			string uyeAdi = uyeAdi_textBox.Text.ToLower();
			string uyeSoyadi = uyeSoyadi_textBox.Text.ToLower();
			string uyeID = uyeID_textBox.Text.ToLower();

			listView2.Items.Clear();

			var aramaSonuclari2 = library.Users.Where(user =>
				(string.IsNullOrEmpty(uyeAdi) || user.Name.ToLower().Contains(uyeAdi)) &&
				(string.IsNullOrEmpty(uyeSoyadi) || user.Surname.ToLower().Contains(uyeSoyadi)) &&
				(string.IsNullOrEmpty(uyeID) || user.UserID.ToString().Contains(uyeID))
			);

			foreach (User user in aramaSonuclari2)
			{
				ListViewItem item2 = new ListViewItem(user.UserID.ToString());
				item2.SubItems.Add(user.Name);
				item2.SubItems.Add(user.Surname);
				listView2.Items.Add(item2);
			}

		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void kitapEkleSilButon_Click(object sender, EventArgs e)
		{
			KitapEkleSil kitapEkleSil = new KitapEkleSil(library.Books);
			kitapEkleSil.Show();
		}

		private void UyeEkleSilButton_Click(object sender, EventArgs e)
		{
			UyeEkleSil uyeEkleSil = new UyeEkleSil(library.Users);
			uyeEkleSil.Show();
		}
	}
}
