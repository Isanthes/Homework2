using System;

namespace Homework2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Cube volume is {0}", GetVolume("5"));
            Console.WriteLine("Sphere volume is {0}", GetVolume(4.8));
            Console.WriteLine("Pyramid volume is {0}", GetVolume(2,3,5));
            Console.WriteLine("Cylinder volume is {0}", GetVolume("10",5));
            Console.WriteLine("Torus volume is {0}", GetVolume(10,15));

        }

        public static double GetVolume(string length)
        {
            return Math.Pow(Double.Parse(length), 3);
        }
        public static double GetVolume(double radius)
        {
            return 4 / 3 * Math.PI * Math.Pow(radius, 3);
        }

        public static double GetVolume(double length,double width, double height)
        {
            return (length * width * height) / 3;
        }

        public static double GetVolume(string radius, double height)
        {
            return Math.PI * height * Math.Pow(Double.Parse(radius), 2);
        }

        public static double GetVolume(double r, double R)
        {
            return (Math.PI * Math.Pow(R,2))*(2*Math.PI*R);
        }

    }
}
