using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.Easy.Dictionary
{
    internal class Isomorphic_Strings
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            Dictionary<char, char> sToT = new Dictionary<char, char>();
            Dictionary<char, char> tToS = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                char charS = s[i];
                char charT = t[i];

                if (sToT.ContainsKey(charS))
                {
                    if (sToT[charS] != charT)
                        return false;
                }
                else
                {
                    if (tToS.ContainsKey(charT))
                        return false;

                    sToT[charS] = charT;
                    tToS[charT] = charS;
                }
            }

            return true;
        }

    }
}
