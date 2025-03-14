using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheFilm = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colons = int.Parse(Console.ReadLine());
            int allSeats = rows * colons;
            double allMoney = 0.00;
            switch (nameOfTheFilm)
            {
                case "Premiere":
                    allMoney = allSeats * 12.00;
                    break;
                case "Normal":
                    allMoney = allSeats * 7.50;
                    break;
                case "Discount":
                    allMoney = allSeats * 5.00;
                    break;
            }
            Console.WriteLine($"{allMoney:f2} leva");
        }
    }
}