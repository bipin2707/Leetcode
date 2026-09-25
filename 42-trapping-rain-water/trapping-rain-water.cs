public class Solution {
    public int Trap(int[] height) {
        int n=height.Length-1;
        int l=0;
        int r=n;
        int water=0;
        int leftmax=height[0], rightmax=height[n];
        while(l<r)
        {
            if(rightmax<leftmax)
            {
                r--;
                rightmax=Math.Max(rightmax,height[r]);
                water+=rightmax-height[r];
            }
            else
            {
                l++;
                leftmax=Math.Max(leftmax,height[l]);
                water+=leftmax-height[l];
            }
        }
        return water;
        
    }
}