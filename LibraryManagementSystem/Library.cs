using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
	public class Library
	{
		List<Book> books;
		List<User> users;
		public Library() {

			books = new List<Book>();
			users = new List<User>();

			Book kitap1 = new Book("A kitabı", "A yazarı", 100, true);
			books.Add(kitap1);
			Book kitap2 = new Book("B kitabı", "B yazarı", 101, true);
			books.Add(kitap2);
			Book kitap3 = new Book("C kitabı", "C yazarı", 102, false);
			books.Add(kitap3);
			Book kitap4 = new Book("D kitabı", "D yazarı", 103, false);
			books.Add(kitap4);

			User user1 = new User("Kullanıcı1", "Kullanıcı1Soy", 10, "1234");
			users.Add(user1);
			User user2 = new User("Kullanıcı2", "Kullanıcı2Soy", 11, "1234");
			users.Add(user2);
			User user3 = new User("Kullanıcı3", "Kullanıcı3Soy", 12, "1234");
			users.Add(user3);
			User user4 = new User("Kullanıcı4", "Kullanıcı4Soy", 13, "1234");
			users.Add(user4);
		}
		public List<Book> Books { get { return books; } set { books = value; } }
		public List<User> Users { get {  return users; } set { users = value; } }
	}
}
