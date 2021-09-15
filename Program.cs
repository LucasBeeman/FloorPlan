using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            double addedUp = rectangle(2500, 1500) + circle(375) + triangle(750, 500);
            double completCost = addedUp * 180;
            double costRounded = Math.Round(completCost, 2);
            Console.WriteLine($"The floor will cost {costRounded} pesos.");
            Console.ReadKey();
        }

        static double rectangle(double length, double width)
        {
            double area = length * width;
            return area;
        }

        static double circle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        static double triangle(double bottom, double height)
        {
            double area = .5 * bottom * height;
            return area;
        }
    }
}