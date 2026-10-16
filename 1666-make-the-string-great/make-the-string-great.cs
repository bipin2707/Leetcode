public class Solution {
    public string MakeGood(string s) {

        StringBuilder sb=new StringBuilder();

        foreach (char ch in s)
        {
            int len=sb.Length;

            if (len>0 && sb[len-1]!=ch && Char.ToLower(ch)==Char.ToLower(sb[len-1]))
            {
                sb.Remove(len-1,1);
            }
            else
            {
                sb.Append(ch);
            }
        }
        return sb.ToString();
        
    }
}