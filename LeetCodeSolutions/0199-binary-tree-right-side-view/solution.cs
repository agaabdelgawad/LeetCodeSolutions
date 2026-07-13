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
    public IList<int> RightSideView(TreeNode root) {
        IList<int> result = new List<int>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        if(root != null) queue.Enqueue(root);

        while(queue.Count > 0){
            TreeNode current = null;
            int count = queue.Count;
            while(count-- > 0){
                current = queue.Dequeue();
                if(current.left != null) queue.Enqueue(current.left);
                if(current.right != null) queue.Enqueue(current.right);
            }

            result.Add(current.val);
        }

        return result;
    }
}
