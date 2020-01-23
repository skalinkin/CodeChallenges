using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests.Codility
{
    [TestFixture]
    public class PassingCarsSolutionTest
    {
        [TestCase(new []{0,1,0,1,1},5)]
        [TestCase(new []{0,1},1)]
        [TestCase(new []{0,0},0)]
        [TestCase(new []{1,0},0)]
        public void test_solution_givenNonEmptyArray_returnsTheNumberOfPairs(int[] given, int expected)
        {
            var target = new PassingCars();
            int actual = target.solution(given);
            Assert.AreEqual(expected, actual);
        }
    }
}