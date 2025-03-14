using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BonusPoint
{
    internal class BonusPoint
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            int points = int.Parse(Console.ReadLine());
            double bonusPoints = 0;
            if (points <= 100)
            {
                bonusPoints = bonusPoints + 5;
            }
            else if (points > 100 && points <= 1000)
            {
                bonusPoints = bonusPoints + points * 0.20;
            }
            else if (points > 1000)
            {
                bonusPoints = bonusPoints + points * 0.10;
            }
            if (points % 2 == 0)
            {
                bonusPoints = bonusPoints + 1;
            }
            if (points % 10 == 5)
            {
                bonusPoints = bonusPoints + 2;
            }
            double totalPoints = points + bonusPoints;
            Console.WriteLine("Bonus score: " + bonusPoints);
            Console.WriteLine("Total score: " + totalPoints);
        }
    }
}