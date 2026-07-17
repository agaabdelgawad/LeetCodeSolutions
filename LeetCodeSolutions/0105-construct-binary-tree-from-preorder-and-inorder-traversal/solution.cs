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
        Dictionary<int, int> indices = new Dictionary<int, int>();
        for(int i = 0; i < inorder.Length; i++) indices[inorder[i]] = i;

        return ConstructTree(preorder, 0, inorder.Length - 1);

        TreeNode ConstructTree(int[] preorder, int l, int r) {
            if(l > r) return null;

            TreeNode root = new TreeNode(preorder[preIndex++]);
            int middle = indices[root.val];

            root.left = ConstructTree(preorder, l, middle - 1);
            root.right = ConstructTree(preorder, middle + 1, r);

            return root;
        }
    }
}
