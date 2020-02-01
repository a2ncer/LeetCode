using Xunit;
using Leetcode.Impl.LengthOfLongestSubstring;

namespace LeetCodeTests
{
    public class LengthOfLongestSubstringTest
    {
        private readonly Solution solution = new Solution();


        [Fact]
        public void Test()
        {
            int actual = solution.LengthOfLongestSubstring("dfdv");
            
            Assert.Equal(3, actual);
        }

    }
}
