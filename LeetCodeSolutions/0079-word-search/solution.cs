public class Solution {
    public bool Exist(char[][] board, string word) {
        for(int i = 0; i < board.Length; i++){
            for(int j = 0; j < board[i].Length; j++){
                if(board[i][j] == word[0] &&
                   SearchWord(board, i, j, word, 0)) return true;
            }
        }

        return false;
    }

    private bool SearchWord(char[][] board, int row, int col, string word, int index){
        if(index == word.Length) return true;

        if(row < 0 || row >= board.Length ||
           col < 0 || col >= board[row].Length ||
           board[row][col] != word[index]) return false;
        
        char temp = board[row][col];
        board[row][col] = '#';

        bool found = SearchWord(board, row + 1, col, word, index + 1) ||
                     SearchWord(board, row - 1, col, word, index + 1) ||
                     SearchWord(board, row, col + 1, word, index + 1) ||
                     SearchWord(board, row, col - 1, word, index + 1);
        
        board[row][col] = temp;

        return found;
    }
}
