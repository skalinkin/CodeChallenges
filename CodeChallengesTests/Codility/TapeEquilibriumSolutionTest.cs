using NUnit.Framework;

namespace CodeChallengesTests.Codility
{
    [TestFixture]
    public class TapeEquilibriumSolutionTest
    {
        [TestCase(new[]{3,1,2,4,3},1)]
        [TestCase(new[]{1,1},0)]
        [TestCase(new[]{-1000,1000},2000)]
        [TestCase(new[]{1000,-1000},2000)]
        public void AssertSolutionReturnsTheMinimalDifferenceThatCanBeAchieved(int[] given, int expected)
        {
            var target = new CodeChallenges.Codility.TapeEquilibrium();
            int actual = target.solution(given);
            Assert.AreEqual(expected,actual);
        }
    }
}