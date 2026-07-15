/*
// Definition for a QuadTree node.
public class Node {
    public bool val;
    public bool isLeaf;
    public Node topLeft;
    public Node topRight;
    public Node bottomLeft;
    public Node bottomRight;

    public Node() {
        val = false;
        isLeaf = false;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val, bool _isLeaf) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val,bool _isLeaf,Node _topLeft,Node _topRight,Node _bottomLeft,Node _bottomRight) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = _topLeft;
        topRight = _topRight;
        bottomLeft = _bottomLeft;
        bottomRight = _bottomRight;
    }
}
*/

public class Solution {
    public Node Construct(int[][] grid) {
        if(grid == null || grid.Length == 0 || grid[0].Length == 0) return null;
        return BuildQuad(grid, 0, 0, grid.Length);
    }

    private Node BuildQuad(int [][] grid, int row, int col, int size) {
        if(size == 1) return new Node(grid[row][col] == 1, true);

        int newSize = size / 2;

        Node topLeft = BuildQuad(grid, row, col, newSize);
        Node topRight = BuildQuad(grid, row, col + newSize, newSize);
        Node bottomLeft = BuildQuad(grid, row + newSize, col, newSize);
        Node bottomRight = BuildQuad(grid, row + newSize, col + newSize, newSize);

        if(topLeft.isLeaf && topRight.isLeaf &&
           bottomLeft.isLeaf && bottomRight.isLeaf &&
           topLeft.val == topRight.val &&
           topRight.val == bottomLeft.val &&
           bottomLeft.val == bottomRight.val) return new Node(topLeft.val, true);

        return new Node(false, false, topLeft, topRight, bottomLeft, bottomRight);
    }
}
