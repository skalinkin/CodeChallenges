using System.Collections.Generic;

namespace CodeChallenges.Codility
{
    public class Flags
    {
        public int solution(int[] A)
        {
            var peaks = new List<int>();
            for (var i = 1; i < A.Length - 1; i++)
            {
                if (A[i] > A[i - 1] && A[i] > A[i + 1])
                {
                    peaks.Add(i);
                }
            }

            if (peaks.Count == 1 || peaks.Count == 0)
            {
                return peaks.Count;
            }

            var leastFlags = 1;
            var mostFlags = peaks.Count;
            var result = 1;

            while (leastFlags <= mostFlags)
            {
                var flags = (leastFlags + mostFlags) / 2;
                var suc = false;
                var used = 0;
                var mark = peaks[0];

                foreach (var t in peaks)
                {
                    if (t >= mark)
                    {
                        used++;
                        mark = t + flags;
                        if (used == flags)
                        {
                            suc = true;
                            break;
                        }
                    }
                }

                if (suc)
                {
                    result = flags;
                    leastFlags = flags + 1;
                }
                else
                {
                    mostFlags = flags - 1;
                }
            }

            return result;
        }
    }
}