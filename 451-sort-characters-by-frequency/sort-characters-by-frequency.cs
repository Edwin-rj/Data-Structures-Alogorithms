public class Solution {
    public string FrequencySort(string s) {

        string result = "";

        Dictionary<char,int> x = new();

        for(int i = 0; i < s.Length; i++)
        {
            if(x.TryGetValue(s[i], out int y))
            {
                x[s[i]] = y + 1;
            }
            else
            {
                x[s[i]] = 1;
            }
        }

        foreach(var item in x.OrderByDescending(x => x.Value))
        {
            result += new string(item.Key, item.Value);
        }

        return result;
    }
}