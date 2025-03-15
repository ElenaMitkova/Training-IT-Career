using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOP_ITKariera_
{
    internal class Student : Person
    {
		private string school;
		public string School
		{
			get { return school; }
			set { school = value; }
		}
	}
}