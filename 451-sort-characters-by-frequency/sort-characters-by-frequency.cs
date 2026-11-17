public class Solution {
    public string FrequencySort(string s) {
        
        Dictionary<char ,int> x =  new();
        foreach(var k in s)
        {
            x[k]  = x.GetValueOrDefault(k) + 1 ;
        }

        var freq = new List<char>[s.Length + 1];

        foreach(var item in x)
        {
            if(freq[item.Value] is null)
            {
                freq[item.Value] = new List<char>();
            }

            freq[item.Value].Add(item.Key);
        }

        var sb = new StringBuilder(s.Length);

        for(int i = freq.Length-1 ; i > 0 ; i--)
        {
            if(freq[i] is null)
                continue;
                
            var yy = freq[i];

            for(int j = 0; j < yy.Count ; j ++)
            {
                
                sb.Append(yy[j],i);
            }
        }

        return sb.ToString();
    }
}