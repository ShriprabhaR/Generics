using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsPractice
{
    internal class PrintArray
    {
        public static void ToPrint(int[] intArray)
        {
            foreach (int elements in intArray)
            {
                Console.WriteLine(elements);

            }
            Console.WriteLine("-----");
        }

        public static void ToPrint(double[] doubleArray)
        {
            foreach (double elements in doubleArray)
            {
                Console.WriteLine(elements);

            }
            Console.WriteLine("-----");
        }

        public static void ToPrint(char[] charArray)
        {
            foreach (char elements in charArray)
            {
                Console.WriteLine(elements);

            }
            Console.WriteLine("-----");
        }
    }
}
