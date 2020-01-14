using System;
using NUnit.Framework;

namespace CodeChallengesTests
{
    [TestFixture]
    internal class FrogJmpSolutionTest
    {
        [TestCase(10,85,30,3)]
        [TestCase(10,100,30,3)]
        [TestCase(25,85,30,2)]
        public void AsserThatSolutionReturnsMinimalNumberOfJumpsFromXtoY(int X, int Y, int D, int expected)
        {
            var target = new CodeChallenges.FrogJmp.Solution();
            var actual = target.solution(X, Y, D);
            Assert.AreEqual(expected,actual);
        }

        [TestCase(int.MinValue,int.MaxValue,1, 100)]
        public void AsserThatSolutionReturnsMinimalNumberOfJumpsFromXtoYinScopeOfTimeout(int X, int Y, int D, int timeout)
        {
            
            var target = new CodeChallenges.FrogJmp.Solution();
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            target.solution(X, Y, D);
            timer.Stop();
            int milliseconds = timer.Elapsed.Milliseconds;
            bool ExecutionTimeLessThanFiveSeconds = (milliseconds < timeout);
            Assert.IsTrue(ExecutionTimeLessThanFiveSeconds, "Should take less than timeout");

        }
    }
}