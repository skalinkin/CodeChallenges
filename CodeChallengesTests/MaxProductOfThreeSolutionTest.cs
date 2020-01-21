using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests
{
    [TestFixture]
    public class MaxProductOfThreeSolutionTest
    {
        [TestCase(new[] {-3, 1, 2, -2, 5, 6}, 60)]
        [TestCase(new[] {-5, 5, -5, 4}, 125)]
        public void test_solution_givenArray_returnsMaxProductOfTriplets(int[] given, int expected)
        {
            var target = new MaxProductOfThree();
            var actual = target.solution(given);
            Assert.AreEqual(expected, actual);
        }
    }
}