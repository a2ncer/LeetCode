using System;

namespace Leecode.LengthOfLongestSubstring
{
    public partial class Solution
    {
        public static void Run()
        {
            Console.WriteLine($"[begin][{nameof(Leecode.LengthOfLongestSubstring)}]");

            var result = new Solution().LengthOfLongestSubstring("dfdv");

            Console.WriteLine(result);

            Console.WriteLine($"[end][{nameof(Leecode.LengthOfLongestSubstring)}]");
        }
    }
}


