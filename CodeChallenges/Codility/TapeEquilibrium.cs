using System;

namespace CodeChallenges.Codility
{
    public class TapeEquilibrium
    {
        public int solution(int[] A)
        {
            var minimalDifference = int.MaxValue;
            var length = A.Length;
            var leftSplit = 0;
            var rightSplit = 0;

            for (var i = 0; i < length ; i++) rightSplit += A[i];

            for (var index = 0; index < A.Length - 1; index++)
            {
                var element = A[index];
                leftSplit += element;
                rightSplit -= element;
                var diff = leftSplit - rightSplit;
                var absDiff = Math.Abs(diff);

                if (minimalDifference > absDiff)
                {
                    minimalDifference = absDiff;
                }
            }

            return minimalDifference;
        }
    }
}