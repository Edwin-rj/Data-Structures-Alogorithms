public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int,int> x =  new();

        foreach(var item in nums)
        {
            x[item] = x.GetValueOrDefault(item) + 1;
        }

        var freq = new List<int>[nums.Length + 1];

        
        foreach(var item in x)
        {
            if(freq[item.Value] is null)
            {
                freq[item.Value] =  new List<int>();
            }

            freq[item.Value].Add(item.Key);
        }

        var count = k ;
        int index = 0;

        var result = new int [k]; 

        for(int i = freq.Length - 1 ; i >= 1 && 0 < count ; i -- )
        {
            if(freq[i] is null)
            {
                continue;
            }

            var jj = freq[i];

            for(int j = 0 ; j < jj.Count ; j ++)
            {
                result[index++] = jj[j];
                count = count - 1;
            }
        }

        return result;

    }
}