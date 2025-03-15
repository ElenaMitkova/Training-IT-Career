using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOP_ITKariera_
{
    internal class Employee :Person
    {
		private string company;
		public string Conpany
		{
			get { return company; }
			set { company = value; }
		}
	}
}
