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
    public bool IsPalindrome(ListNode head) {

        List<int> list=new List<int>();
        ListNode curr= head;

        while(curr!=null)
        {
            list.Add(curr.val);
            curr=curr.next;
        }

        int l=0;
        int r=list.Count-1;

        while(l<r)
        {
            if(list[l]!=list[r])
            {
                return false;
            }

            l++;
            r--;
        }
        return true;
    }
}