using System;
namespace Leecode.AddTwoNumbers
{
    public partial class Solution
    {
        //Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        //Output: 7 -> 0 -> 8
        //Explanation: 342 + 465 = 807.
        public static void Run()
        {

            Console.WriteLine($"[begin][{nameof(Leecode.AddTwoNumbers)}]");

            Test1();
            Test2();

            Console.WriteLine($"[end][{nameof(Leecode.AddTwoNumbers)}]");
        }

        public static void Test1()
        {

            var l1 = new ListNode(2)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(3)
                }
            };

            var l2 = new ListNode(5)
            {
                next = new ListNode(6)
                {
                    next = new ListNode(4)
                }
            };

            var a = new Solution().AddTwoNumbers(l1, l2);

            var b = a.next;

            var c = b.next;

            Console.WriteLine($"{a.val}->{b.val}->{c.val}");
        }

        public static void Test2()
        {

            var l1 = new ListNode(0);

            var l2 = new ListNode(0);

            var a = new Solution().AddTwoNumbers(l1, l2);

            Console.WriteLine($"{a.val}");
        }
    }
}