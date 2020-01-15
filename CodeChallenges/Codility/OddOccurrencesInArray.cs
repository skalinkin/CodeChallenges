using System.Collections.Generic;
using System.Linq;

namespace CodeChallenges.Codility
{
    public class OddOccurrencesInArray
    {
        public int solution(int[] A)
        {
            var pairs = new HashSet<int>();

            foreach (var element in A)
                if (pairs.Contains(element))
                    pairs.Remove(element);
                else
                    pairs.Add(element);
            return pairs.First();
        }
    }
}