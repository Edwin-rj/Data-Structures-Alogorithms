public class Solution {
    public bool IsIsomorphic(string s, string t) 
    {
      Dictionary <char,int> x = new();
      Dictionary <char,int> y = new();

      for(int i = 0;i<s.Length;i++)
      {
            if(x.ContainsKey(s[i]))
            {
                x[s[i]] = i;

            }else
            {
                x[s[i]] = i;
            }

            if(y.ContainsKey(t[i]))
            {
                y[t[i]] = i;

            }else
            {
                y[t[i]] = i;
            }
        }

        var xVal = string.Join("",x.Values);
        var yVal = string.Join("",y.Values);

        if(xVal == yVal)
        {
          return true;
        }
        return false;
    }
}