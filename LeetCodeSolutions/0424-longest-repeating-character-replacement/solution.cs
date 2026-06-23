public class Solution {
    public int CharacterReplacement(string s, int k) {
        int longestStreak = 1;
        int[] sCounts = new int[26];
        int maxFrequence = 0;
        int i = 0;

        for(int j = 0; j < s.Length; j++){
            sCounts[s[j] - 'A']++;
            maxFrequence = Math.Max(maxFrequence, sCounts[s[j] - 'A']);

            while((j - i + 1) - maxFrequence > k){
                sCounts[s[i] - 'A']--;
                i++;
            }

            longestStreak = Math.Max(longestStreak, j - i + 1);
        }

        return longestStreak;
    }
}
