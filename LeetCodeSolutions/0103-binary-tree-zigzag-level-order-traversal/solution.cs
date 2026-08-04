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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        if(root != null) queue.Enqueue(root);
        bool leftToRight = true;

        while(queue.Count > 0){
            int count = queue.Count;
            int[] level = new int[count];

            for(int i = 0; i < count; i++){
                TreeNode current = queue.Dequeue();
                int insertIndex = leftToRight ? i : (count - 1 - i);
                level[insertIndex] = current.val;

                if(current.left != null) queue.Enqueue(current.left);
                if(current.right != null) queue.Enqueue(current.right);
            }

            result.Add(level);
            leftToRight = !leftToRight;
        }

        return result;
    }
}
