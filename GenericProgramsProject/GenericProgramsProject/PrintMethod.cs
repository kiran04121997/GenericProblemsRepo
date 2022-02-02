using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProgramsProject
{
    internal class PrintMethod
    {
        public static void ToPrint(int[] array)
        {
            Console.WriteLine("Int Array iterating");
            foreach (int item in array)
                Console.WriteLine("Array element: " + item);
        }

        public static void ToPrint(double[] array)
        {
            Console.WriteLine("\nDouble Array iterating");
            foreach (int item in array)
                Console.WriteLine("Array element: " + item);
        }

        public static void ToPrint(char[] array)
        {
            Console.WriteLine("\nChar Array iterating");
            foreach (int item in array)
                Console.WriteLine("Array element: " + item);
        }
    }
}
