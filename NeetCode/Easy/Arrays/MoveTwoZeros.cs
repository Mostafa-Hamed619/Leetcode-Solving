using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.Easy.Arrays
{
    internal class MoveTwoZeros
    {
        // [0, 1, 0, 3, 5, 9]  --- 1
        // [1, 0, 0, 3, 5, 9]  ---- 2
        // [1, 0, 

        public void MovesTwoZero(int[] arr)
        {
            int i = 0; int j = 1;
            int temp = 0;
            for(; i < arr.Length-1; i++, j++)
            {
                if (arr[i] == 0)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            foreach(var num in arr)
            {
                Console.WriteLine(num);
            }
        }

    }
}
