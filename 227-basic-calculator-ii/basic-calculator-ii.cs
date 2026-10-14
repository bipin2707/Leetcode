public class Solution {
    public int Calculate(string s) {

        int n=s.Length;
        int num=0;
        char op='+';

        Stack<int> stack= new Stack<int>();

        for (int i=0;i<=n;i++)
        {
            char ch= (i==n)?'+':s[i];
            
            if (char.IsDigit(ch))
            {
                num=num*10+(ch-'0');
            } 

            if((!char.IsDigit(ch) &&ch!=' ') || i==n)
            {
                if (op=='+')
                {
                    stack.Push(num);
                }
                else if (op=='-')
                {
                    stack.Push(-num);
                }
                 else if (op=='*')
                {
                    stack.Push(stack.Pop()*num);
                }
                 else if (op=='/')
                {
                    stack.Push(stack.Pop()/num);
                }

                op=ch;
               num=0;
            }
            

        }


        int ans=0;
        while(stack.Count>0)
        {
            ans+=stack.Pop();
        }
        return ans;
        
    }
}