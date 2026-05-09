using System.Runtime.InteropServices;

public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }

        var sDict = new Dictionary<char, int>();
        var tDict = new Dictionary<char, int>();

        for ( int i = 0; i < s.Length; i++){
            ref int sCountValue =
                ref CollectionsMarshal.GetValueRefOrAddDefault(sDict, s[i], out bool sExists);
            sCountValue++;

            ref int tCountValue =
                ref CollectionsMarshal.GetValueRefOrAddDefault(tDict, t[i], out bool tExists);
            tCountValue++;
        }

         if(sDict.Count != tDict.Count){
            return false;
        }

        foreach(var kvp in sDict){
            if(!tDict.TryGetValue(kvp.Key, out int tValue)){
                return false;
            }

            if(kvp.Value != tValue){
                return false;
            }
        }

        return true;
    }
}
