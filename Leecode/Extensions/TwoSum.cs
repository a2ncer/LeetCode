using System;
using System.Linq;
namespace Leecode.TwoSum
{
    public partial class Solution
    {
        //Your input
        //[2,7,11,15]
        //9
        //Output
        //[0,1]
        public static void Run()
        {

            Console.WriteLine($"[begin][{nameof(Leecode.TwoSum)}]");

            Test1();

            Console.WriteLine($"[end][{nameof(Leecode.TwoSum)}]");
        }

        public static void Test1()
        {
            var res = new Solution().TwoSum(new int[]
            {
                2,
                7,
                11,
                15
            }, 9);
            Console.WriteLine(string.Join(',', res));
        }
    }
}