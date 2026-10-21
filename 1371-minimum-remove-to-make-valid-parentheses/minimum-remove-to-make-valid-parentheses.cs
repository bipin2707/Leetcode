public class Solution {
    public string MinRemoveToMakeValid(string s) {

        int open=0;


        StringBuilder sb=new StringBuilder();

        foreach (char ch in s)
        {
            
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

        StringBuilder res = new StringBuilder ();
        int close=0;
        for (int i=sb.Length-1;i>=0;i--)
        {
            char ch =sb[i];
            if (ch==')')
            {
                close++;
                res.Append(ch);
            }
            else if (ch=='(')
            {
                
                if(close>0 )
                {
                    res.Append(ch);
                    
                    close--;
                }
            }
            else
            {
                res.Append(ch);
            }
        }

        

        return new string(res.ToString().Reverse().ToArray());



        
        
    }
}