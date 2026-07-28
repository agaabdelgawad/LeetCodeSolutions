public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int maxPile = 0;
        foreach(int pile in piles){
            if(pile > maxPile) maxPile = pile;
        }

        int left = 1;
        int right = maxPile;

        while(left < right){
            int mid = left + (right - left) / 2;
            long hours = 0;

            foreach(int pile in piles){
                hours += (pile + mid - 1) / mid;
            }

            if(hours > h) left = mid + 1;
            else right = mid;
        }

        return left;
    }
}

