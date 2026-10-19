public class Solution {
    public string RemoveKdigits(string num, int k) {

        StringBuilder sb=new StringBuilder();

        foreach (char ch in num)
        {
            

            while(sb.Length>0 && k>0 && ch<sb[sb.Length-1])
            {
                sb.Remove(sb.Length-1,1);
                k--;
            }
            
            sb.Append(ch);
    
        }

        sb.Remove(sb.Length-k,k);

        int start=0;
        while(start<sb.Length && sb[start]=='0')
        {
            start ++;
        }

       string ans= sb.ToString().Substring(start);

        return (ans.Length==0) ?"0":ans;
        
    }
}