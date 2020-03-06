using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Very_Big_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter Array Size
            Console.Write("Enter Array Size : ");
            long size = long.Parse(Console.ReadLine());
            //input Array Elements
            long[] array = new long[size];
            Console.WriteLine("Enter ARray Elements");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = long.Parse(Console.ReadLine());

            }
            //Sum Of Array
            long sum = array.Sum();

            Console.WriteLine("Array Sum is :" + sum);
            Console.Read();
        }
    }
}
