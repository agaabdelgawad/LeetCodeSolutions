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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        if(root != null) queue.Enqueue(root);

        while(queue.Count > 0){
            IList<int> level = new List<int>();

            int count = queue.Count;
            while(count-- > 0){
                TreeNode current = queue.Dequeue();
                level.Add(current.val);
                if(current.left != null) queue.Enqueue(current.left);
                if(current.right != null) queue.Enqueue(current.right);
            }

            result.Add(level);
        }

        return result;
    }
}
