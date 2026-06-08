public class Solution {
    public bool ValidPalindrome(string s) {
        int l = -1; int r = s.Length;

        while(++l < --r){
            if(s[l] != s[r])
            return IsPalindrome(s, l, r + 1) || IsPalindrome(s, l - 1, r);
        }

        return true;
    }

    private bool IsPalindrome(string s, int l, int r){
        while(++l < --r && s[l] == s[r]);
        return l >= r;
    }
}
