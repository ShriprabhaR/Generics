using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsPractice
{
    internal class GenericsUsingWithMethod
    {
        public static void ToPrint<T>(T[] inputArray)
        {
            foreach (T element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-----");
        }

    }
}
