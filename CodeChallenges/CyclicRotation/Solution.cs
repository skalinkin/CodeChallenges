namespace CodeChallenges.CyclicRotation
{
    public class Solution
    {
        public int[] solution(int[] A, int K)
        {
            int[] newArray = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                var destinationIndex = CalculateDestinationIndex(A.Length, K, i);
                newArray[destinationIndex] = A[i];
            }

            return newArray;
        }

        private int CalculateDestinationIndex(int length, int offset, int i)
        {
            var size = length - 1;
            var index = i + offset;

            while (index > size)
            {
                index = index - length;
            }

            return index;
        }
    }
}