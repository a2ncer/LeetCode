using System;

namespace Leecode.FindMedianSortedArrays
{
    public partial class Solution
    {

        public static void Run()
        {
            Console.WriteLine($"[begin][{nameof(Leecode.FindMedianSortedArrays)}]");

            var medianSol = new Solution();
            // var answer = medianSol.FindMedianSortedArrays(new int[] { 7, 9, 12, 22 }, new int[] {2,19,33,45 });
            // var answer = medianSol.FindMedianSortedArrays(
            //  new int[] {30, 39, 57, 66, 88 }, 
            // new int[] {12,13,55,61,72,81,85,99 });

            // var answer = medianSol.FindMedianSortedArrays(
            //    new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
            //    new int[] {800, 900 });


            // var answer = medianSol.FindMedianSortedArrays(
            //   new int[] { 1, 1},
            //   new int[] { 1, 2});

            // var answer = medianSol.FindMedianSortedArrays(
            //   new int[] { 1, 2 },
            //   new int[] { 1, 2, 3 });

            // var answer = medianSol.FindMedianSortedArrays(
            // new int[] { 1, 2 },
            // new int[] { 2, 3 });

            // var answer = medianSol.FindMedianSortedArrays(
            //   new int[] { 1, 2 },
            //   new int[] { 1, 2});

            // var answer = medianSol.FindMedianSortedArrays(
            //   new int[] { 1, 3 },
            //   new int[] { 2 });

            //     var answer = medianSol.FindMedianSortedArrays(
            //    new int[] { },
            //    new int[] { 2, 3 });

            // var answer = medianSol.FindMedianSortedArrays(
            //         new int[] { 100000 },
            //         new int[] { 100001 });

            // var answer = medianSol.FindMedianSortedArrays(
            //         new int[] { 4,5 },
            //         new int[] { 1,2,3 });

            var answer = medianSol.FindMedianSortedArrays(
                    new int[] { 1,2 },
                    new int[] { -1,3 });        
        


            Console.WriteLine(answer);

            Console.WriteLine($"[end][{nameof(Leecode.FindMedianSortedArrays)}]");
        }


    }
}