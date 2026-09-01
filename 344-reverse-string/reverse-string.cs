public class Solution {
    public void ReverseString(char[] s) {
       char tempVal;
       int rightPointer = s.Length-1;
       for(int leftPointer = 0 ; leftPointer < s.Length/2 ; leftPointer++) 
       {
            tempVal = s[leftPointer];
            s[leftPointer] = s[rightPointer];
            s[rightPointer] =  tempVal;

            rightPointer --;
       }
    }
}