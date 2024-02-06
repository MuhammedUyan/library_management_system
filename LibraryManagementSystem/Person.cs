using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
	public class Person
	{
		private string name;
		private string surname;
		private string parola;
		public Person(){}
		public Person(string name, string surname, string parola)
		{
			this.name = name;
			this.surname = surname;
			this.parola = parola;
		}
		public string Name { get { return name; } set { name = value; } }
		public string Surname { get {  return surname; } set {  surname = value; } }
		public string Parola { get {  return parola; } set {  parola = value; } }
	} 
}
