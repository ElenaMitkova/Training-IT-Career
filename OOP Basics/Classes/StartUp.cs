using System;
using _01_ClassSquare;
    public class StartUp
    {
        static void Main(string[] args)
        {
        Square square = new Square();
        square.Side = 6;
        Console.WriteLine($"Circumference {square.Side * 4}");
        Console.WriteLine($"Area {square.Side * square.Side}");
        }
    }
