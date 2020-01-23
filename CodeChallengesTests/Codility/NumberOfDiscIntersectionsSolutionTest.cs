using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests.Codility
{
    [TestFixture]
    public class NumberOfDiscIntersectionsSolutionTest
    {
        [TestCase(new int[]{1,5,2,1,4,0},11)]
        [TestCase(new int[]{0,0,0},0)]
        [TestCase(new int[]{0,1,0},2)]
        [TestCase(new int[]{1, 2147483647, 0},2)]
        public void test_solution_givenArray_returnsNumberOfPairs(int[] given, int expected)
        {
            var target = new NumberOfDiscIntersections();
            int actual = target.solution(given);
            Assert.AreEqual(expected, actual);
        }
    }
}