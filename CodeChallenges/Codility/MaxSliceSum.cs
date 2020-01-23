using System;

namespace CodeChallenges.Codility
{
    public class MaxSliceSum
    {
        public int solution(int[] A)
        {
            var N = A.Length;
            if (N==1)
            {
                return A[0];
            }

            var maxSlice = A[0];
            var maxCurrent = A[0];

            for (var index = 1; index < A.Length; index++)
            {
                var number = A[index];
                maxCurrent = Math.Max(A[index], maxCurrent + number);
                maxSlice = Math.Max(maxSlice, maxCurrent);
            }

            return maxSlice;
        }
    }
}