﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LoopByStep3
{
    internal class LoopByStep3
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}