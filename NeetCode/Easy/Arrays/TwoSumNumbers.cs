using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.Easy.Arrays
{
    public static class TwoSumNumbers
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var secondSumNumber = target - nums[i];

                for (int k = i + 1; k < nums.Length; k++)
                {
                    if (nums[k] == secondSumNumber)
                    {
                        return new int[] { i, k };
                    }
                }
            }
            return new int[0];
        }
    }
}
