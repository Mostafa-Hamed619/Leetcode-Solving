using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.Easy.Arrays
{
    public static class Anagram
    {
        static string SortStringAlphabeticalArrange(string str)
        {
            char[] stri = str.ToCharArray();
            Array.Sort(stri);
            return new string(stri);
        }

        public static bool IsAnagram(string s, string t)
        {
            return s.Length == t.Length && SortStringAlphabeticalArrange(s) == SortStringAlphabeticalArrange(t);
        }
    }
}
