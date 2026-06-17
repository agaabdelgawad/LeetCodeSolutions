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
    public IList<int> PostorderTraversal(TreeNode root) {
        IList<int> result = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode current = root;
        TreeNode lastVisited = null;

        while(current != null || stack.Count > 0){
            while(current != null){
                stack.Push(current);
                current = current.left;
            }

            TreeNode topNode = stack.Peek();
            if(topNode.right != null && topNode.right != lastVisited){
                current = topNode.right;
            }
            else{
                result.Add(topNode.val);
                lastVisited = stack.Pop();
            }
        }
        
        return result;
    }
}
