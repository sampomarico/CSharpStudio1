using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfACircleStudio
{
    public class Circle
    {
        public static int getRadius(string radius)
        {
            int radiusInput = int.Parse(radius);
            while (radiusInput <= 0)
            {
                Console.WriteLine("Invalid input. Please enter positive number:");
                Console.ReadLine();
            }
            return radiusInput;
        }
        public static double getCircleArea(double radius)
        {
            double radiusInput = radius;
            return Math.PI * radiusInput * radiusInput;
        }
        public static double getCircleCircumference(double radius)
        {
            double circumferenceOfCircle = 2 * Math.PI * radius;
            return circumferenceOfCircle;
        }
        public static double getCircleDiameter(double radius)
        {
            double diameterOfCircle = 2 * radius;
            return diameterOfCircle;
        }
        
            
        
    }
}
