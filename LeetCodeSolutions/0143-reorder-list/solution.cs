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
        // Find the mid node
        ListNode slow = head;
        ListNode fast = head;

        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode mid = slow;

        // Reverse the second part
        ListNode previous = null;
        ListNode current = mid.next;
        mid.next = null;

        while(current != null){
            ListNode temp = current.next;
            current.next = previous;
            previous = current;
            current = temp;
        }

        // Merge the two parts
        ListNode cur1 = head;
        ListNode cur2 = previous;

        while(cur2 != null){
            ListNode temp1 = cur1.next;
            ListNode temp2 = cur2.next;
            cur1.next = cur2;
            cur2.next = temp1;
            cur1 = temp1;
            cur2 = temp2;
        }
    }
}
