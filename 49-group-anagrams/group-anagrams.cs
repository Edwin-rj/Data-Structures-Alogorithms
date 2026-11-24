public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {

     Dictionary <string , List<string>> x = new ();

     var i = new List<IList<string>>();

     foreach(var s in strs)
     {
        char[] chars = s.ToArray();
        Array.Sort(chars);
        var k = new string(chars);


        if(x.TryGetValue(k, out var y))
        {
            y.Add(s);
        }
        else
        {
            x[k] =  new List<string>(); 
            x[k].Add(s);
        }
     }

     foreach(var item in x)
     {
        i.Add(item.Value);
     }


     return i;



    }
}