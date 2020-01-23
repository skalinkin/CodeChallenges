using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests.Codility
{
    [TestFixture]
    public class MaxCountersSolutionTest
    {
        [TestCase(new[] {3, 4, 4, 6, 1, 4, 4}, 5, new[] {3, 2, 2, 4, 2})]
        public void test_solution_givenArray_returnsCounters(int[] given, int counterNumber, object expected)
        {
            var target = new MaxCounters();
            var actual = target.solution(counterNumber, given);
            Assert.AreEqual(expected, actual);
        }
    }
}