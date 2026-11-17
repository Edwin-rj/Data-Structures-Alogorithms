public class Solution {
    public char FindTheDifference(string s, string t) {
        
        int[] x =  new int[26];
        for(int i = 0 ; i < t.Length ; i ++ )
        {
            x[t[i] - 'a']++;
        }

        for(int i = 0 ; i < s.Length ; i ++ )
        {
            x[s[i] - 'a']--;
        }

        for(int i = 0 ; i <  x.Length ; i ++ )
        {
            if(x[i] > 0)
            {
                return  (char)(i+'a'); 
            }
        }

        return 'c';
    }
}