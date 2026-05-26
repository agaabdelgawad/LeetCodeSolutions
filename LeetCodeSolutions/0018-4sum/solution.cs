public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        Array.Sort(nums);

        IList<IList<int>> result = new List<IList<int>>();

        int i; int j; int k;
        long sum;

        for(int l = 0; l < nums.Length - 3; l++){
            if(l != 0 && nums[l] == nums[l - 1]){
                continue;
            }

            for(k = l + 1; k < nums.Length - 2; k++){
                if(k != (l + 1) && nums[k] == nums[k - 1]){
                    continue;
                }

                i = k + 1; 
                j = nums.Length - 1;

                while(i < j){
                    sum = (long)nums[l] + nums[k] + nums[i] + nums[j];

                    if(sum < target){
                        i++;
                    }
                    else if(sum > target){
                        j--;
                    }
                    else{
                        result.Add(new List<int>{nums[l], nums[k], nums[i], nums[j]});

                        i++;
                        j--;

                        while(i < j && nums[i] == nums[i - 1]){
                            i++;
                        }

                        while(i < j && nums[j] == nums[j + 1]){
                            j--;
                        }
                    }
                }
            }
        }

        return result;
    }
}
