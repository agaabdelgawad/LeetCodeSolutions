public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int left = 0;
        int right = m * n - 1;

        while(left <= right){
            int mid = left + (right - left) / 2;
            int row = mid / n;
            int col = mid % n;

            if(target < matrix[row][col]) right = mid - 1;
            else if(target > matrix[row][col]) left = mid + 1;
            else return true;
        }

        return false;
    }
}
