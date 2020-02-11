using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests.Codility
{
    [TestFixture]
    public class FlagsSolutionTest
    {
        [TestCase(new[] {1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2}, 3)]
        public void test_solution_givenMountenRange_returnsNumberOfFlags(int[] given, int expected)
        {
            var target = new Flags();
            var actual = target.solution(given);
            Assert.AreEqual(expected, actual);
        }
    }
}