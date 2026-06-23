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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode fast = head; ListNode slow = head;
        while(n > 0){
            fast = fast.next;
            n--;
        }
        while(fast != null && fast.next != null){
            fast = fast.next;
            slow = slow.next;
        }
        if(fast != null) slow.next = slow.next.next;
        else head = head.next;

        return head;
    }
}
