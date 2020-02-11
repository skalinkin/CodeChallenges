namespace CodeChallenges.Codility
{
    public class CountFactors
    {
        public int solution(int N)
        {
            if (N == 1)
            {
                return 1;
            }

            var count = 2;
            for (var i = 2; i <= N / 2; i++)
            {
                if (N % i == 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}