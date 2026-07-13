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
    public int GoodNodes(TreeNode root) => CountGoodNodes(root, root.val);

    private int CountGoodNodes(TreeNode node, int maxValInPath) {
        if(node == null) return 0;

        int good = node.val >= maxValInPath ? 1 : 0;
        maxValInPath = Math.Max(node.val, maxValInPath);

        return good + CountGoodNodes(node.left, maxValInPath) + CountGoodNodes(node.right, maxValInPath);
    }
}
