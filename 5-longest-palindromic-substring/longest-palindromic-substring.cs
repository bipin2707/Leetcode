public class Solution {
    public string LongestPalindrome(string s) {
        
        if(s.Length<=0)
        {
            return "" ;
        }
        int maxlen=0;
        int start=0;

        for (int i=0;i<s.Length;i++)
        {
            int len1= ExpandFromCenter(s,i,i);
            int len2=ExpandFromCenter(s,i,i+1);

            int len=Math.Max(len1,len2);

            if (len>maxlen)
            {
                maxlen=len;

                start=i-(len-1)/2;
            }
           
        }
        return s.Substring(start,maxlen);
    }

    private int ExpandFromCenter (string s,int l,int r)
    {
        while(l>=0 && r< s.Length && s[l]==s[r])
        {     
            l--;
            r++;
        }
        return r-l-1;
    }
}