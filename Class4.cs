using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// circumference and area of a circle
namespace Assignment1
{
    class Class4
    {
        static void Main(string[] args)
        {
            double area, perimeter;
            Class4.circle(5, out area, out perimeter);
            double C_area = Math.Round(area);
            double C_perimeter = Math.Round(perimeter * 1000) / 1000.0;
            Console.WriteLine("Area of Circle is {0}\t", C_area);
            Console.WriteLine("Perimeter of Circle is {0}\t", C_perimeter);
            Console.ReadLine();
        }
        public static void circle(double r, out double area, out double perimeter)
        {
            double PI = 3.1415;
            area = 2 * PI * r;
            perimeter = PI * r * r;
        }
    }
}
