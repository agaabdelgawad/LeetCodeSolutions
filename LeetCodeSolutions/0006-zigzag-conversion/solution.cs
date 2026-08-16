public class Solution {
    public string Convert(string s, int numRows) {
        if(numRows == 1 || numRows >= s.Length) return s;

        StringBuilder[] stringRows = new StringBuilder[numRows];
        for(int k = 0; k < numRows; k++){
            stringRows[k] = new StringBuilder();
        }

        int row = 0;
        int i = 0;

        while(i < s.Length){
            while(row < numRows && i < s.Length){
                stringRows[row++].Append(s[i++]);
            }
            row -= 2;

            while(row >= 0 && i < s.Length){
                stringRows[row--].Append(s[i++]);
            }
            row += 2 ;
        }

        StringBuilder result = new StringBuilder();
        for(int j = 0; j < numRows; j++){
            result.Append(stringRows[j]);
        }

        return result.ToString();
    }
}
