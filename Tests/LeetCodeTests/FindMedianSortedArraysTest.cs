using Xunit;
using Leetcode.Impl.FindMedianSortedArrays;

namespace LeetCodeTests
{
    public class FindMedianSortedArraysTest
    {
        private readonly Solution solution = new Solution();

        [Theory]
        [InlineData(new int[] { 1, 2 }, new int[] { -1, 3 }, 1.5)]
        [InlineData(new int[] { 7, 9, 12, 22 }, new int[] { 2, 19, 33, 45 }, 15.5)]
        [InlineData(new int[] { 30, 39, 57, 66, 88 }, new int[] { 12, 13, 55, 61, 72, 81, 85, 99 }, 61)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new int[] { 800, 900 }, 6.5)]
        [InlineData(new int[] { 1, 1 }, new int[] { 1, 2 }, 1)]
        [InlineData(new int[] { 1, 1 }, new int[] { 1, 2, 3 }, 1)]
        [InlineData(new int[] { 1, 2 }, new int[] { 2, 3 }, 2)]
        [InlineData(new int[] { 1, 2 }, new int[] { 1, 2 }, 1.5)]
        [InlineData(new int[] { 1, 3 }, new int[] { 2 }, 2)]
        [InlineData(new int[] { }, new int[] { 2, 3 }, 2.5)]
        [InlineData(new int[] { 100000 }, new int[] { 100001 }, 100000.5)]
        [InlineData(new int[] { 4, 5 }, new int[] { 1, 2, 3 }, 3)]
        public void Test(int[] nums1, int[] nums2, double expected)
        {
            double actual = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.Equal(expected, actual);
        }
    }
}
