public class Solution {
    public bool IsIsomorphic(string s, string t) 
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> x = new();
        Dictionary<char, int> y = new();

        StringBuilder xPattern = new();
        StringBuilder yPattern = new();

        int xCount = 1;
        int yCount = 1;

        for (int i = 0; i < s.Length; i++)
        {
            if (!x.ContainsKey(s[i]))
            {
                x[s[i]] = xCount++;
            }

xPattern.Append(x[s[i]]).Append(',');

            if (!y.ContainsKey(t[i]))
            {
                y[t[i]] = yCount++;
            }

yPattern.Append(y[t[i]]).Append(',');
        }

        return xPattern.ToString() == yPattern.ToString();
    }
}