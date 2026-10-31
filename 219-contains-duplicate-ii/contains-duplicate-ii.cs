public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        
        Dictionary <int,int> x = new ();

        for(int i = 0 ; i < nums.Length ; i++)
        {
            if(x.TryGetValue(nums[i],out int y))
            {
                if((i-y) <= k )
                {
                    return true;
                }
                x[nums[i]] = i;

            }
            else
            {
                x[nums[i]] = i;
            }
        }
        return false;
    }

}