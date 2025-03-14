using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CashReceipt
{
    internal class CashReceipt
    {
        static void Main(string[] args)
        {
            UpperPart(args);
            MiddlePart(args);
            LastPart(args);
        }
        static void UpperPart(string[] args)
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void MiddlePart(string[] args)
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void LastPart(string[] args)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© IT KARIERA");
        }
    }
}