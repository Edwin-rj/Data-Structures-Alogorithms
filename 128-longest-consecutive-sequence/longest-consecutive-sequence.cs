public class Solution {
    public int LongestConsecutive(int[] nums) {

     var length = 0;

     var maxLength = 0;

     if(!nums.Any())
     {
        return 0;
     }

     nums = nums.OrderBy(x=>x).ToArray();

    for(int i = 0; i < nums.Length-1 ; i ++)
    {
        if(nums[i] == nums[i+1])
        {
            continue;
        }

        if((nums[i]+1) == nums[i+1])
        {
            length++;
        }
        else
        {
            maxLength = Math.Max(maxLength,length);
            length = 0;
        }
    }

    
    maxLength = Math.Max(maxLength,length);

    if(maxLength == 0)
    {
        return 1;
    } 
    else
    {
        return maxLength + 1; 
    }

    }
}