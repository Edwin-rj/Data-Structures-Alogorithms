public class Solution {
    public bool WordPattern(string pattern, string s) {
        
        Dictionary <string,int> x = new ();
        Dictionary <char,int>  y = new();

        string[] z = s.Split(' ');

        if(z.Length != pattern.Length)
        {
            return false;
        }


         for (int i = 0; i < pattern.Length; i++)
        {
            x.TryGetValue(z[i], out int h);       // 0 if not seen
            y.TryGetValue(pattern[i], out int j); // 0 if not seen

            if (h != j)
                return false;

            x[z[i]] = i + 1;
            y[pattern[i]] = i + 1;
        }


        return true;
    }
}