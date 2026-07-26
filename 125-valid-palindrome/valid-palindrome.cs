using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        
        s =Regex.Replace(s,@"[^\p{L}\p{Nd}]","").ToLower();

        int left = 0;
        int right = s.Length - 1;
        bool isPalindrome = true;
        while(left < right)
        {
            if(s[left] != s[right])
            {
                isPalindrome = false;
            }
            left++;
            right--;
        }

        return isPalindrome;
    }
}