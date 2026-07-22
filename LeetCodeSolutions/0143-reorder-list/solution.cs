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
    public void ReorderList(ListNode head) {
        // Phase 1: Fast/Slow pointer to find the middle
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        // Phase 2: Reverse the second half & Cut the connection (slow.next "mid.next" = null)
        ListNode prev = null;
        ListNode curr = slow.next;
        slow.next = null; // Important: Break the list into two!
        while (curr != null) {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }

        // Phase 3: Zipper Merge (Alternate nodes)
        ListNode curr1 = head;
        ListNode curr2 = prev;
        while (curr2 != null) {
            ListNode temp1 = curr1.next;
            ListNode temp2 = curr2.next;
        
            curr1.next = curr2;
            curr2.next = temp1;
        
            curr1 = temp1;
            curr2 = temp2;
        }
    }
}
