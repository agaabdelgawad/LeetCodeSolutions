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
    public int DiameterOfBinaryTree(TreeNode root) {
        int diameter = 0;
        CalculateDepthAndDiameter(root, ref diameter);
        return diameter;
    }

    private int CalculateDepthAndDiameter(TreeNode root, ref int diameter){
        if(root == null) return 0;
        int leftDepth = CalculateDepthAndDiameter(root.left, ref diameter);
        int rightDepth = CalculateDepthAndDiameter(root.right, ref diameter);
        diameter = Math.Max(diameter, leftDepth + rightDepth);
        return 1 + Math.Max(leftDepth, rightDepth);
    }
}
