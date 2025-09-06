using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.Medium.Arrays
{
    internal class ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums) //-----> O(n2)
        {

            int n = nums.Length;
            int[] result = new int[n];


            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = 1;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i != j) result[j] = nums[i];
                }

            }

            return result;
        }


        public int[] ProductExceptSelf2(int[] nums) // --->prefix and suffix O(n).
        {
            int n = nums.Length;
            int[] result = new int[n];


            result[0] = 1;
            for (int i = 1; i < n; i++)
            {
                result[i] = result[i - 1] * nums[i - 1];
            }


            int rightProduct = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                result[i] = rightProduct;
                rightProduct = nums[i];
            }

            return result;
        }
    }
}
