public class Solution {
    public int MajorityElement(int[] nums) {

        // int [] x  = new int[26];

        // for(int i = 0 ; i < nums.Length ; i++ )
        // {
        //     x[x]
        // }

        Dictionary <int,int> x = new ();

        foreach(var item in nums )
        {
            x[item] = x.GetValueOrDefault(item) + 1 ; 
        }

        foreach(var y in x)
        {
            if(y.Value > (nums.Length/2))
            {
                return y.Key;
            }
        }
        return -1; 
    }
}