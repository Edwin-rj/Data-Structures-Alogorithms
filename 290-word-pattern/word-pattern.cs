public class Solution {
    public bool WordPattern(string pattern, string s) {
        
        Dictionary <string,int> x = new ();
        Dictionary <char,int>  y = new();

        string[] z = s.Split(' ');

        if(z.Length != pattern.Length)
        {
            return false;
        }


        for(int i =0 ;i < pattern.Length ; i++)
        {
            if(x.ContainsKey(z[i]))
            {
                x[z[i]] = i;
            }else
            {
                x[z[i]] = i;
            }

            if(y.ContainsKey(pattern[i]))
            {
                y[pattern[i]] = i;
            }else
            {
                y[pattern[i]] = i;
            }
        } 

        var xVal = String.Join("",x.Values);
        var yVal = String.Join("",y.Values);


        if(xVal == yVal)
        {
            return true;
        }

        return false;
    }
}