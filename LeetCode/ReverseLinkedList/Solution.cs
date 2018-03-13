using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ReverseLinkedList
{
public class Solution 
{
    //https://leetcode.com/problems/reverse-linked-list/description/
    public ListNode ReverseList(ListNode head) 
    {
        if(head == null || head.next == null)
        {
            return head;
        }
        
        var count = 1;
        var currentNode = head;
        
        while(currentNode.next != null)
        {
            currentNode = currentNode.next;
            count++;
        }
        currentNode = head;
        var listValues = new int[count];
        
        for(int i = 0; i < count; i++)
        {
            listValues[i] = currentNode.val;
            currentNode = currentNode.next;
        }
        
        var resultListHead = new ListNode(listValues[count - 1]);
        var currentResultNode = resultListHead;
        
        for(int i = count - 2; i >= 0; i--)
        {
            currentResultNode.next = new ListNode(listValues[i]);
            currentResultNode = currentResultNode.next;
        }
        return resultListHead;
    }
}
}
