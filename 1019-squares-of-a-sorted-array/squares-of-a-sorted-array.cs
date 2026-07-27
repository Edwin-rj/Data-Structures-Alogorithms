public class Solution {
    public int[] SortedSquares(int[] nums) {
        
        var left  = 0;
        var square = 0;
        var right  = nums.Length-1;
        var rightSquare = 0;
        var position = nums.Length - 1;
        int[] arraySquare = new int[nums.Length];
        
        while(left<=right)
        {   
            square = (nums[left]*nums[left]);
            rightSquare = (nums[right]*nums[right]);

            if(square > rightSquare )
            {
                arraySquare[position] = square;
                left++; 
            }
            else 
            {
                arraySquare[position] = rightSquare;
                right--;
            }
            position--;

        }

        return arraySquare;
    }
}