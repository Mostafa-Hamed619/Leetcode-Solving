using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.Easy.Arrays
{
    //[0,1,2,2,3,0,4,2]
    public class Remove_Array
    {
        public int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            int j = nums.Length - 1;
            int temp = 0;
            while (i < j)
            {
                if (nums[i] == val)
                {
                    if (nums[j] == val) j--;
                    else
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                        j--;
                        i++;
                    }
                }
                else
                {
                    i++;
                }
            }
          
           

            int count = 0;
            i = 0;
            while(i<nums.Length&& nums[i] != val)
            {
                count++;
                i++;
            }

            return count;
        }
    }
}
