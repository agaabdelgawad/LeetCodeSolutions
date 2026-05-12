public class MyHashSet {

    private List<int> container;

    public MyHashSet() {
        container = new List<int>();
    }
    
    public void Add(int key) {
        if (!this.Contains(key)){
            container.Add(key);
        }
    }
    
    public void Remove(int key) {
        container.Remove(key);
    }
    
    public bool Contains(int key) {
        return container.Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
