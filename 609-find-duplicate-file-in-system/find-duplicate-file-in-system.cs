public class Solution {
    public IList<IList<string>> FindDuplicate(string[] paths) {

        List<string>  y = new();
        var rooot = new List<IList<string>>();
        foreach(var item in paths)
        {
            var items = item.Split(' ');

            for(int i = 1 ; i < items.Length ;i ++)
            {
                y.Add(items[0] + "/"+ items[i]);
            }
        }

        Dictionary <string,List<string>> j = new();

        foreach(var item in y)
        {
            var hi = item.Split("(");

            if(j.TryGetValue(hi[1],out var k))
            {
                k.Add(hi[0]);
            }else
            {
                j[hi[1]] = new List<string>() {hi[0]};
            }
        }


        foreach(var item in j)
        {
            if(item.Value.Count > 1)
            {
             rooot.Add(item.Value);
            }
        }

        return rooot;
    }
}