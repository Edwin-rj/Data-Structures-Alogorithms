public class Solution {
    public bool ContainsDuplicate(int[] nums) 
    {
        HashSet<int> x = new();
        for(int i = 0;i<nums.Length;i++)
        {
            if(x.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                x.Add(nums[i]);
            }
        }

        return false;
        
    }
}