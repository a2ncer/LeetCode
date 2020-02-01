using System;

namespace Leetcode.Impl.LengthOfLongestSubstring
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var longestSubstringLength = 0;
            var position = 0;

            int i = 0;
            while (i < s.Length + 1)
            {
                var sub = s.Substring(position, i - position);

                longestSubstringLength = Math.Max(longestSubstringLength, sub.Length);

                if (i < s.Length && sub.Contains(s[i]))
                {
                    position = s.IndexOf(s[i], position) + 1;
                    i = position;
                }
                else
                {
                    i++;
                }
            }

            return longestSubstringLength;
        }

    }
}