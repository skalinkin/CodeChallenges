namespace CodeChallenges.Codility
{
    public class MaxProfit
    {
        public int solution(int[] A)
        {
            var profit = 0;
            var min = int.MaxValue;

            foreach (var price in A)
            {
                min = price < min ? price : min;
                profit = price - min > profit ? price - min : profit;
            }

            return profit;
        }
    }
}