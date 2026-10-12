public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {

        int n=temperatures.Length;
        int[] ans=new int[n];

        for (int i=0;i<n;i++)
        {
            ans[i]=0;
        }

        Stack<int> stack = new Stack<int>();
        for (int i=n-1;i>=0;i--)
        {
            while(stack.Count>0 && temperatures[stack.Peek()] <=temperatures[i])
            {
                stack.Pop();
            }

            if(stack.Count>0)
            {
                ans[i]=stack.Peek()-i;
            }

            stack.Push(i);
        }
        return ans;
    }
}