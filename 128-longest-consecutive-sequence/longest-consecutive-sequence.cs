public class Solution {
    public int LongestConsecutive(int[] nums) {

        var length = 0;

        var maxLength = 0;

        if(!nums.Any())
        {
            return 0;
        }

        HashSet<int> x = new ();     

        foreach(var item in nums)
        {
            x.Add(item);
        }

        var currentNum = 0;
        for(int i = 0; i < nums.Length; i ++)
        {
            currentNum = nums[i]; 
            if(!x.Contains(currentNum-1))
            {
                length = 1;

                while(x.Contains(currentNum + 1))
                {
                    currentNum++;
                    length++;
                }

                maxLength = Math.Max(maxLength,length);
            }
            else
            {
                length = 1; 
            }
        }

        return maxLength;
    }
}