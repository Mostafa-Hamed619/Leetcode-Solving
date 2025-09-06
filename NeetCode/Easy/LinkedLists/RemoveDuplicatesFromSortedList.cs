using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.Easy.LinkedLists
{
    internal class RemoveDuplicatesFromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode currentNode = head;
            ListNode temp = null;
            ListNode InsertedNode = null;
            while (currentNode != null)
            {
                temp = currentNode.next;
                if (temp != null && currentNode.val == temp.val)
                {
                    currentNode.next = temp.next;
                }
                else
                {
                    currentNode = temp;
                }
                InsertedNode = currentNode;
            }
            return head;
        }
    }
}
