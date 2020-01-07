using System.Collections.Generic;

namespace Leecode.AddTwoNumbers
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public partial class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            ListNode root = null;
            ListNode prevOne = null;

            int previous = 0;

            do
            {

                int a = l1 == null ? 0 : l1.val;
                int b = l2 == null ? 0 : l2.val;

                int sum = a + b + previous;

                previous = sum >= 10 ? 1 : 0;

                sum = sum >= 10 ? sum % 10 : sum;

                if (root == null)
                {
                    root = new ListNode(sum);
                    prevOne = root;
                }
                else
                {
                    var next = new ListNode(sum);
                    prevOne.next = next;
                    prevOne = next;
                }

                l1 = l1?.next;
                l2 = l2?.next;

            }
            while (l1 != null || l2 != null || previous == 1);

            return root;
        }
    }
}