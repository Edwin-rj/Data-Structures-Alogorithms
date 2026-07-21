public class Solution {
    public int RemoveElement(int[] nums, int val) {

    var NonValItems = 0;
    for(int i = 0; i < nums.Length;i++)
    {
        if(nums[i] == val)
        {
            continue;
        }       

        if(i!=NonValItems)
        {
            nums[NonValItems] = nums[i];
            nums[i] = val;    
        }

        NonValItems++;
    }

    return NonValItems;

    }
}