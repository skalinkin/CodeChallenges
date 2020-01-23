using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests.Codility
{
    [TestFixture]
    public class NestingSolutionTest
    {
        [TestCase("(()(())())", 1)]
        [TestCase("())", 0)]
        public void test_solution_givenAstring_returnsIfStringIsNested(string given, int expected)
        {
            var target = new Nesting();
            int actual = target.solution(given);
            Assert.AreEqual(expected, actual);
        }
    }
}