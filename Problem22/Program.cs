using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateParenthesis(3);
        }
        public static IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();

            var sb = new StringBuilder();

            Backtrack(result, sb, 0, 0, n);
            return result;
        }
        public static void Backtrack(IList<string> result, StringBuilder sb, int open, int close, int max)
        {
            if (sb.Length == max * 2)
            {
                result.Add(sb.ToString());
                return;
            }

            if (open < max)
            {
                sb.Append("(");
                Backtrack(result, sb, open + 1, close, max);
                sb.Remove(sb.Length - 1, 1);
            }

            if (close < open)
            {
                sb.Append(")");
                Backtrack(result, sb, open, close + 1, max);
                sb.Remove(sb.Length - 1, 1);
            }
        }
    }
}
