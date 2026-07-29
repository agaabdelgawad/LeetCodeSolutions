public class Solution {
    public int Reverse(int x) {
        int reversed = 0;

        while(x != 0){
            int remaining = x % 10;
            x /= 10;

            if(reversed > int.MaxValue / 10 ||
               (reversed == int.MaxValue / 10 && remaining > int.MaxValue % 10))
               return 0;

            if(reversed < int.MinValue / 10 ||
               (reversed == int.MinValue / 10 && remaining < int.MinValue % 10))
               return 0;

            reversed = reversed * 10 + remaining;
        }

        return reversed;
    }
}
