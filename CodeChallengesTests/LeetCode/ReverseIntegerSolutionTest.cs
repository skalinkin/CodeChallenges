using CodeChallenges.LeetCode;
using NUnit.Framework;

namespace CodeChallengesTests.LeetCode
{
    [TestFixture]
    public class ReverseIntegerSolutionTest
    {
        [TestCase(123, 321)]
        [TestCase(-123, -321)]
        [TestCase(120, 21)]
        [TestCase(1534236469, 0)]
        public void test_methodName_withCertainState_shouldDoSomething(int given, int expected)
        {
            var target = new ReverseInteger();
            var actual = target.Reverse(given);
            Assert.AreEqual(expected, actual);
        }
    }
}