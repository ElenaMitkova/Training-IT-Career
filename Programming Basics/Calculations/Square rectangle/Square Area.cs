﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Square_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            int area = a * a;
            Console.WriteLine($"Area: {area}");
        }
    }
}