public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        int nextAvailablePlace=1;
        for(int i = 0 ;i < nums.Length ; i++)
        {   if(i==0)
            {
                continue;
            }

            if(nums[i]==nums[i-1]){
            }
            else
            {
                nums[nextAvailablePlace] = nums[i];
                nextAvailablePlace++;
            }
        }
        return nextAvailablePlace;
    }
}