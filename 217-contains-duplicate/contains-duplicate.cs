public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int,int> hi = new();
        for (int i = 0 ; i < nums.Length; i++)
        {
           
           if(hi.ContainsKey(nums[i]))
           {
             return true;
           }
           
           hi[nums[i]] = i;
        }
        return false ;
    }
}