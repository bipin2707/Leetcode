public class Solution {
    public int MaxAbsoluteSum(int[] nums) {
        
        int n=nums.Length;
        int currmax=nums[0];
        int maxsum=nums[0];
        int currmin=nums[0];
        int minsum=nums[0];

        for(int i=1;i<n;i++)
        {
            currmax=Math.Max(nums[i],currmax+nums[i]);
            maxsum=Math.Max(currmax,maxsum);

            currmin=Math.Min(nums[i],currmin+nums[i]);
            minsum=Math.Min(currmin,minsum);
        }
        return Math.Max(maxsum,Math.Abs(minsum));
    }
}