public class Solution {
    public IList<int> FindAnagrams(string s, string p) {

        List<int> result = new();


        if(s.Length < p.Length)
        {
            return result;
        }

        int[] x = new int[26];
        int[] y = new int[26];  

        for(int i =0;i < p.Length;i++)
        {
            x[s[i] - 'a']++;
            y[p[i] - 'a']++;
        }

        bool isMatch = true;

        for(int j = 0; j < x.Length; j++)
        {
            if(x[j] != y[j])
            {
                isMatch = false;
                break;
            }
        }

        if(isMatch)
        {
            result.Add(0);
        }


        for(int i = 1 ; i <= s.Length - p.Length ; i++)
        {
            isMatch = true;

            x[s[i-1] - 'a']--;
            x[s[i+(p.Length - 1)] - 'a']++;

            for(int j = 0; j < x.Length ; j ++)
            {
                if(x[j] != y[j])
                {
                    isMatch = false;
                    break;
                }
            }

            if(isMatch)
            {
                result.Add(i);
            }
        }



        return result;
    }
}