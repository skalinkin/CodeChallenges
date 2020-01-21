using System.Collections.Generic;

namespace CodeChallenges.Codility
{
    public class Leader
    {
        public int solution(int[] A)
        {
            var leader = GetLeader(A);
            var equiLeaderCount = 0;

            for (var i = 0; i < A.Length - 1; i++)
            {
                var left = GetLeader(A, 0, i);
                var right = GetLeader(A, i + 1, A.Length - 1);
                if (left == right)
                {
                    equiLeaderCount++;
                }
            }

            return equiLeaderCount;
        }

        private int? GetLeader(int[] A, int start, int finish)
        {
            var pool = new Stack<int>();
            for (var j = start; j <= finish; j++)
            {
                if (pool.Count == 0)
                {
                    pool.Push(A[j]);
                }
                else
                {
                    if (pool.Peek() == A[j])
                    {
                        pool.Push(A[j]);
                    }
                    else
                    {
                        pool.Pop();
                    }
                }
            }

            if (pool.Count == 0)
            {
                return null;
            }

            return pool.Peek();
        }

        private int GetLeader(int[] A)
        {
            var pool = new Stack<int>();

            foreach (var number in A)
            {
                if (pool.Count == 0)
                {
                    pool.Push(number);
                }
                else
                {
                    if (pool.Peek() == number)
                    {
                        pool.Push(number);
                    }
                    else
                    {
                        pool.Pop();
                    }
                }
            }

            return pool.Peek();
        }
    }
}