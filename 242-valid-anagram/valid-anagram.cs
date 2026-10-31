public class Solution {
    public bool IsAnagram(string s, string t) {
      
        if(s.Length != t.Length)
        {
            return false;
        }


        int[] asci = new int[26];


        foreach(var i in s)
        {
           asci[i - 'a']++;
        }


        foreach(var j in t)
        {
            asci[j - 'a']--;


            if( asci[j - 'a'] < 0)
            {
                return false;
            }
        }


        return true;


    }
}