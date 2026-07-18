public class Solution {
    public int MySqrt(int x) {
        int l = 0;
        int r = x;

        while(l <= r){
            int mid = l + (r - l) / 2;
            long result = (long)mid * mid;
            if(result == x) return mid;
            else if(result < x) l = mid + 1;
            else r = mid - 1;
        }

        return r;
    }
}
