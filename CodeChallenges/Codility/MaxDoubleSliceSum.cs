using System.Collections.Generic;
using System.Xml.Schema;

namespace CodeChallenges.Codility
{
    public class MaxDoubleSliceSum
    {
        public int solution(int[] A)
        {
            var N = A.Length;
            var queue = new Queue<int>(N);

            var curentSlice = A[0];
            for (int i = 1; i < N -1 ; i++)
            {
                if (A[i] > A[i + 1])
                {
                    queue.Enqueue(curentSlice);
                }
            }

            return 0;
        }
    }
}