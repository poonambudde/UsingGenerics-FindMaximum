using System;

namespace Maximum_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum of three numbers using Generics Programs");

            FindMaximum<int> findIntMax = new FindMaximum<int>();
            FindMaximum<double> findMaximumDouble = new FindMaximum<double>();
            FindMaximum<string> findstring = new FindMaximum<string>();

            Console.WriteLine("Maximum of Integer value is : " + findIntMax.findMaxValue(599, 482, 635));
            Console.WriteLine("Maximum Floating value is : " + findMaximumDouble.findMaxValue(304.45, 95.27, 467.18));
            Console.WriteLine("Maximum String is : " + findstring.findMaxValue("Apricot", "Banana", "Kiwi"));

        }

    }
}

