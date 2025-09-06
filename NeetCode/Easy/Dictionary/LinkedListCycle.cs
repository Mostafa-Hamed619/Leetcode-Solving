using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.Easy.Dictionary
{
    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
    internal class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            Dictionary<bool, int> ListMap = new Dictionary<bool, int>();

            ListNode current = head;
            bool result = false;
            while(current != null)
            {
                if(ListMap.ContainsValue(current.val))
                {
                    result = true;
                    return result;
                }
                ListMap.Add(true, current.val);
                current = current.next;
            }
            return result;
        }
    }
}

