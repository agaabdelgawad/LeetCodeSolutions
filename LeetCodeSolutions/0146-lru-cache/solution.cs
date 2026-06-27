public class Node {
    public int Key { get; set; }
    public int Value { get; set; }
    public Node Previous { get; set; }
    public Node Next { get; set; }

    public Node(int key, int value) {
        Key = key;
        Value = value;
        Previous = null;
        Next = null;
    }
}

public class LRUCache {
    private Dictionary<int, Node> _cache;
    private Node _head;
    private Node _tail;
    private int _capacity;

    public LRUCache(int capacity) {
        _cache = new Dictionary<int, Node>();
        _capacity = capacity;
    }
    
    public int Get(int key) {
        if (!_cache.ContainsKey(key)) return -1;

        Node current = _cache[key];
        int value = current.Value;
        
        if(current != _tail){
            if (current == _head) {
                _head = _head.Next;
                if (_head != null) _head.Previous = null;
            } else {
                current.Previous.Next = current.Next;
                if (current.Next != null) current.Next.Previous = current.Previous;
            }

            _tail.Next = current;
            current.Previous = _tail;
            _tail = current;
            _tail.Next = null;
        }

        return value;
    }
    
    public void Put(int key, int value) {
        if (_cache.ContainsKey(key)) {
            _cache[key].Value = value;
            Get(key); 
            return;
        }

        if(_cache.Count == 0){
            _cache[key] = new Node(key, value);
            _head = _cache[key];
            _tail = _cache[key];
            return;
        }

        if(_cache.Count == _capacity){
            _cache.Remove(_head.Key);
            Node temp = _head.Next;

            if (temp == null) {
                _head = null;
                _tail = null;
            } else {
                _head.Next = null;
                _head = temp;
                _head.Previous = null;
            }
        }

        _cache[key] = new Node(key, value);
        Node current = _cache[key];

        if (_tail == null) {
            _head = current;
            _tail = current;
        } else {
            _tail.Next = current;
            current.Previous = _tail;
            current.Next = null;
            _tail = current;
        }
    }
}

