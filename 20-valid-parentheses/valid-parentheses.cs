public class Solution {
    public bool IsValid(string s) {

       Dictionary<char, char> map = new Dictionary<char, char>
        {
            { '}', '{' },
            { ')', '(' },
            { ']', '[' }
        };

        StringBuilder sb=new StringBuilder();

        foreach (char ch in s)
        {
            int len = sb.Length;
            if(len>0 && map.ContainsKey(ch) )
            {
                if(sb[len-1]!=map[ch])
                {
                    return false;
                }
                else
                {
                    sb.Remove(len-1,1);

                }
                
            }
            else
            {
                sb.Append(ch);
            }
        }
        return sb.Length<=0;


    }
}