using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Sort_Workers
{
   public  class Worker
    {
		public int id;
		public string firstName;
		public string lastName;
		public string email;
		public int telephone;
		public string address;
		public float salary;

		public Worker(int id, string fn, string ln, float salary)
		{
			this.id = id;
			this.firstName = fn;
			this.lastName = ln;
			this.salary = salary;
		}

		public Worker(int id, string fn, string ln, string email, int telephone, string adress, float salary)
		{
			this.id = id;
			this.firstName = fn;
			this.lastName = ln;
			this.email = email;
			this.telephone = telephone;
			this.address = adress;
			this.salary = salary;
		}

		public int GetId()
		{
			return this.id;
		}

		public string GetfirstName()
		{
			return this.firstName;
		}

		public string GetlastName()
		{
			return this.lastName;
		}

		public string Getemail()
		{
			return this.email;
		}

		public int GetTelephone()
		{
			return this.telephone;
		}

		public string GetAdress()
		{
			return this.address;
		}

		public float GetSalary()
		{
			return this.salary;
		}
		public string GetFullName()
		{
			string fullName = firstName + " " + lastName;
			return fullName;
		}
	}
}
