using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests
{
    [TestFixture]
    public class BracketsSolutionTest
    {
        [TestCase("{[()()]}",1)]
        [TestCase("([)()]", 0)]
        [TestCase(")(", 0)]
        public void test_solution_givenString_returnsIsItProperlyNested(string given, int expected)
        {
            var target = new Brackets();
            int actual = target.solution(given);
            Assert.AreEqual(expected, actual);
        }
    }
}