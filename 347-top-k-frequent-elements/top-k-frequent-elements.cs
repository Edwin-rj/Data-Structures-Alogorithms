public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        

        Dictionary<int,int> x = new();
        foreach (var item in nums)
        {
            x[item] = x.GetValueOrDefault(item)  + 1;
        }

        var y = new List<int>[nums.Length + 1];

        foreach (var ss in x)
        {
            y[ss.Value] ??= new List<int>();
            y[ss.Value].Add(ss.Key);
        }

        var kk = k ;
        List<int> z = new ();
        for(int i = y.Length - 1 ;z.Count < k ; i--)
        {
            if(y[i] is not null)
            {
                z.AddRange(y[i]);
            };
        }

        return z.ToArray();
    }
}