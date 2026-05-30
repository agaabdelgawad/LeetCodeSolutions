public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int i = 0;
        int j = people.Length - 1;
        int sum;
        int boats = 0;

        while(i <= j){
            if(i == j){
                boats++;
                break;
            }

            sum = people[i] + people[j];

            if(sum > limit){
                j--;
            }
            else{
                i++;
                j--;
            }
            
            boats++;
        }

        return boats;
    }
}
