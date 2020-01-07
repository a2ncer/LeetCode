using Xunit;
using Leecode.Impl.TwoSum;

namespace LeetCodeTests
{
    public class TwoSumTest
    {
        private readonly Solution solution = new Solution();

        //Your input
        //[2,7,11,15]
        //9
        //Output
        //[0,1]
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        public void Test(int[] nums, int target, int[] expected)
        {
            var actual = solution.TwoSum(nums, target);
            Assert.Equal(expected, actual);
        }

    }
}
