using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _1_Празна_касова_бележка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Header();
            Middle();
            Footer();
        }
        static void Header()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void Middle()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void Footer ()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© BG");
        }
    }
}