public class Solution {
    public bool IsValidSudoku(char[][] board) {
        bool[,] rows = new bool[9,9];
        bool[,] cols = new bool[9,9];
        bool[,] squares = new bool[9,9];
        
        int num;
        int s;

        for (int r = 0; r < 9; r++){
            for (int c = 0; c < 9; c++){
                if(board[r][c] == '.'){
                    continue;
                }

                num = board[r][c] - '1';

                s = (r / 3) * 3 + (c / 3);

                if(rows[r,num] || cols[c,num] || squares[s,num]){
                    return false;
                }

                rows[r,num] = true;
                cols[c,num] = true;
                squares[s,num] = true;
            }
        }

        return true;
    }
}
