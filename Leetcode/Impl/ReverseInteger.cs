namespace Leetcode.Impl.ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x)
        {
            int reversed = 0;
            int accumulator = 0;
            while (x != 0)
            {
                int remainder = x % 10;
                accumulator = reversed * 10 + remainder;
                if ((accumulator - remainder) / 10 != reversed)
                {
                    return 0;
                }
                reversed = accumulator;
                x /= 10;
            }
            return reversed;
        }
    }
}