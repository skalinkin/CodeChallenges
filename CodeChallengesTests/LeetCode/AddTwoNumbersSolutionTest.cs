using CodeChallenges.LeetCode;
using NUnit.Framework;

namespace CodeChallengesTests.LeetCode
{
    [TestFixture]
    public class AddTwoNumbersSolutionTest
    {
        [Test]
        public void test_returnsSumLinkedList()
        {
            var l1 = new ListNode(2) {next = new ListNode(4) {next = new ListNode(3)}};
            var l2 = new ListNode(5) {next = new ListNode(6) {next = new ListNode(4)}};

            var target = new AddTwoNumbersSolution();
            var actual = target.AddTwoNumbers(l1,l2);
        }
    }
}