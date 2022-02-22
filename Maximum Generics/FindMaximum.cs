using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum_Generics
{
    class FindMaximum
    {
        public string findMaxStringValue(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0)
            {
                return firstString;
            }
            else if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0)
            {
                return secondString;
            }
            else
            {
                return thirdString;
            }
        }
    }
}
