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
        CalculateDepthAndUpdateDiameter(root);
        return diameter;

        int CalculateDepthAndUpdateDiameter(TreeNode root){
            if(root == null) return 0;

            int leftDepth = CalculateDepthAndUpdateDiameter(root.left);
            int rightDepth = CalculateDepthAndUpdateDiameter(root.right);
            diameter = Math.Max(diameter, leftDepth + rightDepth);
            return 1 + Math.Max(leftDepth, rightDepth);
        }
    }
}
