using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests.Codility
{
    [TestFixture]
    public class MinAvgTwoSliceSolutionTest
    {
        [TestCase(new[] {4, 2, 2, 5, 1, 5, 8}, 1)]
        public void test_solution_givenNonEmptyArray_returnsStartingPosition(int[] given, int expected)
        {
            var target = new MinAvgTwoSlice();
            var actual = target.solution(given);
            Assert.AreEqual(expected, actual);
        }
    }
}