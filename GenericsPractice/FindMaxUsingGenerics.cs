using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsPractice
{
    internal class FindMaxUsingGenerics
    {

        public static T FindMax<T>(T value1, T value2, T value3) where T : IComparable<T>
        {

            if(value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0)
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
