using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.Easy.Dictionary
{
    internal class Majority_Element
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> NumMap = new Dictionary<int, int>();
            int Count = 0;
            var MaxFreq = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (NumMap.ContainsKey(nums[i]))
                {
                    NumMap[nums[i]]++;
                }
                else
                {
                    Count = 1;
                    NumMap[nums[i]] = Count;
                }
                if (NumMap[nums[i]] > nums.Length/2)
                {
                    return nums[i];
                }
            }
            

            return -1;
        }
    }
}
