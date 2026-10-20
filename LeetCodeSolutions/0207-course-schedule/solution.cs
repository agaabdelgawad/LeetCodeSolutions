public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        int n = numCourses;

        List<int>[] graph = new List<int>[n];
        for(int i = 0; i < n; i++) graph[i] = new List<int>();

        int[] locks = new int[n];

        for(int i = 0; i < prerequisites.Length; i++){
            int currentCourse = prerequisites[i][0];
            int prerequisite = prerequisites[i][1];

            graph[prerequisite].Add(currentCourse);
            locks[currentCourse]++;
        }

        Queue<int> queue = new Queue<int>();

        for(int i = 0; i < n; i++) if(locks[i] == 0) queue.Enqueue(i);

        int coursesFinished = 0;

        while(queue.Count > 0){
            int currentCourse = queue.Dequeue();

            foreach(int dependentCourse in graph[currentCourse]){
                locks[dependentCourse]--;
                if(locks[dependentCourse] == 0) queue.Enqueue(dependentCourse);
            }

            coursesFinished++;
        }

        return coursesFinished == numCourses;
    }
}
