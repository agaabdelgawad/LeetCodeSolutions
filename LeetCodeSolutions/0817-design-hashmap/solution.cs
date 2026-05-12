public class MyHashMap {
    private bool[] keys;
    private int[] values;

    public MyHashMap() {
        keys = new bool[1000001];
        values = new int[1000001];
    }
    
    public void Put(int key, int value) {
        keys[key] = true;
        values[key] = value;
    }
    
    public int Get(int key) {
        if (keys[key]){
            return values[key];
        }

        return -1;
    }
    
    public void Remove(int key) {
        keys[key] = false;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */
