public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = m;
        int j = 0;

        while (i < m + n && j < n){
            nums1[i] = nums2[j];

            i++;
            j++;
        }

        Array.Sort(nums1);
    }
}
