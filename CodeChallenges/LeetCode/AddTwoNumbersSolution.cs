namespace CodeChallenges.LeetCode
{
    public class AddTwoNumbersSolution
    {
        private int cary;

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var sum = cary;
            sum += l1?.val ?? 0;
            sum += l2?.val ?? 0;
            if (l1 == null && l2 == null)
            {
                if (sum > 0)
                {
                    return new ListNode(sum);
                }
                else
                {
                    return null;
                }
            }

            cary = sum / 10;
            var node = new ListNode(sum % 10);
            node.next = AddTwoNumbers(l1?.next, l2?.next);
            return node;
        }
    }

    public class ListNode
    {
        public ListNode next;
        public int val;

        public ListNode(int x)
        {
            val = x;
        }
    }
}