using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests.Codility
{
    [TestFixture]
    internal class PermMissingElemSolutionTest
    {
        [Test]
        public void AssertThatSolutionReturnsMissingElementFromArray()
        {
            var target = new PermMissingElem();
            var given = new[] {2, 3, 1, 5};
            var actual = target.solution(given);
            var expected = 4;
            Assert.AreEqual(expected, actual);
        }
    }
}