using System.Runtime.InteropServices;

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();

        for (int i = 0; i < strs.Length; i++){
            int[] charCounts = new int[26];

            for(int j = 0; j < strs[i].Length; j++){
                charCounts[strs[i][j] - 'a']++;
            }

            string signature = string.Join("-", charCounts);

            ref var ListValue = ref CollectionsMarshal.GetValueRefOrAddDefault(dict, signature, out bool isExisting);

            if(!isExisting){
                ListValue = new List<string>();
            }

            ListValue.Add(strs[i]);
        }

        return dict.Values.ToList();
    }
}
