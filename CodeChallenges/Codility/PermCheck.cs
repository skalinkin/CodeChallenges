using System.Linq;

namespace CodeChallenges.Codility
{
    public class PermCheck
    {
        public int solution(int[] A)
        {
            var existing = new bool[A.Length];

            foreach (var i in A)
            {
                var index = i - 1;
                if (index > A.Length - 1)
                {
                    return 0;
                }
                existing[index] = true;
            }

            if (!existing.Contains(false))
            {
                return 1;
            }

            return 0;
        }
    }
}