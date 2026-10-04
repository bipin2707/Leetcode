public class Solution {
    public IList<int> FindAnagrams(string s, string p) {

        List<int> res = [];

        if (s.Length<p.Length) return res;
        Dictionary<char,int> map = new Dictionary<char,int>();

        for (int i=0;i<p.Length;i++)
        {
            map[p[i]]=map.GetValueOrDefault(p[i],0)+1;
        }

        int count=p.Length;
        int l=0;

        for (int r=0;r<s.Length;r++)  
        {
            char ch=s[r];

            int val=map.GetValueOrDefault(ch,0);

            if (val>0) count--;
            map[ch]=map.GetValueOrDefault(ch,0)-1;

            if(r-l+1>p.Length)
            {
                char leftchar=s[l];
                int leftval=map.GetValueOrDefault(leftchar,0);

                if(leftval>=0) count++;
                map[leftchar]=map.GetValueOrDefault(leftchar,0)+1;
                l++;
            }

            if (count==0)
            {
                res.Add(l);
            }
        } 
        return res;     
    }
}