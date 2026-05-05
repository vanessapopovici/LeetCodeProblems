using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;

            long reversedNumber = 0;
            int original = x;

            while (x > 0)
            {
                int lastDigit = x % 10;
                reversedNumber = (reversedNumber * 10) + lastDigit;
                x /= 10;
            }
            return original == reversedNumber;
        }
    }
}
