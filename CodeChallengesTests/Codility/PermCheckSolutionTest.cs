using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests.Codility
{
    [TestFixture]
    public class PermCheckSolutionTest
    {
        [TestCase(new[] {4, 1, 3, 2}, 1)]
        public void test_solution_receivesPrematureArray_shouldReturn1(int[] given, int expected)
        {
            var target = new PermCheck();
            var actual = target.solution(given);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] {4, 1, 3}, 0)]
        public void test_solution_receivesNotPrematureArray_shouldReturn0(int[] given, int expected)
        {
            var target = new PermCheck();
            var actual = target.solution(given);
            Assert.AreEqual(expected, actual);
        }
    }
}