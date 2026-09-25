public class Solution {
    public int MaxArea(int[] height) {

        int l=0;
        int r=height.Length-1;
        int maxarea=0;

        while(l<=r)
        {
            int area=0;
            int w=r-l;
            int h=Math.Min(height[l],height[r]);
            area=h*w;
            maxarea=Math.Max(maxarea,area);

            if(height[l]>height[r])
            {
                r--;
            }
            else
            {
                l++;
            }
        }
        return maxarea;
    }
}