public class Solution {
    public string SmallestSubsequence(string s) {

        int [] last_index= new int[26];
        bool [] seen = new bool[26];

        for (int i=0;i<s.Length;i++)
        {
            last_index[s[i]-'a']=i;
        }

        StringBuilder sb = new StringBuilder();

        for (int i=0;i<s.Length;i++)
        {
            char ch=s[i];
            int indx= s[i]-'a';

            if (seen[indx])
            {
                continue;
            }

            while(sb.Length>0 && sb[sb.Length-1]>ch && last_index[sb[sb.Length-1]-'a']>i)
            {
                char removed =sb[sb.Length-1];
                sb.Remove(sb.Length-1,1);
                seen[removed-'a']=false;
            }

            sb.Append(ch);
            seen[ch-'a']=true;
        }
        return sb.ToString();
        
    }
}