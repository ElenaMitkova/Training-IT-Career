using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SmallShop
{
    internal class SmallShop
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double col = double.Parse(Console.ReadLine());
            double sum = 0;
            switch (product)
            {
                case "coffee":
                    switch (town)
                    {
                        case "Sofia":
                            sum = col * 0.50;
                            break;
                        case "Plovdiv":
                            sum = col * 0.40;
                            break;
                        case "Varna":
                            sum = col * 0.45;
                            break;
                    }
                    break;
                case "water":
                    switch (town)
                    {
                        case "Sofia":
                            sum = col * 0.80;
                            break;
                        case "Plovdiv":
                            sum = col * 0.70;
                            break;
                        case "Varna":
                            sum = col * 0.70;
                            break;
                    }
                    break;
                case "beer":
                    switch (town)
                    {
                        case "Sofia":
                            sum = col * 1.20;
                            break;
                        case "Plovdiv":
                            sum = col * 1.15;
                            break;
                        case "Varna":
                            sum = col * 1.10;
                            break;
                    }
                    break;
                case "sweets":
                    switch (town)
                    {
                        case "Sofia":
                            sum = col * 1.45;
                            break;
                        case "Plovdiv":
                            sum = col * 1.30;
                            break;
                        case "Varna":
                            sum = col * 1.35;
                            break;
                    }
                    break;
                case "peanuts":
                    switch (town)
                    {
                        case "Sofia":
                            sum = col * 1.60;
                            break;
                        case "Plovdiv":
                            sum = col * 1.50;
                            break;
                        case "Varna":
                            sum = col * 1.55;
                            break;
                    }
                    break;
            }
            Console.WriteLine(sum);
        }
    }
}