using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.Easy.Dictionary
{
    internal class HappyNumber
    {
        public bool IsHappy(int n)
        {
            int sum = 0;
            string nToString = n.ToString();
            if (n == 1)
            {
                return true;
            }

            HashSet<int> history = new HashSet<int>();
            while(nToString.Length != 0)
            {
                foreach(char c in nToString)
                    sum += (int)Math.Pow(Convert.ToInt32(c.ToString()), 2);

                if(sum == 1)
                    return true;

                if (!history.Add(sum))
                    return false;

                nToString = sum.ToString();
                sum = 0;
            }
            return false;
        }
    }
}
