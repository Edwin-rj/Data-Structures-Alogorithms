public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

    int leftPointer = 0 ;
    int rightPointer = numbers.Length -1;
    int value;

    while(leftPointer <  rightPointer)
    {
     
        value = (numbers[leftPointer] + numbers[rightPointer]);


        if(value  >  target)
        {
            rightPointer --;
        }
        else if(value  <  target)
        {
            leftPointer ++;             
        }
        else
        {
            return new int[] {leftPointer+1 , rightPointer+1};
        }
    
    }

    return null;
    }
}