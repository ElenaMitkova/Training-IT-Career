using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GuessPassword
{
    internal class GuessPassword
    {
        static void Main(string[] args)
        {
            string pasword = Console.ReadLine();
            if (pasword == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}