public class Solution {
    public int CountSubstrings(string s) {

        int count=0;

        for (int i=0;i<s.Length;i++)
        {
            count+=Expand(s,i,i);
            count+=Expand(s,i,i+1);
        }
        return count;
    }

    private int Expand(string s, int l,int r)
    {
        int res =0;

        while (l>=0 && r<s.Length && s[r]==s[l])
        {
            res++;
            l--;
            r++;

        }

        return res;

    }
}