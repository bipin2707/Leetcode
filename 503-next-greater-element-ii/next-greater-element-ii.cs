public class Solution {
    public int[] NextGreaterElements(int[] nums) {

        int n=nums.Length;
        int[] arr= new int[n];

        for (int i=0;i<n;i++)
        {
            arr[i]=-1;
        }

        Stack<int> stack=new Stack<int>();
        for(int i=2*n-1;i>=0;i--)
        {
            int num=i%n;
            while( stack.Count>0 && stack.Peek()<=nums[num])
            {
                stack.Pop();
            }

            if(stack.Count>0 && i<n)
            {
                arr[num]=stack.Peek();
            }

            stack.Push(nums[num]);
        }

        return arr;
        
    }
}