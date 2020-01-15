using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests
{
    [TestFixture]
    public class MissingIntegerSolutionTest
    {
        [TestCase(new[] {1, 3, 6, 4, 1, 2}, 5)]
        [TestCase(new[] {1, 2, 3}, 4)]
        [TestCase(new[] {-1, -3}, 1)]
        public void test_solution_whenGivenAnArrayOfIntegers_returnsSmallesPositiveIntergerThatIsNotInArray(int[] given,
            int expected)
        {
            var target = new MissingInteger();
            var actual = target.solution(given);
            Assert.AreEqual(expected, actual);
        }
    }
}