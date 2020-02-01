using System.Linq;
namespace Leetcode.Impl.LongestPalindromicSubstring
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            if (isPalindrome(s))
            {
                return s;
            }
            for (int i = s.Length - 1; i > 1; i--)
            {
                for (int k = 0; k <= s.Length - i; k++)
                {
                    string possiblePalindrome = s.Substring(k, i);

                    if (isPalindrome(possiblePalindrome))
                    {
                        return possiblePalindrome;
                    }
                }
            }
            return string.IsNullOrEmpty(s) ? s : s.First().ToString();
        }

        private bool isPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }
            int halfLength = s.Length / 2;
            int lastIndex = s.Length - 1;
            for (int i = 0; i < halfLength; i++)
            {
                char left = s[i];
                char right = s[lastIndex];

                if (left != right)
                {
                    return false;
                }
                lastIndex--;
            }
            return true;
        }
    }
}
