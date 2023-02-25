using System;

class Program
{
    static void Main(string[] args)
    {
        double length, width, radius, baseLength, height, area;

        // Square
        Console.WriteLine("Enter the length of one side of a square:");
        length = double.Parse(Console.ReadLine());
        area = length * length;
        Console.WriteLine("The area of the square is: " + area);

        // Rectangle
        Console.WriteLine("Enter the length of a rectangle:");
        length = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the width of a rectangle:");
        width = double.Parse(Console.ReadLine());
        area = length * width;
        Console.WriteLine("The area of the rectangle is: " + area);

        // Circle
        Console.WriteLine("Enter the radius of a circle:");
        radius = double.Parse(Console.ReadLine());
        area = Math.PI * radius * radius;
        Console.WriteLine("The area of the circle is: " + area);

        // Triangle
        Console.WriteLine("Enter the base length of a triangle:");
        baseLength = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height of a triangle:");
        height = double.Parse(Console.ReadLine());
        area = 0.5 * baseLength * height;
        Console.WriteLine("The area of the triangle is: " + area);

        Console.ReadLine();
    }
}
