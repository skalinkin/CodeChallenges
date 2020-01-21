using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests
{
    [TestFixture]
    public class FishSolutionTest
    {
        [TestCase(new[]{4,3,2,1,5},new[]{0,1,0,0,0}, 2)]
        [TestCase(new[]{4,3,2,1,5},new[]{1,1,1,1,1}, 5)]
        [TestCase(new[]{4,3,2,1,5},new[]{0,0,0,0,0}, 5)]
        [TestCase(new[]{4,3,2,1,5},new[]{1,0,0,0,0}, 1)]
        [TestCase(new[]{5,3,2,1,4},new[]{1,0,0,0,0}, 1)]
        [TestCase(new[]{4,3,2,1,5},new[]{0,0,0,0,1}, 5)]
        [TestCase(new[]{4,3,2,1,5},new[]{1,1,1,1,0}, 1)]
        [TestCase(new[]{1},new[]{0}, 1)]
        [TestCase(new[]{1},new[]{1}, 1)]
        public void test_solution_givenTwoArrays_returnsNumberOfLiveFish(int[] A, int[] B, int expected)
        {
            var target = new Fish();
            int actual = target.solution(A,B);
            Assert.AreEqual(expected, actual);
        }
    }
}