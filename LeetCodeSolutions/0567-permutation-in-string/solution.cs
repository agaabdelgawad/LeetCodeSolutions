public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int n1 = s1.Length;
        int n2 = s2.Length;
        if(n1 > n2) return false;

        int[] s1Counts = new int[26];
        int[] s2Counts = new int[26];
        for(int i = 0; i < n1; i++){
            s1Counts[s1[i] - 'a']++;
            s2Counts[s2[i] - 'a']++;
        }

        if(Matches(s1Counts, s2Counts)) return true;

        for(int j = n1; j < n2; j++){
            s2Counts[s2[j] - 'a']++;
            s2Counts[s2[j - n1] - 'a']--;

            if(Matches(s1Counts, s2Counts)) return true;
        }

        return false;
    }

    private bool Matches(int[] s1Counts, int[] s2Counts){
        for(int i = 0; i < s1Counts.Length; i++)
            if(s1Counts[i] != s2Counts[i]) return false;
        return true;
    }
}
