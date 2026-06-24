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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode();
        ListNode sumNode = dummy;
        int remaining = 0;

        while(l1 != null || l2 != null || remaining !=0){
            int sum = remaining;
            
            if(l1 != null){
                sum += l1.val;
                l1 = l1.next;
            }
            if(l2 != null){
                sum += l2.val;
                l2 = l2.next;
            }

            remaining = sum / 10;
            sum = sum % 10;
            
            sumNode.next = new ListNode(sum);
            sumNode = sumNode.next;
        }

        return dummy.next;
    }
}
