/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        TreeNode current = root;

        while(current != null){
            if(p.val < current.val && q.val < current.val) current = current.left;
            else if(p.val > current.val && q.val > current.val) current = current.right;
            else return current;
        }

        return null;
    }
}
