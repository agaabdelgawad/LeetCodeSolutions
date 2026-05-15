public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int i = 0;
        StringBuilder result = new StringBuilder(word1.Length + word2.Length);

        while (i < word1.Length && i < word2.Length){
            result.Append(word1[i]).Append(word2[i]);
            i++;
        }
        
        result.Append(word1.AsSpan(i)).Append(word2.AsSpan(i));

        return result.ToString();
    }
}
