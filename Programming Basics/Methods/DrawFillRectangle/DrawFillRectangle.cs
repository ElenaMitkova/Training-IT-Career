using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DrawFillRectangle
{
    internal class DrawFillRectangle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            DrawRectangleUp(n);
            for (int i = 0;i<n-2;i++)
            {
                DrawRectangleMiddle(n);
            }
            DrawRectangleDown(n);
        }
        static void DrawRectangleUp(int n)
        {
            Console.WriteLine(new string('-', 2*n));
        }
        static void DrawRectangleDown(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
        static void DrawRectangleMiddle(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
    }
}