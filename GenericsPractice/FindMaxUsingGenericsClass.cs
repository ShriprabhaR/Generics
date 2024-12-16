using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsPractice
{
    internal class FindMaxUsingGenericsClass<T> where T : IComparable<T>

    {
        private T value1;
        private T value2;
        private T value3;

        public FindMaxUsingGenericsClass(T value1, T value2, T value3)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
        }

        public T FindMax()
        {

            if (value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0)
            {
                return value1;
            }
            else if (value2.CompareTo(value3) > 0 && value2.CompareTo(value1) > 0)
            {
                return value2;
            }
            else
            {
                return value3;
            }

        }
    }
}
