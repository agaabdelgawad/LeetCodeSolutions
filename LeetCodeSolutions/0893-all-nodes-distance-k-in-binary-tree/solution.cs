/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    private Dictionary<TreeNode, TreeNode> _parentMap;
    private HashSet<TreeNode> _visitedNodes;
    private IList<int> _result;

    public IList<int> DistanceK(TreeNode root, TreeNode target, int k) {
        _parentMap = new Dictionary<TreeNode, TreeNode>();
        _visitedNodes = new HashSet<TreeNode>();
        _result = new List<int>();

        BuildParentMap(root, null);

        Queue<TreeNode> queue = new Queue<TreeNode>();
        _visitedNodes.Add(target);
        queue.Enqueue(target);

        while(k-- > 0){
            int count = queue.Count;
            while(count-- > 0){
                TreeNode current = queue.Dequeue();
                
                if(current.left != null && !_visitedNodes.Contains(current.left)){
                    _visitedNodes.Add(current.left);
                    queue.Enqueue(current.left);
                }
                if(current.right != null && !_visitedNodes.Contains(current.right)){
                    _visitedNodes.Add(current.right);
                    queue.Enqueue(current.right);
                }
                if(_parentMap.ContainsKey(current)){
                    TreeNode parentNode = _parentMap[current];
                    
                    if(!_visitedNodes.Contains(parentNode)){
                    _visitedNodes.Add(parentNode);
                    queue.Enqueue(parentNode);
                    }
                }
            }
        }

        while(queue.Count > 0){
            _result.Add(queue.Dequeue().val);
        }

        return _result;
    }

    private void BuildParentMap(TreeNode node, TreeNode parent){
        if(node == null) return;

        if(parent != null) _parentMap[node] = parent;

        BuildParentMap(node.left, node);
        BuildParentMap(node.right, node);
    }
}
