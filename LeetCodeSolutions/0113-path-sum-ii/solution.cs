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
    private IList<IList<int>> _result = new List<IList<int>>();

    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        Traverse(root, new List<int>(), targetSum);

        return _result;
    }

    private void Traverse(TreeNode currentNode, List<int> currentPath, int remainingSum){
        if(currentNode == null) return;

        currentPath.Add(currentNode.val);

        if(currentNode.left == null &&
           currentNode.right == null &&
           remainingSum == currentNode.val){
            _result.Add(new List<int>(currentPath));
        }

        Traverse(currentNode.left, currentPath, remainingSum - currentNode.val);
        Traverse(currentNode.right, currentPath, remainingSum - currentNode.val);

        currentPath.RemoveAt(currentPath.Count - 1);
    }
}
