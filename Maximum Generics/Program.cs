using System;

namespace Maximum_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum of three numbers using Generics Programs");

            FindMaximum findMaximum = new FindMaximum();
            Console.WriteLine("Maximum Number is: " + findMaximum.findMaxIntValue(45, 89, 67));
        }
    }
}
