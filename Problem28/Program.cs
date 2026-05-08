using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem28
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if(needle.Length == 0)
                return 0;

            int n = haystack.Length;
            int m = needle.Length;

            for (int i = 0; i <= n - m; i++)
            {
                int j = 0;

                while (j < m && haystack[i + j] == needle[j])
                    j++;

                if (j == m)
                    return i;
            }
            return -1;
        }
    }
}
