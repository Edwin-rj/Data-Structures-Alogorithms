public class Solution {
    public string FrequencySort(string s) {

        string result = "";

        Dictionary<char,int> x = new();

        foreach(var item in  s)
        {
            x[item] = x.GetValueOrDefault(item) + 1; 
        }

        var buckets = new List<char>[s.Length+1];

        foreach(var item in x)
        {
            if(buckets[item.Value] is null){
                buckets[item.Value] = new List<char>();
            }  

            buckets[item.Value].Add(item.Key);      
        }

        StringBuilder sb = new StringBuilder (s.Length);

        for(int i = s.Length;i >= 1 ;i--)
        {
            if(buckets[i]  is null)
            {
                continue;
            }
            
            foreach(var item in buckets[i])
            {
                sb.Append(item,i);
            }
        }
        return sb.ToString();
    }
}