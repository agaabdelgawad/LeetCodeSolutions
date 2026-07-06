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
        List<int> result = new List<int>();
        if(root == null) return result;

        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);

        while(stack.Count > 0){
            var current = stack.Pop();
            result.Add(current.val);

            if(current.left != null) stack.Push(current.left);
            if(current.right != null) stack.Push(current.right);
        }

        result.Reverse();
        IList<int> finalResult = new List<int>(result);
        return finalResult;
    }
}
