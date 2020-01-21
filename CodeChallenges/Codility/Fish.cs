using System.Collections.Generic;

namespace CodeChallenges.Codility
{
    public class Fish
    {
        public int solution(int[] A, int[] B)
        {
            var alive = 0;
            var N = A.Length;
            var downstream = new Stack<int>(N);

            for (var i = 0; i < N; i++)
            {
                if (B[i] == 0)
                {
                    while (downstream.Count > 0)
                    {
                        if (downstream.Peek() < A[i])
                        {
                            downstream.Pop();
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (downstream.Count == 0)
                    {
                        alive++;
                    }
                }
                else
                {
                    downstream.Push(A[i]);
                }
            }

            alive += downstream.Count;
            return alive;
        }
    }
}