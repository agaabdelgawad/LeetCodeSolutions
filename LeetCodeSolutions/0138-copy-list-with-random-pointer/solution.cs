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
        if(head == null) return null;

        Dictionary<Node, Node> nodesDict = new Dictionary<Node, Node>();
        Node current = head;
        while(current != null){
            nodesDict[current] = new Node(current.val);
            current = current.next;
        }

        current = head;
        while(current != null){
            nodesDict[current].next = current.next != null ? nodesDict[current.next] : null;
            nodesDict[current].random = current.random != null ? nodesDict[current.random] : null;
            current = current.next;
        }

        return nodesDict[head];
    }
}
