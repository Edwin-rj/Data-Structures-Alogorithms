public class Solution {
    public bool WordPattern(string pattern, string s) {
        
        string[] ss = s.Split(" ");

        if(ss.Length != pattern.Length)
        {
            return false;
        }

        Dictionary<char,int> x = new();
        Dictionary<string,int> y = new();

        StringBuilder xSb =  new ();
        StringBuilder ySb =  new ();

        int xCount = 1;
        int yCount = 1;


        for(int i  = 0 ; i < pattern.Length ; i ++ )
        {
            if(!x.ContainsKey(pattern[i]))
            {
                x[pattern[i]] = xCount++;
            }

            xSb.Append(x[pattern[i]]);

            if(!y.ContainsKey(ss[i]))
            {
                y[ss[i]] = yCount++;
            }

            ySb.Append(y[ss[i]]);
        }

        return xSb.ToString() ==  ySb.ToString();

    }
}