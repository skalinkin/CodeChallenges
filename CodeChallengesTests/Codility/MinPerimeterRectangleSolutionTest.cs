using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests.Codility
{
    [TestFixture]
    public class MinPerimeterRectangleSolutionTest
    {
        [TestCase(30,22)]
        [TestCase(1,4)]
        [TestCase(1000000000, 126500)]
        [TestCase(101, 204)]
        [TestCase(15486451, 30972904)]
        public void test_solution_givenAnNumber_returnsMinimalPerimeter(int given, int expected)
        {
            var target = new MinPerimeterRectangle();
            var actual = target.solution(given);
            Assert.AreEqual(expected, actual);
        }
    }
}