public class StockSpanner {
    private Stack<(int Price, int Span)> _stack;

    public StockSpanner() {
        _stack = new Stack<(int Price, int Span)>();
    }
    
    public int Next(int price) {
        int span = 1;
        while(_stack.Count > 0 && price >= _stack.Peek().Price){
            span += _stack.Pop().Span;
        }
        _stack.Push((price, span));
        return span;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */
