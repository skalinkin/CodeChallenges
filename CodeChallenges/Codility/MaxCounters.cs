﻿namespace CodeChallenges.Codility
{
    public class MaxCounters
    {
        public int[] solution(int N, int[] A)
        {
            var counters = new int[N];
            var currentMax = 0;
            var lastIncrese = 0;
            var cieling = N + 1;

            foreach (var element in A)
            {
                if (element == cieling)
                {
                    lastIncrese = currentMax;
                }
                else
                {
                    var numberPosition = element - 1;
                    if (counters[numberPosition] <= lastIncrese)
                    {
                        counters[numberPosition] = lastIncrese;
                    }

                    counters[numberPosition]++;

                    if (counters[numberPosition] > currentMax)
                    {
                        currentMax = counters[numberPosition];
                    }
                }
            }

            for (var i = 0; i < counters.Length; i++)
            {
                if (counters[i] < lastIncrese)
                {
                    counters[i] = lastIncrese;
                }
            }

            return counters;
        }
    }
}

/*You are given N counters, initially set to 0, and you have two possible operations on them:

increase(X) − counter X is increased by 1,
max counter − all counters are set to the maximum value of any counter.
A non-empty array A of M integers is given. This array represents consecutive operations:

if A[K] = X, such that 1 ≤ X ≤ N, then operation K is increase(X),
if A[K] = N + 1 then operation K is max counter.
For example, given integer N = 5 and array A such that:

    A[0] = 3
    A[1] = 4
    A[2] = 4
    A[3] = 6
    A[4] = 1
    A[5] = 4
    A[6] = 4
the values of the counters after each consecutive operation will be:

    (0, 0, 1, 0, 0)
    (0, 0, 1, 1, 0)
    (0, 0, 1, 2, 0)
    (2, 2, 2, 2, 2)
    (3, 2, 2, 2, 2)
    (3, 2, 2, 3, 2)
    (3, 2, 2, 4, 2)
The goal is to calculate the value of every counter after all operations.

Write a function:

class Solution { public int[] solution(int N, int[] A); }

that, given an integer N and a non-empty array A consisting of M integers, returns a sequence of integers representing the values of the counters.

Result array should be returned as an array of integers.

For example, given:

    A[0] = 3
    A[1] = 4
    A[2] = 4
    A[3] = 6
    A[4] = 1
    A[5] = 4
    A[6] = 4
the function should return [3, 2, 2, 4, 2], as explained above.

Write an efficient algorithm for the following assumptions:

N and M are integers within the range [1..100,000];
each element of array A is an integer within the range [1..N + 1].
*/