namespace CodeChallenges.Codility
{
    public class MissingInteger
    {
        public int solution(int[] A)
        {
            var maxNumber = 1000000;
            var numbers = new int[maxNumber + 1];

            foreach (var element in A)
            {
                if (element < 1)
                {
                    continue;
                }

                numbers[element] = 1;
            }


            for (var i = 1; i <= numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    return i;
                }
            }

            return 1;
        }
    }
}
/*This is a demo task.

Write a function:

class Solution { public int solution(int[] A); }

that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

Given A = [1, 2, 3], the function should return 4.

Given A = [−1, −3], the function should return 1.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [1..100,000];
each element of array A is an integer within the range [−1,000,000..1,000,000].
*/