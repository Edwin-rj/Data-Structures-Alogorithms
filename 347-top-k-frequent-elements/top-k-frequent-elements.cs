public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
         Dictionary <int, int> x = new ();
         for(int i = 0 ; i < nums.Length ; i++)
         {
            if(x.TryGetValue(nums[i], out int y))
            {
               x[nums[i]]=++y;
            }else
            {
                x[nums[i]] = 1;
            }
         } 

         List<int> values = new();

         var z = x.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key , x => x.Value).Take(k);
        foreach(var i in z)
        {
            values.Add(i.Key);
        }
        return values.ToArray();
    }
}
