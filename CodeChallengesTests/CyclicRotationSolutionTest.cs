using CodeChallenges.CyclicRotation;
using NUnit.Framework;

namespace CodeChallengesTests
{
    [TestFixture]
    internal class CyclicRotationSolutionTest
    {
        [TestCase(new[] {3, 8, 9, 7, 6}, 3, new[] {9, 7, 6, 3, 8})]
        [TestCase(new[] {3, 8, 9, 7, 6}, 5, new[] {3, 8, 9, 7, 6})]
        [TestCase(new[] {0, 0, 0}, 1, new[] {0, 0, 0})]
        [TestCase(new[] {1, 2, 3, 4}, 4, new[] {1, 2, 3, 4})]
        [TestCase(new[] {1}, 5, new[] {1})]
        [TestCase(new[] {1000}, 5, new[] {1000})]
        public void ArrayRotationTest(int[] given, int k, int[] expected)
        {
            var target = new Solution();
            var actual = target.solution(given, k);

            Assert.AreEqual(actual, expected);
        }
    }
}