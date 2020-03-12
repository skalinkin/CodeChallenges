namespace CodeChallenges.LeetCode
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            var result = 0;
            try
            {
                var remainder = 0;
                while (x != 0 || remainder != 0)
                {
                    checked
                    {
                        if (x != 0)
                        {
                            result *= 10;
                        }

                        remainder = x % 10;
                        result += remainder;
                        x /= 10;
                    }
                }
            }
            catch
            {
                return 0;
            }

            return result;
        }
    }
}