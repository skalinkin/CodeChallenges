namespace CodeChallenges.Codility
{
    public class PassingCars
    {
        public int solution(int[] A)
        {
            var pairs = 0;
            var firstCar = A[0];
            var multiplayer = 0;
            var foundFirstCarTravelingEast = false;
            foreach (var element in A)
            {
                if (element == 1 && !foundFirstCarTravelingEast)
                {
                    continue;
                }

                foundFirstCarTravelingEast = true;

                if (element == firstCar)
                {
                    multiplayer++;
                }
                else
                {
                    pairs += multiplayer;
                    if (pairs > 1000000000)
                    {
                        return -1;
                    }
                }
            }

            return pairs;
        }
    }
}