using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests.Codility
{
    [TestFixture]
    public class DistinctSolutionTest
    {
        [TestCase(new int[]{2,1,1,2,3,1},3)]
        [TestCase(new int[]{2,1,5,4,3,6},6)]
        [TestCase(new int[]{1},1)]
        public void test_solution_givenArrayOfInterer_returnsNumberOfDistinctElements(int[] given, int expected)
        {
            var target = new Distinct();
            var actual = target.solution(given);
            Assert.AreEqual(expected, actual);
        }
    }
}