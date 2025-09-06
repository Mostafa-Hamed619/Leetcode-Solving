using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.Easy.LinkedLists
{
    internal class MiddleOfTheLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode currentNode = head;
           
            int count = 0;
            while(currentNode != null)
            {
                count++;
                currentNode = currentNode.next;
            }
            currentNode = head;
            int middleCount = count / 2;
            
            for(int i =0; i< middleCount; i++)
            {
                currentNode = currentNode.next;
            }
          
            return currentNode;
        }
    }
}
