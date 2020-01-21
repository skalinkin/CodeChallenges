using System.Collections.Generic;

namespace CodeChallenges.Codility
{
    public class StoneWall
    {
        public int solution(int[] H)
        {
            var stack = new Stack<int>();

            var stones = 0;
            for (var i = 0; i < H.Length; i++)
            {
                while (stack.Count > 0 && stack.Peek() > H[i])
                {
                    stack.Pop();
                }

                if (stack.Count > 0 && stack.Peek() == H[i])
                {
                    continue;
                }

                stones++;
                stack.Push(H[i]);
            }

            return stones;
        }
    }
}