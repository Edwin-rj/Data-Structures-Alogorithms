public class Solution {
    public IList<IList<string>> FindDuplicate(string[] paths) {


        var rooot = new List<IList<string>>();
        Dictionary <string,List<string>> j = new();

        foreach(var item in paths)
        {
            var items = item.Split(' ');

            for(int i = 1 ; i < items.Length ;i ++)
            {
                var hi = items[i].Split("(");
                if(j.TryGetValue(hi[1],out var k))
                {
                    k.Add((items[0] + "/"+ hi[0]));
                }else
                {
                    j[hi[1]] = new List<string>() {(items[0] + "/"+ hi[0])};
                }
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