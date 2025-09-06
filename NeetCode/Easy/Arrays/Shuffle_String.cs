using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.Easy.Arrays
{
    public class Shuffle_String
    {
        public string RestoreString(string s, int[] indices)
        {
            int index = 0;
            char[] result = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                index = indices[i];
                result[index] = s[i];
            }
            return new string(result);
        }
    }
}
