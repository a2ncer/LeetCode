using Leetcode.Impl.ReverseInteger;
using Xunit;

namespace LeetCodeTests
{
    public class ReverseIntegerTest
    {
        private readonly Solution solution = new Solution();

        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        [InlineData(1534236469, 0)]
        [InlineData(-1534236469, 0)]
        [InlineData(0, 0)]
        public void Test(int input, int expected)
        {
            int actual = solution.Reverse(input);
            int actual2 = solution.Reverse2(input);
            
            Assert.Equal(expected, actual);
            Assert.Equal(expected, actual2);
        }
    }
}