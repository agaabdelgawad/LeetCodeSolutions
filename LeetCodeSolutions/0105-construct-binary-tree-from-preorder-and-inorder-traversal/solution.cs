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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if(preorder.Length == 0 && inorder.Length == 0) return null;

        int preIndex = 0;
        int inIndex = 0;
        
        return ConstructTree(preorder, inorder, int.MaxValue);

        TreeNode ConstructTree(int[] preorder, int[] inorder, int limit) {
            if(preIndex >= preorder.Length) return null;
            if(inorder[inIndex] == limit){
                inIndex++;
                return null;
            }

            TreeNode root = new TreeNode(preorder[preIndex++]);
            root.left = ConstructTree(preorder, inorder, root.val);
            root.right = ConstructTree(preorder, inorder, limit);

            return root;
        }
    }
}
