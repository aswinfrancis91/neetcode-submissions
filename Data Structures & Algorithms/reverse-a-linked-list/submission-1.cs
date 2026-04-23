/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode previousNode=null;
        ListNode currentNode = head;
        while (currentNode != null) {
            ListNode tempNode = currentNode.next;
            currentNode.next = previousNode;
            previousNode = currentNode;
            currentNode = tempNode;
             
        };
        return previousNode;
    }
}
