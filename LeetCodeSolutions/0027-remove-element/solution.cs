public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var numsList = new List<int>(nums);

        numsList.RemoveAll(ele => ele == val);

        for(int i = 0; i < numsList.Count; i++){
            nums[i] = numsList[i];
        }

        return numsList.Count;
    }
}
