using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NeetCode.Easy.TwoPointers
{
    internal class ValidPalidrome
    {
        public bool IsPalindrome(string s)
        {
            string result = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();
            bool finalResult=true;
            for (int i = 0, j = result.Length -1 ; i < j; i++,j--)
            {
                if (result[i] == result[j]) continue;
                return finalResult = false;
            }
            return finalResult;
        }
    }
}
