public class Solution {
    public bool IsAnagram(string s, string t) {
      
        if(s.Length != t.Length)
        {
            return false; 
        }

        int[] x = new int [26];
        for(int i =0 ; i < s.Length ; i ++ )
        {
            x[s[i] - 'a']++;
        }
        for(int j =0 ; j < t.Length ; j ++ )
        {
            x[t[j] - 'a']--;
        }

        return !x.Any(y=>y>0);
    }
}