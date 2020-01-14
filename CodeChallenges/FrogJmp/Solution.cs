namespace CodeChallenges.FrogJmp
{
    public class Solution
    {
        public int solution(int X, int Y, int D)
        {
            if (X == Y) return 0;

            var distance = Y - X;
            var stepCount = distance / D;
            var leftOver = distance % D;

            if (leftOver > 0)
            {
                stepCount++;
            }
            return stepCount;
        }
    }
}