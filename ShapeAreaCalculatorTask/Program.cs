using System;

namespace ShapeAreaCalculatorTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shape Area Calculator");
            Console.WriteLine("Rectangle Area: " + AreaOfRectangle(5, 10));
            Console.WriteLine("Circle Area: " + AreaOfCircle(7));
            Console.WriteLine("Triangle Area: " + AreaOfTriangle(5, 8));
            Console.WriteLine("Pentagon Area: " + AreaOfPentagon(6, 4));
            Console.WriteLine("Octagon Area: " + AreaOfOctagon(5));

            Console.ReadLine();
        }

        static double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }

        static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        static double AreaOfTriangle(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        static double AreaOfPentagon(double side, double apothem)
        {
            return (5 * side * apothem) / 2;
        }

        static double AreaOfOctagon(double side)
        {
            return 2 * (1 + Math.Sqrt(2)) * Math.Pow(side, 2);
        }
    }
}

