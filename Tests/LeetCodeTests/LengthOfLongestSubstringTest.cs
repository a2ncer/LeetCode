using Xunit;
using Leecode.Impl.LengthOfLongestSubstring;

namespace LeetCodeTests
{
    public class LengthOfLongestSubstringTest
    {
        private readonly Solution solution = new Solution();


        [Fact]
        public void Test()
        {
            var actual = solution.LengthOfLongestSubstring("dfdv");
            Assert.Equal(3, actual);
        }

    }
}
