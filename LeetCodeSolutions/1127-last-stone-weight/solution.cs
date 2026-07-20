public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
        foreach(int s in stones) queue.Enqueue(s, -1 * s);

        while(queue.Count > 1){
            int first = queue.Dequeue();
            int second = queue.Dequeue();
            if(first != second) queue.Enqueue(first - second, second - first);
        }

        return queue.Count > 0 ? queue.Dequeue() : 0;
    }
}
