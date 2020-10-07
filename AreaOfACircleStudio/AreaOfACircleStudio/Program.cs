using System;
using System.Security.Cryptography.X509Certificates;

namespace AreaOfACircleStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide radius of your circle:");
            double radius = Circle.getRadius(Console.ReadLine());
            Console.WriteLine("The area of a cricle of radius " + radius + " is: " + Circle.getCircleArea(radius) + ". The circumference is: "
                + Circle.getCircleCircumference(radius) + ", and the diameter is: " + Circle.getCircleDiameter(radius) + ".");
            Console.WriteLine("What is the MPG of your car?");
            int milesPerGallon = int.Parse(Console.ReadLine());
            double gasUsed = Circle.getCircleCircumference(radius) / milesPerGallon;
            Console.WriteLine("It will take " + gasUsed + "gallons of gas to go around the circle.");
        }
    }
}
