using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _15_Векове_към_наносекунди
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            Console.WriteLine($"{centuries} centuries = {centuries*100} years = {(int)((centuries * 100)* 365.2422)} " +
                $"days = {((int)((centuries * 100) * 365.2422))*24} hours = " +
                $"{(((int)((centuries * 100) * 365.2422)) * 24)*60} minutes = " +
                $"{((((uint)((centuries * 100) * 365.2422)) * 24) * 60) *60} seconds = " +
                $"{(((((long)((centuries * 100) * 365.2422)) * 24) * 60) * 60)*1000} milliseconds = " +
                $"{((((((ulong)((centuries * 100) * 365.2422)) * 24) * 60) * 60) * 1000)*1000} microseconds = " +
                $"{(((((((ulong)((centuries * 100) * 365.2422)) * 24) * 60) * 60) * 1000) * 1000)*1000} nanoseconds");
        }
    }
}