public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        

        //numbers = [-50, -30, -10, -3, 0, 4, 8, 15, 22, 31, 45, 60, 75, 90]
        //target = 37

        int left  = 0;
        int right = numbers.Length - 1;
        int total = 0; 
        while(left <  right)
        {
            total = numbers[left] + numbers[right];
        
            if(total < target)
            {
                left++;
            }
            else if(total > target)
            {
                right--;
            }
            else
            {
                return new int[] {left +1 ,right+1};
            }
        }

        return null;
    }
}