using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//param array method
namespace Assignment1
{
    class Class3
    {
        static int sum(int[] arr, int n) 
        {

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }
        public static void Main()
        {
            int[] arr = { 24, 3, 45, 65, 85 };
            int n = arr.Length;

            Console.WriteLine("Sum of array value is " + sum(arr, n));
            Console.ReadKey();
        }
        
    }
}
