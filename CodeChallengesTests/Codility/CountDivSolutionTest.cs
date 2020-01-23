using NUnit.Framework;
using CodeChallenges.Codility;

namespace CodeChallengesTests.Codility
{
    [TestFixture]
    public class CountDivSolutionTest
    {
        [TestCase(6,11,2,3)]
        [TestCase(6,11,12,0)]
        public void test_solution_GivenRangeAndDevider_retunsNumberOfDivisibles(int A, int B, int K, int expected)
        {
            var target = new CountDiv();
            var actual = target.solution(A,B,K);
            Assert.AreEqual(expected, actual);
        }
    }
}