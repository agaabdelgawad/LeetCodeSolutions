public class Solution {
    public int MajorityElement(int[] nums) {
        var elementsDict = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            elementsDict[nums[i]] = elementsDict.GetValueOrDefault(nums[i]) + 1;

            if(elementsDict[nums[i]] > nums.Length / 2){
                return nums[i];
            }
        }

        return 0;
    }
}
