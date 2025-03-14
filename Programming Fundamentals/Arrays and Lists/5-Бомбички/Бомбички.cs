using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _5_Бомбички
{
    internal class Бомбички
    {
        static void Main(string[] args)
        {
            List<int>list = Console.ReadLine().Split(new[] {' ',',',':'}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> detonation = Console.ReadLine().Split(new[] { ' ', ',', ':' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int detonator = detonation[0],detonNum = detonation[1],suma=0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]==detonator)
                {
                    int left = i - detonNum;
                    int right = i + detonNum;
                    if (left < 0)
                    {
                        left = 0;
                    }
                    if (right > list.Count-1)
                    {
                        right = list.Count-1;
                    }
                    for (int j = left; j <= right; j++)
                    {
                        list.RemoveAt(left);   
                    }
                }
            }
            for(int i = 0;i < list.Count;i++)
            {
                suma += list[i];
            }
            Console.WriteLine(suma);
        }
    }
}