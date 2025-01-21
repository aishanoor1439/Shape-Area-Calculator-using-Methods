using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Area_Calculator_using_Methods
{
    internal class Program
    {
        static double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }

        static double CalculateSquareArea(double side)
        {
            return side * side;
        }

        static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        static double CalculateTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        static double CalculatePentagonArea(double side, double apothem)
        {
            return 0.5 * 5 * side * apothem;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Select a shape to calculate its area:");
            Console.WriteLine("1. Rectangle\n2. Square\n3. Circle\n4. Triangle\n5. Pentagon");
            int choice = Convert.ToInt32(Console.ReadLine());

            double area = 0;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the length of the rectangle: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the width of the rectangle: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    area = CalculateRectangleArea(length, width);
                    break;

                case 2:
                    Console.Write("Enter the side of the square: ");
                    double side = Convert.ToDouble(Console.ReadLine());
                    area = CalculateSquareArea(side);
                    break;

                case 3:
                    Console.Write("Enter the radius of the circle: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    area = CalculateCircleArea(radius);
                    break;

                case 4:
                    Console.Write("Enter the base length of the triangle: ");
                    double baseLength = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the height of the triangle: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    area = CalculateTriangleArea(baseLength, height);
                    break;

                case 5:
                    Console.Write("Enter the side length of the pentagon: ");
                    double pentagonSide = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the apothem length of the pentagon: ");
                    double apothem = Convert.ToDouble(Console.ReadLine());
                    area = CalculatePentagonArea(pentagonSide, apothem);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid shape.");
                    return;
            }

            Console.WriteLine($"The area of the selected shape is: {area:F2}");
        }

    }
}
