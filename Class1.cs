using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// switch case
namespace Assignment1
{
    class Class1
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            Console.Write("Enter first value:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second value:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for Subtraction");
            Console.WriteLine("Enter 3 for Multiplication");
            Console.WriteLine("Enter 4 for Division \n");
            int calsi = Convert.ToInt32(Console.ReadLine());

            switch (calsi)
            {
                case 1:
                    addition(x, y);
                    break;
                case 2:
                    substraction(x, y);
                    break;
                case 3:
                    multiplication(x, y);
                    break;
                case 4:
                    division(x, y);
                    break;
                default:
                    Console.WriteLine("no option");
                    break;

            }
            Console.ReadKey();
        }
        public static void addition(int x, int y)
        {
            int c = x + y;
            Console.WriteLine("Addition of two numbers is :" + c);
        }
        public static void substraction(int x, int y)
        {
            int c = x - y;
            Console.WriteLine("Substraction of two numbers is :" + c);
        }
        public static void multiplication(int x, int y)
        {
            int c = x * y;
            Console.WriteLine("multiplication of two numbers is:" + c);
        }
        public static void division(int x, int y)
        {
            int z = x / y;
            Console.WriteLine("Division of two numbers is:" + z);
        }

    }
}
