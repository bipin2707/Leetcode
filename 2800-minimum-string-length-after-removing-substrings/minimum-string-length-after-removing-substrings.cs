public class Solution {
    public int MinLength(string s) {

        StringBuilder sb=new StringBuilder();

        foreach (char ch in s)
        {
            int len=sb.Length;

            if(len>0 &&((sb[len-1]=='A'&& ch=='B')||(sb[len-1]=='C'&& ch=='D')))
            {
                sb.Remove(len-1,1);
            }
            else
            {
                sb.Append(ch);
            }
        }
        return sb.Length;
        
    }
}