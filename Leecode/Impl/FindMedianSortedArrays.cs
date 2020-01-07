using System;
using System.Collections.Generic;
using System.Linq;

namespace Leecode.Impl.FindMedianSortedArrays
{
    public class Mediana
    {
        private readonly MedianaIndexes medianaIndexes;

        public Mediana(int[] nums)
        {
            medianaIndexes = new MedianaIndexes(nums.Length);
            Value = (nums[medianaIndexes.FirstIndex] + nums[medianaIndexes.LastIndex]) / 2.0;
        }

        public Mediana(List<int> nums, int length)
        {
            medianaIndexes = new MedianaIndexes(length);
            Value = (nums[medianaIndexes.FirstIndex] + nums[medianaIndexes.LastIndex]) / 2.0;
        }

        public double Value { get; private set; }

        public MedianaIndexes Indexes => medianaIndexes;

        public class MedianaIndexes
        {
            public int FirstIndex { get; private set; }
            public int LastIndex { get; private set; }
            public MedianaIndexes(int totalLength)
            {
                if (totalLength % 2 == 0)// 1,2,3,4
                {
                    LastIndex = totalLength / 2; //4 /2 = 2
                    FirstIndex = LastIndex - 1; // 2 - 1 = 1
                }
                else //1,2,3
                {
                    LastIndex = (totalLength - 1) / 2; //(3 -1) / 2 = 1
                    FirstIndex = LastIndex; // 1
                }
            }
        }
    }

    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0 && nums2.Length > 0)
            {
                return new Mediana(nums2).Value;
            }

            if (nums2.Length == 0 && nums1.Length > 0)
            {
                return new Mediana(nums1).Value;
            }

            int totalLength = nums1.Length + nums2.Length;

            int middleLength = (totalLength / 2) + 1;

            List<int> stacked = new List<int>();

            var result = new List<int>();

            for (int i = 0; i < middleLength; i++)
            {
                var list = new List<int>();

                if (i < nums1.Length)
                {
                    list.Add(nums1[i]);
                }

                if (i < nums2.Length)
                {
                    list.Add(nums2[i]);
                }

                if (stacked.Count() != 0)
                {
                    list.AddRange(stacked);
                    stacked.Clear();
                }

                list.Sort();

                if (list.Count() > 0)
                {
                    if (list.Count() == 2)
                    {
                        if (list[0] == list[1])
                        {
                            result.AddRange(list);
                        }
                        else
                        {
                            stacked.AddRange(list.TakeLast(list.Count() - 1));
                            result.Add(list.First());
                        }
                    }
                    else if (list.Count() == 1)
                    {
                        result.AddRange(list);
                    }
                    else
                    {
                        stacked.AddRange(list.TakeLast(list.Count() - 1));
                        result.Add(list.First());
                    }
                }

                if (result.Count() >= middleLength)
                {
                    break;
                }
            }

            return new Mediana(result, totalLength).Value;
        }
    }

}
