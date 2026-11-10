public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        
        Dictionary<string,int> x = new ();

        foreach(var item in words)
        {
            x[item] =  x.GetValueOrDefault(item) + 1 ;
        }

        var y =  new List<string>[words.Length + 1];

        foreach(var item in x)
        {
            y[item.Value] ??= new List<string>();
            y[item.Value].Add(item.Key);
        }


        List<string> z  = new ();
        for(int i = y.Length - 1 ; z.Count < k; i--)
        {
           if(y[i] is not null)
           {
                y[i].Sort(StringComparer.Ordinal);

             foreach(var item in y[i])
             {
                if(z.Count < k)
                {
                    z.Add(item);
                };
             }
           }
        }

        return z.ToArray();
    }
}