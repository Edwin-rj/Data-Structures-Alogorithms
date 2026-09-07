public class Solution {
    public int[] SortedSquares(int[] nums) 
    {
        int left = 0;
        int right = nums.Length - 1;
        int[] result = new int[nums.Length];

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            int leftVal = nums[left] * nums[left];
            int rightVal = nums[right] * nums[right];

            if (leftVal > rightVal)
            {
                result[i] = leftVal;
                left++;
            }
            else
            {
                result[i] = rightVal;
                right--;
            }
        }

        return result;
    }
}