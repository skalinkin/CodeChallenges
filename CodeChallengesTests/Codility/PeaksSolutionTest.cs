using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests.Codility
{
    [TestFixture]
    public class PeaksSolutionTest
    {
        [TestCase(new []{1,2,3,4,3,4,1,2,3,4,6,2}, 3)]
        public void test_methodName_withCertainState_shouldDoSomething(int[] given, int expected)
        {
            var target = new Peaks();
            var actual = target.solution(given);
            Assert.AreEqual(expected, actual);
        }
    }
}