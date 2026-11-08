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
            
                x[z[i]] = i;
                y[pattern[i]] = i;
        } 

        var xVal = String.Join("",x.Values);
        var yVal = String.Join("",y.Values);

        return xVal == yVal;
    }
}