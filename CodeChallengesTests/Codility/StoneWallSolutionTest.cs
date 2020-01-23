using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests.Codility
{
    [TestFixture]
    public class StoneWallSolutionTest
    {
        [TestCase(new[] {8, 8, 5, 7, 9, 8, 7, 4, 8}, 7)]
        public void test_solution_givenHieghOfTheWall_returnsNumberOfBlocks(int[] given, int expected)
        {
            var target = new StoneWall();
            var actual = target.solution(given);
            Assert.AreEqual(expected, actual);
        }
    }
}