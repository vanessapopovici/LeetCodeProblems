using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>
            {
                {'I', 1 },
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 }
            };

            int total = 0;
            int n = s.Length;

            for(int i = 0; i < n; i++)
            {
                int currentVal = dictionary[s[i]];
                if(i + 1 < n && currentVal < dictionary[s[i + 1]])
                    total -= currentVal;
                else
                    total += currentVal;
            }
            return total;
        }
    }
}
