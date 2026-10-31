public class Solution {
    public int FirstUniqChar(string s) {

        Dictionary <int,int> x = new();
        
        for(int i =0; i < s.Length; i++ )
        {
            if(x.TryGetValue(s[i],out var y))
            {
                x[s[i]] = y + 1;
            }
            else
            {
                x[s[i]] = 1;
            } 
        }

        int key = 0;
        foreach(var i in x)
        {
            if(i.Value == 1)
            {
                key =  i.Key;
                break;
            } 
        }

        for(int i =0; i < s.Length; i++ )
        {
            if(s[i]==key)
            {
                return i;
            }
        }
        return -1;
    }
}