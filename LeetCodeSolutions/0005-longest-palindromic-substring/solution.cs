public class Solution {
    public string LongestPalindrome(string s) {
        if(string.IsNullOrEmpty(s) || s.Length < 2) return s;

        int start = 0;
        int longestLength = 1;

        for(int i = 0; i < s.Length; i++){
            int firstLength = GetPalindromeLengthFromCenter(s, i, i);
            int secondLength = GetPalindromeLengthFromCenter(s, i, i + 1);

            int maxLength = Math.Max(firstLength, secondLength);

            if(maxLength > longestLength){
                longestLength = maxLength;
                start = i - (maxLength - 1) / 2;
            }
        }

        return s.Substring(start, longestLength);
    }

    private int GetPalindromeLengthFromCenter(string s, int left, int right){
        while(left >= 0 && right < s.Length && s[left] == s[right]){
            left--;
            right++;
        }
        return right - left - 1;
    }
}
