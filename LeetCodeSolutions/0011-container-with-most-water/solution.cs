public class Solution {
    public int MaxArea(int[] height) {
        int area = 0;
        int i = 0;
        int j = height.Length - 1;

        while(i <  j){
            area = Math.Max(area, Math.Min(height[i], height[j]) * (j - i));

            if(height[i] <= height[j]){
                i++;
            }
            else{
                j--;
            }
        }

        return area;
    }
}
