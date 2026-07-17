public class Solution {
    public int CharacterReplacement(string s, int k) {
        int longestStreak = 1;
        int[] counts = new int[26];
        int maxFrequence = 0;
        int l = 0;

        for(int r = 0; r < s.Length; r++){
            counts[s[r] - 'A']++;

            maxFrequence = Math.Max(maxFrequence, counts[s[r] - 'A']);

            if((r - l + 1) - maxFrequence > k){
                counts[s[l] - 'A']--;
                l++;
            }

            longestStreak = Math.Max(longestStreak, r - l + 1);
        }

        return longestStreak;
    }
}
