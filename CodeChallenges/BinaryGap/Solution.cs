using System;
using System.Collections;
using System.Linq;

namespace CodeChallenges.BinaryGap
{
    public class Solution
    {
        public int solution(int N)
        {
            var sequence = Convert.ToString(N, 2);
            sequence = sequence.Trim('0');
            var gaps = sequence.Split(new []{'1'},StringSplitOptions.RemoveEmptyEntries);
            if (gaps.Length == 0)
            {
                return 0;
            }

            Array.Sort(gaps, (x, y) => x.Length.CompareTo(y.Length));
            return gaps.Last().Length;
        }
    }
}