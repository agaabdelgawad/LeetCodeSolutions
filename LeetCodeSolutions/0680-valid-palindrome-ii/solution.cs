public class Solution {
    public bool ValidPalindrome(string s) {
        bool IsPalindrome(int left, int right){
         while (left < right){
            if (s[left] != s[right]){
                return false;
            }

            left++;
            right--;
         }

         return true;
        }

        int i = 0;
        int j = s.Length - 1;

        while (i < j){
            if (s[i] != s[j]){
                return (IsPalindrome(i + 1, j) || IsPalindrome(i, j - 1));
            }

            i++;
            j--;
        }

        return true;
    }
}
