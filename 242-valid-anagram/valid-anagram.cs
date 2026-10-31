public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] freq = new int[26];

        foreach (char i in s)
        {
           freq[i - 'a']++;     
        }

        foreach (char j in t)
        {
           freq[j - 'a']--;     
        }

        foreach(var k in freq)
        {
            if(k != 0)
            {
               return false;     
            }
        }

        return true;

    }

}