using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests.Codility
{
    [TestFixture]
    public class MaxSliceSumSolutionTest
    {
        [TestCase(new[] {3, 2, -6, 4, 0}, 5)]
        public void test_solution_givenArray_returnsMaxSliceSum(int[] given, int expected)
        {
            var target = new MaxSliceSum();
            var actual = target.solution(given);
            Assert.AreEqual(expected, actual);
        }
    }
}