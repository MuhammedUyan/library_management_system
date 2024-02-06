using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
	public class User : Person
	{
		private int userID;
		private string parola;
		public User(string userName,string userSurname, int userID, string parola) {
			this.Name = userName;
			this.Surname = userSurname;
			this.userID = userID;
			this.parola = parola;
		}
		public int UserID {  get { return userID;} set { userID = value; } }
		public string Parola {  get { return parola; } set {  parola = value; } }
	}
}
