using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests.Codility
{
    [TestFixture]
    public class CountNonDivisibleSolutionTest
    {
        [TestCase(new[] {3, 1, 2, 3, 6}, new[] {2, 4, 3, 2, 0})]
        public void test_solution_givenArray_returnsAmountSequence(int[] given, int[] expected)
        {
            var target = new CountNonDivisible();
            var actual = target.solution(given);
            Assert.AreEqual(expected, actual);
        }
    }
}