using Xunit;
using Leecode.Impl.AddTwoNumbers;

namespace LeetCodeTests
{
    public class AddTwotNumbersTest
    {
        private readonly Solution solution = new Solution();

        //Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        //Output: 7 -> 0 -> 8
        //Explanation: 342 + 465 = 807.
        [Fact]
        public void Test1()
        {
            var l1 = new ListNode(2)
            {
                Next = new ListNode(4)
                {
                    Next = new ListNode(3)
                }
            };

            var l2 = new ListNode(5)
            {
                Next = new ListNode(6)
                {
                    Next = new ListNode(4)
                }
            };

            var a = solution.AddTwoNumbers(l1, l2);
            var b = a.Next;
            var c = b.Next;

            Assert.Equal(7, a.Value);
            Assert.Equal(0, b.Value);
            Assert.Equal(8, c.Value);
        }

        [Fact]
        public void Test2()
        {
            var l1 = new ListNode(0);

            var l2 = new ListNode(0);

            var a = solution.AddTwoNumbers(l1, l2);

            Assert.Equal(0,a.Value);
        }
    }
}
