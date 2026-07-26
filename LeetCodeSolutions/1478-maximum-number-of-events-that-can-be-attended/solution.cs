public class Solution {
    public int MaxEvents(int[][] events) {
        Array.Sort(events, (x, y) => x[0].CompareTo(y[0]));

        PriorityQueue<int, int> queue = new PriorityQueue<int, int>();

        int maxEvents = 0;
        int day = 0;
        int i = 0;
        int n = events.Length;

        while(i < n || queue.Count > 0){
            if(queue.Count == 0 && day < events[i][0]){
                day = events[i][0];
            }

            while(i < n && events[i][0] <= day){
                queue.Enqueue(events[i][1], events[i][1]);
                i++;
            }
            
            while(queue.Count > 0 && queue.Peek() < day){
                queue.Dequeue();
            }

            if(queue.Count > 0){
                queue.Dequeue();
                maxEvents++;
            }

            day++;
        }

        return maxEvents;
    }
}
