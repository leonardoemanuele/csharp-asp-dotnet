using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"A rectangle has area of {Rect(4, 5)}");
            Console.WriteLine($"A circle has area of {Circle(4)}");
            Console.WriteLine($"A triangle has area of {Triang(10, 9)}");

        }

        static double Rect(double length, double width)
        {
            double area = length * width;
            return area;

        }
        static double Circle(double radius)
        {
            double area = Math.PI * Math.Pow(radius,2);
            return Math.Round(area,3);

        }
        static double Triang(double bottom, double height)
        {
            double area = bottom * height;
            return area;

        }
    }
}
