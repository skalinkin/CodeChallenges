using System.Collections.Generic;

namespace CodeChallenges.Codility
{
    public class Peaks
    {
        public int solution(int[] A)
        {
            var peaks = new List<int>();

            for (var i = 1; i < A.Length - 1; i++)
            {
                if (A[i - 1] < A[i] && A[i] > A[i + 1])
                {
                    peaks.Add(i);
                }
            }

            if (peaks.Count == 0)
            {
                return 0;
            }


            for (int i = peaks.Count; i > 0; i--)
            {
                if (A.Length % i == 0)
                {
                    var blockSize = A.Length / i;
                    var found = new bool [i];
                    var foundCount = 0;

                    foreach (var peak in peaks)
                    {
                        var blockNr = peak / blockSize;
                        if (!found[blockNr])
                        {
                            found[blockNr] = true;
                            foundCount++;
                        }
                    }

                    if (foundCount == i)
                    {
                        return i;
                    }

                } 
            }

            return 0;
        }
    }
}