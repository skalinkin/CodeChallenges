using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests
{
    [TestFixture]
    public class DominatorSolutionTest
    {
        [TestCase(new[] {1, 3, 4, 3, 2, 3, -1, 3, 3}, new[] {1, 3, 5, 8})]
        [TestCase(new[] {1, 1, 1, 1, 1, 2, 2, 2, 2, 2}, new[] {-1})]
        [TestCase(new int[] { }, new[] {-1})]
        [TestCase(new[] {1}, new[] {0})]
        [TestCase(new[] {0, 0, 1, 1, 1}, new[] {2, 3, 4})]
        public void test_solution_givenArray_returnsDominator(int[] given, int[] expected)
        {
            var target = new Dominator();
            var actual = target.solution(given);
            CollectionAssert.Contains(expected, actual);
        }
    }
}