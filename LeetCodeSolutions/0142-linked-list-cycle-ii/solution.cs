/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        ListNode slow = head; ListNode fast = head;   
        bool hasCycle = false;     

        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
            if(slow == fast){
                hasCycle = true;
                break;
            }
        }

        if(hasCycle){
            ListNode first = head; ListNode second = fast;

            while(first != second){
                first = first.next;
                second = second.next;
            }

            return first;
        }

        return null;
    }
}
