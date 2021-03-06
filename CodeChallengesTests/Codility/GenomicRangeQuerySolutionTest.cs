﻿using CodeChallenges.Codility;
using NUnit.Framework;

namespace CodeChallengesTests.Codility
{
    [TestFixture]
    public class GenomicRangeQuerySolutionTest
    {
        [TestCase("CAGCCTA",new[]{2,5,0}, new[]{4,5,6},new[]{2,4,1})]
        [TestCase("C",new[]{0}, new[]{0},new[]{2})]
        [TestCase("AC",new[]{0,0,1}, new[]{0,1,1},new[]{1,1,2})]
        public void test_solution_givenDnaAndQuery_returnsAnswers(string gen, int[] P, int[] Q, int[] expected)
        {
            var target = new GenomicRangeQuery();
            var actual = target.solution(gen, P, Q);
            Assert.AreEqual(expected, actual);
        }
    }
}