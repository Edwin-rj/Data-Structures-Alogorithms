public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> first = new();
        if(s.Count()!=t.Count())return false;

        foreach(char i in s)
        {
            if(first.TryGetValue(i,out int k))
            {
                 first[i] = ++k;
            }else{

            first[i] = 1;}
        }

        foreach(char j in t )
        {
            if(first.TryGetValue(j,out int k))
            {
                if(k == 1)
                {
                    first.Remove(j);
                }else{
                    first[j] = --k;
                }
            }
        }

        if(first.Count()==0)
        {
            return true;
        }
        return false;
    }
}