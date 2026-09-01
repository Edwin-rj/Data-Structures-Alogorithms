public class Solution {
    public void ReverseString(char[] s) {
       char tempVal;
       int rightPointer = s.Length-1;
       int leftPointer = 0;


       while(leftPointer < rightPointer)
       {
            tempVal = s[leftPointer];
            s[leftPointer] = s[rightPointer];
            s[rightPointer] =  tempVal;

            leftPointer ++;
            rightPointer --;
       }
    }
}