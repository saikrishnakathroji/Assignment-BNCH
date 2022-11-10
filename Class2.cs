using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Highest marks
namespace Assignment1
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the marks");
            int marks, highest = 0;
            for (int i = 1; i <= 5; i++)
            {
                marks = Convert.ToInt32(Console.ReadLine());
                if (marks > highest)
                {
                    highest = marks;
                }

            }
            Console.WriteLine("highest marks:" + highest);
            Console.ReadKey();
        }
    }
}
