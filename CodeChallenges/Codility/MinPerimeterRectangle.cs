using System;

namespace CodeChallenges.Codility
{
    public class MinPerimeterRectangle
    {
        public int solution(int N)
        {
            var minPerimeter = int.MaxValue;

            if (N == 1)
            {
                return 4;
            }

            for (var i = 1; i < N / 2; i++)
            {
                if (N % i == 0)
                {
                    minPerimeter = Math.Min(minPerimeter, (N / i + i) * 2);
                }
            }

            return minPerimeter;
        }
    }
}