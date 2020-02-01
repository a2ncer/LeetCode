using System;
using System.Collections.Generic;

namespace Leetcode.Impl.TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hash.ContainsKey(target - nums[i]))
                {
                    return new int[] { hash[target - nums[i]], i };
                }
                else if (!hash.ContainsKey(nums[i]))
                {
                    hash.Add(nums[i], i);
                }
            }
            throw new InvalidOperationException();
        }
    }
}