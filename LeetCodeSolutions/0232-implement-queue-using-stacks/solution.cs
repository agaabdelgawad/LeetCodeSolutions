public class MyQueue {
    private Stack<int> _pushingStack;
    private Stack<int> _pullingStack;

    public MyQueue() {
        _pushingStack = new Stack<int>();
        _pullingStack = new Stack<int>();
    }
    
    public void Push(int x) {
        _pushingStack.Push(x);
    }
    
    public int Pop() {
        if(_pullingStack.Count == 0){
            while(_pushingStack.Count > 0) _pullingStack.Push(_pushingStack.Pop());
        }
        return _pullingStack.Pop();
    }
    
    public int Peek() {
        if(_pullingStack.Count == 0){
            while(_pushingStack.Count > 0) _pullingStack.Push(_pushingStack.Pop());
        }
        return _pullingStack.Peek();
    }
    
    public bool Empty() {
        return _pushingStack.Count == 0 && _pullingStack.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
