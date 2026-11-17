public class Solution {
    public int FirstUniqChar(string s) {

        Dictionary <char,int> x = new ();

        foreach(var item in s )
        {
            x[item] = x.GetValueOrDefault(item) + 1 ; 
        }

        for(int i = 0 ;i < s.Length ; i++)
        {
            if(x[s[i]] == 1)
            {
                return i;
            }
        }
        return -1; 

    }
}