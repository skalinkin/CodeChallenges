using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChallenges.Codility
{
    public class Dominator
    {
        public int solution(int[] A)
        {
            var counts = new Dictionary<int, int>();

            foreach (var i in A)
            {
                if (!counts.ContainsKey(i))
                {
                    counts.Add(i, 1);
                }
                else
                {
                    counts[i]++;
                }
            }

            if (counts.Count != 0)
            {
                var maxCount = counts.First().Value;
                var leadNumber = counts.First().Key;

                foreach (var count in counts)
                {
                    if (maxCount < count.Value)
                    {
                        maxCount = count.Value;
                        leadNumber = count.Key;
                    }
                }

                if (maxCount > A.Length / 2)
                {
                    return Array.IndexOf(A, leadNumber);
                }
            }

            return -1;
        }
    }
}