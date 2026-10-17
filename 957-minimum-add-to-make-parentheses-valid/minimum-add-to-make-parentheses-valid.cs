public class Solution {
    public int MinAddToMakeValid(string s) {
        int open=0;
        int close=0;
        

        foreach(char ch in s)
        {
            if (ch=='(')
            {
                open ++;
            }
            else 
            {
                if(open>0)
                {
                    open--;
                }
                else
                {
                    close++;
                }
            }
        }

        return open+close;
        
    }
}