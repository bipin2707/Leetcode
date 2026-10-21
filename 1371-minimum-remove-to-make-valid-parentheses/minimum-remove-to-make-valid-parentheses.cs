public class Solution {
    public string MinRemoveToMakeValid(string s) {

        int open=0;
        int close=0;

        StringBuilder sb=new StringBuilder();

        foreach (char ch in s)
        {
            int len=sb.Length;
            if (ch=='(')
            {
                open++;
                sb.Append(ch);
            }
            else if (ch==')')
            {
                
                if(open>0 )
                {
                    sb.Append(ch);
                    
                    open--;
                }
            }
            else
            {
                sb.Append(ch);
            }
        }

        StringBuilder result = new StringBuilder ();

        for (int i=sb.Length-1;i>=0;i--)
        {
            if (sb[i]=='(' && open>0)
            {
                open--;
                continue;
            }
            result.Append(sb[i]);
        }

        string ans = result.ToString();

        return new string(ans.Reverse().ToArray());



        
        
    }
}