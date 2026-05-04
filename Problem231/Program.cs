using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        if (n <= 0)
        {
            return false;
        }
        return n == 1 ? true : n % 2 != 0 ? false : IsPowerOfTwo(n / 2);
    }
}