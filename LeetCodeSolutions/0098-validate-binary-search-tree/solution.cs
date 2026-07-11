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
    public bool IsValidBST(TreeNode root){
        if(root == null) return true;
        return IsValid(root, long.MinValue, long.MaxValue);
    }

    private bool IsValid(TreeNode root, long minVal, long maxVal){
        if(root == null) return true;
        if(root.val <= minVal || root.val >= maxVal) return false;

        return IsValid(root.left, minVal, root.val) &&
               IsValid(root.right, root.val, maxVal);
    }
}
