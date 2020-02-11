using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests.Codility
{
    [TestFixture]
    public class CountFactorsSolutionTest
    {
        [TestCase(24,8)]
        public void test_solution_givenN_returnsNumberOfItsFactors(int given, int expected)
        {
            var target = new CountFactors();
            var actual = target.solution(given);
            Assert.AreEqual(expected, actual);
        }
    }
}