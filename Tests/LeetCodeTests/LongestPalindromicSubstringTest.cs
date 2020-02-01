using System;
using Leetcode.Impl.LongestPalindromicSubstring;
using Xunit;

namespace LeetCodeTests
{
    public class LongestPalindromicSubstringTest
    {
        private readonly Solution solution = new Solution();

        [Theory]
        [InlineData("a","a")]
        [InlineData("bb","bb")]
        [InlineData("aba","aba")]
        [InlineData("abba","abba")]
        [InlineData("babad","bab")]
        [InlineData("cbbd","bb")]
        [InlineData("abcd","a")]
        [InlineData("","")]
        [InlineData("ac","a")]
        public void TestName(string input, string expected)
        {
            string actual = solution.LongestPalindrome(input);
            
            Assert.Equal(expected,actual);
        }
    }
}
