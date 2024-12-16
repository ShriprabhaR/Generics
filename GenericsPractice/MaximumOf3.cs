using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsPractice
{
    internal class MaximumOf3
    {
        public static int MaxOf3(int x, int y, int z)
        {
            int big = x;
            if (y > big)
            {
                big = y;
            }
            else if (z > big)
            {
                big = z;
            }
            return big;
        }

        public static double MaxOf3(double x, double y, double z)
        {
            double big = x;
            if (y > big)
            {
                big = y;
            }
            else if (z > big)
            {
                big = z;
            }
            return big;
        }

        public static String MaxOf3(String x, String y, String z)
        {
            String big = x;

            if (String.Compare(y, big, StringComparison.Ordinal) > 0)
            {
                big = y;
            }

            if (String.Compare(z, big, StringComparison.Ordinal) > 0)
            {
                big = z;
            }

            return big;
        }



    }
}
