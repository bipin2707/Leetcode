public class Solution {
    public int MaximalRectangle(char[][] matrix) {

        int m=matrix.Length;
        int n=matrix[0].Length;

        int max_area=0;
        int [] heights=new int [n];

        for (int i=0;i<m;i++)
        {          
            for(int j=0;j<n;j++)
            {
                if (matrix[i][j]=='1')
                {
                    heights[j]+=1;
                }
                else
                {
                    heights[j]=0;
                }
                
            }
            max_area=Math.Max(max_area,largest_rectangle(heights));
        }
        return max_area;        
    }

    private int largest_rectangle(int []heights)
    {
        int n=heights.Length;
        Stack<int> stack=new Stack<int>();
        int maxarea=0;

        for (int i=0;i<=n;i++)
        {
            int h= (i==n)?0: heights[i];
           
            while(stack.Count>0 && h<heights[stack.Peek()] )
            {
                int height = heights[stack.Pop()];
                int w= (stack.Count>0)? i-stack.Peek()-1:i;
                int area=height*w;
                maxarea=Math.Max(maxarea,area);
                
            }
            stack.Push(i);
        }
        return maxarea;

    }
}