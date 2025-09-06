using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.Easy.Dictionary
{
    internal class StoneaAndJewels
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            Dictionary<char, int> JewelMap = new();
            int count = 0;
            foreach(var i in  jewels)
            {
                JewelMap[i] = i;
            }

            foreach(var i in stones)
            {
                if (JewelMap.ContainsKey(i))
                {
                    count++;
                }
            }
            
            return count;
        }
    }
}
