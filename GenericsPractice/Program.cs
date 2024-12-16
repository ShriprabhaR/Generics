using System;

namespace GenericsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 1.2, 1.3 };
            char[] charArray = { 'a', 'b', 'c' };

            // without generics
            //PrintArray.ToPrint(intArray);
            //PrintArray.ToPrint(doubleArray);
            //PrintArray.ToPrint(charArray);

            //generics with method
            //GenericsUsingWithMethod.ToPrint<int>(intArray);
            //GenericsUsingWithMethod.ToPrint<double>(doubleArray);
            //GenericsUsingWithMethod.ToPrint<char>(charArray);

            //generics with class
            //new GenericsUsingWithClass<int>(intArray).ToPrint();
            //new GenericsUsingWithClass<double>(doubleArray).ToPrint();
            //new GenericsUsingWithClass<char>(charArray).ToPrint();

            //int MaxInt = MaximumOf3.MaxOf3(20, 40, 10);
            //Console.WriteLine("Biggest:"+MaxInt);

            //double MaxDouble = MaximumOf3.MaxOf3(80.5, 40.6, 10.1);
            //Console.WriteLine("Biggest:" + MaxDouble);

            //String MaxString = MaximumOf3.MaxOf3("Xebra", "Zebra", "zebra");
            //Console.WriteLine("Biggest:" + MaxString);


            Console.WriteLine(FindMaxUsingGenerics.FindMax("Zebra", "Orange", "Apple"));
            Console.WriteLine(FindMaxUsingGenerics.FindMax(3, 10, 7)); 
            Console.WriteLine(FindMaxUsingGenerics.FindMax(4.5, 6.7, 1.2));
            Console.WriteLine(FindMaxUsingGenerics.FindMax('m', 's', 'v'));

            FindMaxUsingGenericsClass<String> findMaxString = new FindMaxUsingGenericsClass<String>("Zebra", "Orange", "Apple");
            String str =findMaxString.FindMax();
            Console.WriteLine(str);

            FindMaxUsingGenericsClass<int> findMaxInt = new FindMaxUsingGenericsClass<int>(3, 10, 7);
            int n = findMaxInt.FindMax();
            Console.WriteLine(n);

            FindMaxUsingGenericsClass<double> findMaxDouble = new FindMaxUsingGenericsClass<double>(4.5, 6.7, 1.2);
            double d = findMaxDouble.FindMax();
            Console.WriteLine(d);


        }
    }
}
