
public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new Stack<int>();

        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int num))
            {
                stack.Push(num);
            }
            else
            {
                int a = stack.Pop();
                int b = stack.Pop();

                if (token == "+")
                    stack.Push(b + a);
                else if (token == "-")
                    stack.Push(b - a);
                else if (token == "*")
                    stack.Push(b * a);
                else if (token == "/")
                    stack.Push(b / a);
            }
        }

        return stack.Peek();
    }
}
