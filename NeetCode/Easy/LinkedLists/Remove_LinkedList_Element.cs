using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.Easy.LinkedLists
{
    internal class Remove_LinkedList_Element
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            while(head !=null && head.val == val)
            {
                head = head.next;
            }
            ListNode currentNode = head;
            ListNode Temp = null;

            while(currentNode != null && currentNode.next !=null)
            {
                Temp = currentNode.next;

                if(Temp.val == val)
                {
                    currentNode.next = Temp.next;
                }
                else
                {
                    currentNode = Temp;
                }
            }
            return head;
        }
    }
}
