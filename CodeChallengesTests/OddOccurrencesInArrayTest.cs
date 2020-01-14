using NUnit.Framework;

namespace CodeChallengesTests
{
    [TestFixture]
    internal class OddOccurrencesInArrayTest
    {
        [TestCase(new [] {9,3,9,3,9,7,9}, 7)]
        [TestCase(new [] {7,9,3,9,3,9,9}, 7)]
        [TestCase(new [] {7}, 7)]
        public void AssertThatSolutionReturnsTheValueOfTheUnpairedElement(int[] given, int expected)
        {
            var target = new CodeChallenges.OddOccurrencesInArray.Solution();
            var actual = target.solution(given);
            Assert.AreEqual(expected, actual);
        }
    }
}