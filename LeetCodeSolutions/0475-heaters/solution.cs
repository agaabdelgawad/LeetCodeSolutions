public class Solution {
    public int FindRadius(int[] houses, int[] heaters) {
        Array.Sort(heaters);
        int minRadius = 0;

        foreach(int house in houses){
            int left = 0;
            int right = heaters.Length - 1;

            while(left <= right){
                int mid = left + (right - left) / 2;

                if(heaters[mid] == house) break;
                else if(heaters[mid] < house) left = mid + 1;
                else right = mid - 1;
            }

            if(left > right){
                int leftDist = right >= 0 ? house - heaters[right] : int.MaxValue;
                int rightDist = left < heaters.Length ? heaters[left] - house : int.MaxValue;

                minRadius = Math.Max(minRadius, Math.Min(leftDist, rightDist));
            }
        }

        return minRadius;
    }
}
