using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.Easy.LinkedLists
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class Reverse_Linked_List
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode currentNode = head;
            ListNode PrevNode = null;
            ListNode Temp = null;
            while (currentNode != null)
            {
                Temp = currentNode.next;
                currentNode.next = PrevNode;
                PrevNode = currentNode;
                currentNode = Temp;
            }
            return PrevNode;
        }
    }
}
