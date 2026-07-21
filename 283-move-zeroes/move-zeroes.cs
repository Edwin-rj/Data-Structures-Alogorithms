public class Solution {
    public void MoveZeroes(int[] nums) {

        int nonZeroIndex=0;
        for(int i = 0;i< nums.Length;i++)
        { 
            if(nums[i]==0)
            {
                continue;
            }

            if(i!=nonZeroIndex)
            {
                nums[nonZeroIndex] = nums[i]; 
                nums[i]= 0;
            }  
            nonZeroIndex ++;
            
        }           
    }
}