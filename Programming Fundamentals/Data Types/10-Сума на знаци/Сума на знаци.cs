using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _10_Сума_на_знаци
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                byte[]iii = Encoding.ASCII.GetBytes(Console.ReadLine());
                suma += iii[0];
                
            }
            Console.WriteLine($"The sum equals: {suma}");
        }
    }
}
