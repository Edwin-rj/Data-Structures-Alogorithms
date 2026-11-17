public class Solution {
    public bool IsIsomorphic(string s, string t) 
    {

        if(s.Length != t.Length)
        {
            return false;
        }
        Dictionary <char,int> x = new();
        Dictionary <char,int> y = new();

        for(int i = 0; i < s.Length; i++)
        {
            x[s[i]] = i;
            y[t[i]] = i;
        }

        var xVal = String.Join("",x.Values);
        var yVal = String.Join("",y.Values);

        return xVal == yVal;
    }
}