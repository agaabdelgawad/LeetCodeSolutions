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
    public int KthSmallest(TreeNode root, int k){
        return GetKthSmallest(root);

        int GetKthSmallest(TreeNode root){
            if(root == null) return -1;

            int leftValue = GetKthSmallest(root.left);
            if(k == 0) return leftValue;
            if(--k == 0) return root.val;
            return GetKthSmallest(root.right);
        }
    }
}
