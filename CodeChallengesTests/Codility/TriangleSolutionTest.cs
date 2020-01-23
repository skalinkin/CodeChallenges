using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests.Codility
{
    [TestFixture]
    public class TriangleSolutionTest
    {
        [TestCase(new[] {10, 2, 5, 1, 8, 20}, 1)]
        [TestCase(new[] {10, 50, 5, 1}, 0)]
        public void test_methodName_withCertainState_shouldDoSomething(int[] given, int expected)
        {
            var target = new Triangle();
            var actual = target.solution(given);
            Assert.AreEqual(expected, actual);
        }
    }
}