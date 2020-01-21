using System.Collections.Generic;

namespace CodeChallenges.Codility
{
    public class Dominator
    {
        public int solution(int[] A)
        {
            var stack = new Stack<int>();

            foreach (var number in A)
            {
                if (stack.Count == 0)
                {
                    stack.Push(number);
                }
                else
                {
                    if (stack.Peek() == number)
                    {
                        stack.Push(number);
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }

            if (stack.Count == 0)
            {
                return -1;
            }

            var candidate = stack.Peek();
            var count = 0;

            foreach (var number in A)
            {
                if (number == candidate)
                {
                    count++;
                }
            }

            if (count <= A.Length / 2)
            {
                return -1;
            }

            var index = 0;
            for (var i = 0; i < A.Length; i++)
            {
                var number = A[i];
                if (number == candidate)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}