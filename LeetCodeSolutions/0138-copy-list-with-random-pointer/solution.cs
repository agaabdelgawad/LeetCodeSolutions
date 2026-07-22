/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        if (head == null) return null;

        // Phase 1: Clone nodes and weave them into the original list
        // A -> B -> C  becomes  A -> A' -> B -> B' -> C -> C'
        Node curr = head;
        while (curr != null) {
            Node clone = new Node(curr.val);
            clone.next = curr.next;
            curr.next = clone;
            curr = clone.next; // Move to the next original node
        }

        // Phase 2: Assign random pointers for the cloned nodes
        curr = head;
        while (curr != null) {
            if (curr.random != null) {
                // The clone's random is the clone of the original's random
                curr.next.random = curr.random.next; 
            }
            curr = curr.next.next; // Move to the next original node
        }

        // Phase 3: Unweave to restore original list and extract the cloned list
        curr = head;
        Node clonedHead = head.next; // A' is the head of the new list
        Node clonedCurr = clonedHead;

        while (curr != null) {
            curr.next = curr.next.next; // Restore original's next pointer
            if (clonedCurr.next != null) {
                clonedCurr.next = clonedCurr.next.next; // Set clone's next pointer
            }
        
            curr = curr.next;
            clonedCurr = clonedCurr.next;
        }

        return clonedHead;
    }
}
