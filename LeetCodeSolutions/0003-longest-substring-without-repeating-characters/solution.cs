using System.Runtime.InteropServices;

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s == null || s.Length == 0) return 0;

        Dictionary<char, int> charsIndicesDict = new Dictionary<char, int>();
        int i = 0; int longestStreak = 0;

        for(int j = 0; j < s.Length; j++){
            ref int charIndex = ref CollectionsMarshal.GetValueRefOrAddDefault(charsIndicesDict, s[j], out bool exists);
            if(exists) i = Math.Max(i, charIndex + 1);
            charIndex = j;
            longestStreak = Math.Max(longestStreak, j - i + 1);
        }

        return longestStreak;
    }
}
