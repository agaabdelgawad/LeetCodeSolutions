/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    private Dictionary<int, List<int>> _graph = new Dictionary<int, List<int>>();

    public int AmountOfTime(TreeNode root, int start) {
        BuildGraph(root, 0);

        Queue<int> queue = new Queue<int>();
        HashSet<int> visited = new HashSet<int>();

        queue.Enqueue(start);
        visited.Add(start);

        int minutes = -1;

        while(queue.Count > 0){
            int levelSize = queue.Count;

            for(int i = 0; i < levelSize; i++){
                int current = queue.Dequeue();

                foreach(int neighbour in _graph[current]){
                    if(!visited.Contains(neighbour)){
                        queue.Enqueue(neighbour);
                        visited.Add(neighbour);
                    }
                }
            }

            minutes++;
        }

        return minutes;
    }

    private void BuildGraph(TreeNode currentNode, int parentValue){
        if(currentNode == null) return;

        if(!_graph.ContainsKey(currentNode.val)){
            _graph[currentNode.val] = new List<int>();
        }

        if(parentValue != 0){
            _graph[currentNode.val].Add(parentValue);
            _graph[parentValue].Add(currentNode.val);
        }

        BuildGraph(currentNode.left, currentNode.val);
        BuildGraph(currentNode.right, currentNode.val);
    }
}
