using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProgramsProject
{
    internal class GenericMethod
    {
        public static void ToPrint<T>(T[] array)
        {
            Console.WriteLine("\nHere Using Generic Method to show all types of Array");
            foreach (var item in array)
            {
                Console.WriteLine("Array Items: " + item);
            }
        }

    }
}
