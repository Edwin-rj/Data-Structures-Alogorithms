using System.Text.RegularExpressions;

public class Solution {
    public bool ValidPalindrome(string s) {

       s = Regex.Replace(s,"[^a-zA-Z0-9]","").ToLower();

       int leftPointer = 0;
       int rightPointer = s.Length -1;
       
        while(leftPointer < rightPointer)
        {
            if(s[leftPointer] != s[rightPointer])
            {   
                return isPalindrome(s,leftPointer+1,rightPointer)||isPalindrome(s,leftPointer,rightPointer-1);
            }

            leftPointer ++;
            rightPointer --;
        }

        return true;
    }

    public bool isPalindrome (string s , int leftPointer , int rightPointer)
    {
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