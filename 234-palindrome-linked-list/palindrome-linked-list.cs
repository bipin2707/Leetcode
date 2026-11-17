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

        if(head==null || head.next==null)
        {
            return true;
        }

        ListNode curr =head;
        ListNode slow=head;
        ListNode fast= head;
        

        while(fast!=null && fast.next != null) 
        {
            slow=slow.next;
            fast=fast.next.next;

        }

        ListNode prev=null;
        ListNode cur=slow;
        while(cur!=null)
        {
            ListNode next=cur.next;

            cur.next=prev;

            prev=cur;
            cur=next;
        }

        while(prev!=null)
        {
            if(prev.val!=curr.val)
            {
                return false;
            }
            curr=curr.next;
            prev=prev.next;
        }
        return true;
    }
}









// public class Solution {
//     public bool IsPalindrome(ListNode head) {

//         List<int> list=new List<int>();
//         ListNode curr= head;

//         while(curr!=null)
//         {
//             list.Add(curr.val);
//             curr=curr.next;
//         }

//         int l=0;
//         int r=list.Count-1;

//         while(l<r)
//         {
//             if(list[l]!=list[r])
//             {
//                 return false;
//             }

//             l++;
//             r--;
//         }
//         return true;
//     }
// }