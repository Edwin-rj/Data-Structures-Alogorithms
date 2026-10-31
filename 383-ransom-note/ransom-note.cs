public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        
        int[] freq = new int[26];

        foreach(char i in ransomNote)
        {
          freq[i - 'a']++;
        }


        foreach(char j in magazine)
        {
          freq[j - 'a']--;
        }

        foreach(var k in freq)
        {
            if(k>0)
            {
                return false;
            }
        }
        return true;
    }
}