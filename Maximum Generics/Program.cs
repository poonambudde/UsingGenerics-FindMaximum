using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maximum_Generics
{
    internal class FindMaximum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum of three numbers using Generics Programs");

            FindMaximum findMaximum = new FindMaximum();
            Console.WriteLine("Maximum Integer value is : " + findMaximum.findMaxValue<int>(599, 149, 853));
            Console.WriteLine("Maximum Floating value is : " + findMaximum.findMaxValue<double>(9.3, 6.5, 5.8));
            Console.WriteLine("Maximum String is : " + findMaximum.findMaxValue<string>("Apple", "Mango", "Banana"));
        }
        public T findMaxValue<T>(T firstValue, T secondValue, T thirdValue)
        {
            if (Comparer<T>.Default.Compare(firstValue, secondValue) > 0 && Comparer<T>.Default.Compare(firstValue, thirdValue) > 0)
            {
                return firstValue;
            }
            else if (Comparer<T>.Default.Compare(secondValue, firstValue) > 0 && Comparer<T>.Default.Compare(secondValue, thirdValue) > 0)
            {
                return secondValue;
            }
            else
            {
                return thirdValue;
            }
        }
    }
}

