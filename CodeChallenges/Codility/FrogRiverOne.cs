using System;

namespace CodeChallenges.Codility
{
    public class FrogRiverOne
    {
        public int solution(int X, int[] A)
        {
            var positions = new bool [X+1];
            var frogPosition = 0;
            positions[frogPosition] = true;

            for (var i = 0; i < A.Length; i++)
            {
                positions[A[i]] = true;
                if (frogCanJump(positions))
                {
                    return i;
                }
            }

            return -1;
        }

        private bool frogCanJump(bool[] positions)
        {
            var canit = true;
            foreach (var position in positions)
            {
                if (!position)
                {
                    canit = false;
                    break;
                }
            }
            return canit;
        }
    }
}