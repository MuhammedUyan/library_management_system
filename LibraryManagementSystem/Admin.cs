using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
	internal class Admin : Person
	{
		public Admin(string name, string surname, string parola) {
			this.Name = name;
			this.Surname = surname;
			this.Parola = parola;
		}	
	}
}
