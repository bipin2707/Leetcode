public class Solution {
    public bool IsValid(string s) {

       Dictionary<char, char> map = new Dictionary<char, char>
        {
            { '}', '{' },
            { ')', '(' },
            { ']', '[' }
        };

        Stack<char>stack=new Stack <char> ();

        foreach (char ch in s)
        {
            
            if(stack.Count>0 && map.ContainsKey(ch) )
            {
                if(stack.Pop()!=map[ch])
                {
                    return false;
                }
                
            }
            else
            {
                stack.Push(ch);
            }
        }
        return stack.Count==0;


    }
}