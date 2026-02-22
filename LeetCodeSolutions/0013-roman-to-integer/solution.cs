public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> map = new Dictionary<char,int>(){
            {'I',1}, {'V',5}, {'X',10}, {'L',50}, {'C',100}, {'D',500}, {'M',1000}
        };
        
        int output = 0;
        int n = s.Length;

        for(int i = 0; i < n; i++){
            int current = map[s[i]];

            if(i+1 < n && current<map[s[i+1]])
            output-=current;
            else
            output+=current;
        }

        return output;
    }
}
