using System.Numerics;

namespace CodeChallenges.PermMissingElem
{
    public class Solution
    {
        public int solution(int[] A)
        {
            BigInteger size = A.Length + 1;
            BigInteger shouldBe = size * (size + 1) / 2;
            BigInteger wehave = 0; 
            foreach (var element in A)
            {
                wehave += element;
            }
            var missingElement =(int) (shouldBe - wehave);
            return missingElement;
        }
    }
}