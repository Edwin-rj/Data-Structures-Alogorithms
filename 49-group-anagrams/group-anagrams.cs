public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
         
IList<IList<string>> finalArray = new List<IList<string>>();

            Dictionary<string,List<int>> first = new();
            for (int index = 0; index < strs.Length; index++)
            {
                var key = new string(strs[index].OrderBy(c => c).ToArray());
                if(first.TryGetValue(key, out var res))
                {
                    res.Add(index);                
                }
                else{
                    first[key] = new List<int>{ index }; 
                }
            }

             foreach (var i in first)
             {
                
                   var io= i.Value;
                    List<string> m = new();
                    foreach(int h in io)
                    {
                        m.Add(strs[h]);
                    }

                    finalArray.Add(m);
                
            }

            return finalArray;
    }
}