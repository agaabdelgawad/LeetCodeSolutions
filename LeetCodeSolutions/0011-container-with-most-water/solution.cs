public class Solution {
    public int MaxArea(int[] height) {
        int i = 0; int j = height.Length - 1;
        int area = 0;

        while (i < j){
            area = Math.Max(area, Math.Min(height[i], height[j]) * (j - i));

            if(height[i] <= height[j]) i++;
            else j--;
        }

        return area;
    }
}
