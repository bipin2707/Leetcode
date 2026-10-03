public class Solution {
    public int LengthOfLongestSubstring(string s) {

       Dictionary <char,int> map=new Dictionary<char,int> ();

       int l=0;
       int len=0;

       for (int r=0;r<s.Length;r++)
       {

        if (map.ContainsKey(s[r]))
        {
            l=Math.Max(l,map[s[r]]+1);

        }

        map[s[r]]=r;
        len=Math.Max(len,r-l+1);
         
       }
       return len;
    }
}