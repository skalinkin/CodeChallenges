using System;

namespace CodeChallenges.Codility
{
    public class MaxDoubleSliceSum
    {
        public int solution(int[] A)
        {
            var N = A.Length;
            var sliceOne = new int[N];
            var sliceTwo = new int[N];

            for (var i = 1; i < N - 1; i++)
            {
                sliceOne[i] = Math.Max(sliceOne[i - 1] + A[i], 0);
            }

            for (int i = N - 2; i > 0; i--)
            {
                sliceTwo[i] = Math.Max(sliceTwo[i + 1] + A[i], 0);
            }

            var maxDoubleSliceSum = 0;

            for (var i = 1; i < N - 1; i++)
            {
                maxDoubleSliceSum = Math.Max(maxDoubleSliceSum, sliceOne[i - 1] + sliceTwo[i + 1]);
            }

            return maxDoubleSliceSum;
        }
    }
}