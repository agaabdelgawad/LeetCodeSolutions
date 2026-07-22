// 1. Setup dictionary and Dummy nodes (Head, Tail)
// 2. Write RemoveNode(node)
// 3. Write InsertToHead(node)
// 4. Implement Get/Put using the helpers

public class LRUCache {
    // Node class definition for Doubly Linked List
    class Node {
        public int Key, Value;
        public Node Prev, Next;
        public Node(int key, int value) {
            Key = key;
            Value = value;
        }
    }

    // 1. Setup dictionary and Dummy nodes (Head, Tail)
    private int _capacity;
    private Dictionary<int, Node> _cache;
    private Node _head, _tail;

    public LRUCache(int capacity) {
        _capacity = capacity;
        _cache = new Dictionary<int, Node>();
        
        // Initialize dummy head and tail, and link them directly
        _head = new Node(-1, -1);
        _tail = new Node(-1, -1);
        _head.Next = _tail;
        _tail.Prev = _head;
    }

    // 2. Write RemoveNode(node)
    private void RemoveNode(Node node) {
        // Disconnect the node from its current neighbors
        node.Prev.Next = node.Next;
        node.Next.Prev = node.Prev;
    }

    // 3. Write InsertToHead(node)
    private void InsertToHead(Node node) {
        // Step A: New node reaches out to its new neighbors
        node.Next = _head.Next;
        node.Prev = _head;
        
        // Step B: Neighbors update their pointers to grab the new node
        _head.Next.Prev = node;
        _head.Next = node;
    }

    // 4. Implement Get/Put using the helpers
    
    public int Get(int key) {
        if (!_cache.ContainsKey(key)) return -1;
        
        Node node = _cache[key];
        
        // Update MRU (Most Recently Used) status
        RemoveNode(node);
        InsertToHead(node);
        
        return node.Value;
    }

    public void Put(int key, int value) {
        // If it already exists, remove the old version first
        if (_cache.ContainsKey(key)) {
            RemoveNode(_cache[key]);
        }
        
        // Create the new node, add to dictionary, and insert at MRU position
        Node newNode = new Node(key, value);
        _cache[key] = newNode;
        InsertToHead(newNode);

        // Enforce capacity limits
        if (_cache.Count > _capacity) {
            // The LRU node is always the one right before the dummy tail
            Node lru = _tail.Prev;
            RemoveNode(lru);
            _cache.Remove(lru.Key);
        }
    }
}
