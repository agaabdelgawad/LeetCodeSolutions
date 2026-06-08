public class NumMatrix {
    private readonly int[][] _prefixSumMat;

    public NumMatrix(int[][] matrix) {
        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) {
            _prefixSumMat = new int[1][] { new int[1] };
            return;
        }

        int rows = matrix.Length + 1;
        int cols = matrix[0].Length + 1;
        _prefixSumMat = new int[rows][];
        _prefixSumMat[0] = new int[cols];

        for(int i = 1; i < rows; i++){
            _prefixSumMat[i] = new int[cols];

            int[] currentRow = _prefixSumMat[i];
            int[] previousRow = _prefixSumMat[i - 1];
            int[] matrixRow = matrix[i - 1];

            for(int j = 1; j < cols; j++){
                currentRow[j] = matrixRow[j - 1]
                                    + previousRow[j]
                                    + currentRow[j - 1]
                                    - previousRow[j - 1];
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        if (_prefixSumMat.Length <= 1) return 0;

        return _prefixSumMat[row2 + 1][col2 + 1]
             - _prefixSumMat[row1][col2 + 1]
             - _prefixSumMat[row2 + 1][col1]
             + _prefixSumMat[row1][col1];
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */
