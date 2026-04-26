using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem961
{
    public class Solution
    {
        public int RepeatedNTimes(int[] nums)
        {
            HashSet<int> hash = new HashSet<int>();

            foreach (int n in nums)
            {
                if (hash.Contains(n))
                {
                    return n;
                }
                else
                {
                    hash.Add(n);
                }
            }
            return -1;
        }
    }
}
