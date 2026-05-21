public class NumMatrix {
    int[][] _preSumMatrix;

    public NumMatrix(int[][] matrix) {
        _preSumMatrix = new int[matrix.Length][];

        for(int i = 0; i < matrix.Length; i++){
            _preSumMatrix[i] = new int[matrix[i].Length];
        }

        int above; int left; int topLeft;

        for(int i = 0; i < _preSumMatrix.Length; i++){
            for(int j = 0; j < _preSumMatrix[i].Length; j++){
                above = i > 0 ? _preSumMatrix[i - 1][j] : 0;
                left = j > 0 ? _preSumMatrix[i][j - 1] : 0;
                topLeft = (i > 0 && j > 0) ? _preSumMatrix[i - 1][j - 1] : 0;

                _preSumMatrix[i][j] = matrix[i][j] + above + left - topLeft;
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        int above = row1 > 0 ? _preSumMatrix[row1 - 1][col2] : 0;
        int left = col1 > 0 ? _preSumMatrix[row2][col1 - 1] : 0;
        int topLeft = (row1 > 0 && col1 > 0) ? _preSumMatrix[row1 - 1][col1 - 1] : 0;

        return _preSumMatrix[row2][col2] - above - left + topLeft;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */
