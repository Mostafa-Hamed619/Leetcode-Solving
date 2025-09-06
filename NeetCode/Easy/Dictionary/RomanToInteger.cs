using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.Easy.Dictionary
{
    internal class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            int count = 0;
            Dictionary<char, int> Romans = new();

            Romans.Add('I', 1);
            Romans.Add('V', 5);
            Romans.Add('X', 10);
            Romans.Add('L', 50);
            Romans.Add('C', 100);
            Romans.Add('D', 500);
            Romans.Add('M', 1000);
            for(int i =0; i< s.Length; i++)
            {
                
                if (i+1 < s.Length && Romans[s[i]] < Romans[s[i + 1]])
                    count-= Romans[s[i]];
                else
                    count += Romans[s[i]];
            }
            return count;
        }
    }
}
