﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Triangle_of_55_stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=10; i++) 
            {
                Console.WriteLine(new string('*', i));
            }
        }
    }
}