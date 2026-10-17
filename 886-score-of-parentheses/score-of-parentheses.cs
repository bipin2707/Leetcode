public class Solution {
    public int ScoreOfParentheses(string s) {

        int score=0;

        Stack<int> stack =new Stack<int>();

        foreach(char ch in s)
        {
            if(ch=='(')
            {
                stack.Push(score);
                score=0;
            }
            else
            {
                score=stack.Pop()+ Math.Max(2*score ,1);
            }

        }
        return score;
        
    }
}