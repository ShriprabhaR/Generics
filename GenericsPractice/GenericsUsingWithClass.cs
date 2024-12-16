using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsPractice
{
    internal class GenericsUsingWithClass<T>
    {
        private T[] inputArray;

        public GenericsUsingWithClass(T[] inputArray)
        {
            this.inputArray = inputArray;
        }


        public void ToPrint()
        {
            foreach (T elements in inputArray)
            {
                Console.WriteLine(elements);

            }
            Console.WriteLine("-------");
        }
    }
}
