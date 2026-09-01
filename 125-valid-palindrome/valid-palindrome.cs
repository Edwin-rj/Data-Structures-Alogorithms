using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        
       s = Regex.Replace(s,"[^a-zA-Z0-9]","").ToLower();

        int leftPointer = 0;
        int rightPointer = s.Length-1;

        while(leftPointer < rightPointer)
        {
            if(s[leftPointer] != s[rightPointer])
            {
                return false;
            }

            leftPointer ++;
            rightPointer --;
        }

        return true; 
    }
}