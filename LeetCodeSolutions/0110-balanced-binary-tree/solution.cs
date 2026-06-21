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
    public bool IsBalanced(TreeNode root) {
        return CalculateDepthIfBalanced(root) != -1;
    }

    private int CalculateDepthIfBalanced(TreeNode root) {
        if(root == null) return 0;

        int leftDepth = CalculateDepthIfBalanced(root.left);
        if(leftDepth == -1) return -1;

        int rightDepth = CalculateDepthIfBalanced(root.right);
        if(rightDepth == -1) return -1;

        if(Math.Abs(leftDepth - rightDepth) > 1) return -1;

        return 1 + Math.Max(leftDepth, rightDepth);
    }
}
