using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _4_Търсене_на_число
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = Console.ReadLine().Split(new[] { ' ', ',', ':' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            //List<int> list2 = Console.ReadLine().Split(new[] { ' ', ',', ':' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            //int takeElements = list[0], removedElements = list[1], searchedElement = list[2];
            //bool isThere = false;
            //List<int> newList = list.Take(takeElements).Skip(removedElements).ToList();
            //for (int i = 0; i < newList.Count; i++)
            //{
            //    if (newList[i] == searchedElement)
            //    {
            //        isThere = true;
            //        break;
            //    }
            //}
            //if (isThere)
            //{
            //    Console.WriteLine("YES!");
            //}
            //else
            //{
            //    Console.WriteLine("NO!");
            //}


            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> manipulation = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int takeElements = manipulation[0];
            int removeElements = manipulation[1];
            int searchedElement = manipulation[2];
            List<int> manipulatedList = numbers.Take(takeElements).Skip(removeElements).ToList();
            if (manipulatedList.Contains(searchedElement))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}