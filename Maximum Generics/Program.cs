using System;

namespace Maximum_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Max of three numbers using generics Programs");

            FindMaximum findMaximum = new FindMaximum();
            Console.WriteLine("Maximum of three floating values is: " + findMaximum.findMaxDoubleValue(8.9, 5.7, 3.4));
        }
    }
}
