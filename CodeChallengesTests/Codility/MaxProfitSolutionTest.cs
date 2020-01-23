using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests.Codility
{
    [TestFixture]
    public class MaxProfitSolutionTest
    {
        [TestCase(new[] {23171, 21011, 21123, 21366, 21013, 21367}, 356)]
        [TestCase(new[] {1, 2}, 1)]
        [TestCase(new[] {2, 1}, 0)]
        [TestCase(new[] {8, 9, 3, 6, 1, 2}, 3)]
        public void test_methodName_withCertainState_shouldDoSomething(int[] given, int expected)
        {
            var target = new MaxProfit();
            var actual = target.solution(given);
            Assert.AreEqual(expected, actual);
        }
    }
}