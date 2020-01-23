using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests.Codility
{
    [TestFixture]
    public class FrogRiverOneSolutionTest
    {
        [TestCase(new[] {1, 3, 1, 4, 2, 3, 5, 4}, 6, 5)]
        [TestCase(new[] {1, 3, 1, 4, 2, 3, 2, 4}, -1, 5)]
        [TestCase(new[] {1}, 0, 1)]
        [TestCase(new[] {1, 2}, 1, 2)]
        public void test_solution_withGivenArray_returnsTheEarliestTimeWhenTheFrogCanJump(int[] given, int expected,
            int distance)
        {
            var target = new FrogRiverOne();
            var actual = target.solution(distance, given);
            Assert.AreEqual(expected, actual);
        }
    }
}