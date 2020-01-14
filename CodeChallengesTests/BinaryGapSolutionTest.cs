using System;
using NUnit.Framework;

namespace CodeChallengesTests
{
    [TestFixture]
    internal class BinaryGapSolutionTest
    {
        [TestCase(1041, 5)]
        [TestCase(15, 0)]
        [TestCase(1, 0)]
        [TestCase(2147483647, 0)]
        [TestCase(6, 0)]
        [TestCase(328, 2)]
        [TestCase(1162, 3)]
        [TestCase(561892, 3)]
        [TestCase(6291457, 20)]
        [TestCase(74901729, 4)]
        [TestCase(805306373, 25)]
        [TestCase(1073741825, 29)]
        [TestCase(1610612737, 28)]
        public void WhenPassIntegerReturnsTheLongestGap(int argument, int expected)
        {
            var target = new CodeChallenges.BinaryGap.Solution();

            var actual = target.solution(argument);

            Assert.AreEqual(expected, actual);
        }
    }
}