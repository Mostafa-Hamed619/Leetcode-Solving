using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.Medium.TwoPointers
{
    internal class TwoIntegerSumII
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int i = 0;
            int j = numbers.Length - 1;
            while(i < j)
            {
                if (numbers[i] + numbers[j] > target)
                {
                    j--;
                }
                else if (numbers[i] + numbers[j] < target)
                {
                    i++;
                }
                else
                {
                    return new int[] { numbers[i], numbers[j] };
                }
            }
            throw new ArgumentException("No two sum solution");
        }
    }
}
