namespace CodeChallenges.Codility
{
    public class CountNonDivisible
    {
        public int[] solution(int[] A)
        {
            var N = A.Length;
            var result = new int[N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i != j)
                    {
                        if (A[i] % A[j] != 0)
                        {
                            result[i]++;
                        }
                    }
                }
            }

            return result;
        }
    }
}