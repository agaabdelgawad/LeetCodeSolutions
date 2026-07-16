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
    public int Rob(TreeNode root) {
        if(root == null) return 0;

        (int rob, int skip) = CalculateRob(root);
        
        return Math.Max(rob, skip);
    }

    private (int Rob, int Skip) CalculateRob(TreeNode root){
        if(root == null) return (0, 0);

        (int robLeft, int skipLeft) = CalculateRob(root.left);
        (int robRight,int  skipRight) = CalculateRob(root.right);

        return (root.val + skipLeft + skipRight,
                Math.Max(robLeft, skipLeft) + Math.Max(robRight, skipRight));
    }
}
