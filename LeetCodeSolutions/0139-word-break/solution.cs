public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        bool[] match = new bool[s.Length + 1];
        match[0] = true;

        for(int i = 0; i < s.Length; i++){
            if(!match[i]) continue;

            foreach(string word in wordDict){
                int nextIndex = i + word.Length;
                if(nextIndex <= s.Length && s.Substring(i, nextIndex - i) == word){
                    match[nextIndex] = true;
                }
            }
        }

        return match[s.Length];
    }
}
