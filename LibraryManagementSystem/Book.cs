using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
	public class Book
	{
		private string title;
		private string author;
		private int bookID;
		private bool checkedOut;
		public Book() { }
		public Book(string title, string author, int bookID, bool checkedOut) {
			this.title = title;
			this.author = author;
			this.bookID = bookID;
			this.checkedOut = checkedOut;
		}
		public string Title { get { return title; } set { title = value; } }
		public string Author { get { return author; } set { author = value; } }	
		public int BookID { get {  return bookID; } set {  bookID = value; } }
		public bool CheckedOut { get {  return checkedOut; } set {  checkedOut = value; } }
	}
}
