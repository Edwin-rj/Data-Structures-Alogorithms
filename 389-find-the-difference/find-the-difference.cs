public class Solution {
    public char FindTheDifference(string s, string t) {
        
        if(s.Length == 0)
        {
            return t[0];
        }

        int[] freq = new int[26];
        foreach(var c in t)
        {
            freq[c -'a']++;
        }
        
        foreach(var c in s)
        {
            freq[c -'a']--;
        }

        for (int i = 0; i < freq.Length; i++)
        {
            if (freq[i] > 0)
            {
                return (char)(i + 'a');
            }
        }
        return 'a';
    }
}