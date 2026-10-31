public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int,int> x = new();
         for(int i = 0;i<nums.Length;i++)
        {

            x[nums[i]] = i; 
        }

        for(int i = 0;i<nums.Length;i++)
        {
            var check = target - nums[i];
            if(x.TryGetValue(check, out int y)){
            
                if(y != i){
                return new int[] {i, y};}
            }
        }

        return null;
        
    }
}