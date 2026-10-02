public class Solution {
    public int MaxSubArray(int[] nums) {

        int n=nums.Length;
        int currsum=nums[0];
        int maxsum=nums[0];

        for (int i=1;i<n;i++)
        {
            currsum=Math.Max(nums[i],currsum+nums[i]);
            maxsum=Math.Max(maxsum,currsum);
        }
        return maxsum;
        
    }
}