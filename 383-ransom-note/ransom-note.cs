public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
    
     int [] x = new int [26];

     for(int i = 0 ; i < ransomNote.Length ; i ++)
     {
        x[ransomNote[i]-'a']++;
     }

     for(int j = 0 ; j < magazine.Length ; j ++)
     {
        x[magazine[j]-'a']--;
     }

     return x.All(y=>y<=0);
    
    }
}