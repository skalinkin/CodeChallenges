using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests.Codility
{
    [TestFixture]
    public class MaxDoubleSliceSumSolutionTest
    {
        [TestCase(new[] {3, 2, 6, -1, 4, 5, -1, 2}, 17)]
        public void test_soltuion_givenAray_returnsMaxDoubleSliceSum(int[] given, int expected)
        {
            var target = new MaxDoubleSliceSum();
            var actual = target.solution(given);
            Assert.AreEqual(expected, actual);
        }
    }
}