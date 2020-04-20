using System;

namespace Leetcode.Impl.ReverseInteger
{
    public class Solution
    {
        const int MAX_INT_DEVIDED = int.MaxValue / 10;
        public int Reverse(int number)
        {
            int reversed = 0;
            while (number != 0)
            {
                if (Math.Abs(reversed) > MAX_INT_DEVIDED)
                {
                    return 0;
                }
                int reversed_x_10 = reversed * 10;
                int number_mod_10 = number % 10;
                if (int.MaxValue - Math.Abs(reversed_x_10) < Math.Abs(number_mod_10))
                {
                    return 0;
                }
                reversed = reversed_x_10 + number_mod_10;
                number = number / 10;
            }
            return reversed;
        }

        public int Reverse2(int x)
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