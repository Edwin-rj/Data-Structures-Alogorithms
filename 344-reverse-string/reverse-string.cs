public class Solution {
    public void ReverseString(char[] s) {
        
        int length = s.Length-1;
        for (int i = 0; i < s.Length / 2; i++)
        {   
            var temp = s[i];
            s[i] = s[length - i];
            s[length - i] = temp;  
        }
    }
}