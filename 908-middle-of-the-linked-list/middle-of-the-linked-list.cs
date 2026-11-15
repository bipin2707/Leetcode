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
    public ListNode MiddleNode(ListNode head) {

        int len =0;
        ListNode a=head;
        ListNode b= head;

        while(a!=null)
        {
            len++;
            a=a.next;
        } 

        len=len/2;

        while (len>0)
        {
            b=b.next;
            len--;

        }

        return b;
        
    }
}