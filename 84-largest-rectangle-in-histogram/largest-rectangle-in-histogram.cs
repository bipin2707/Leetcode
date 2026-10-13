public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int n=heights.Length;

        Stack<int> stack =new Stack<int>();
        int max_area=0;

        for (int i=0;i<=n;i++)
        {
            int h= (i==n) ?0 : heights[i];
            while(stack.Count>0 && h<heights[stack.Peek()])
            {
                int height = heights[stack.Pop()];
                int w = (stack.Count>0) ? i -stack.Peek()-1 : i;
                int area=height*w;

                max_area=Math.Max(area,max_area);

            }
            stack.Push(i);

        }
        return max_area;
        
    }
}