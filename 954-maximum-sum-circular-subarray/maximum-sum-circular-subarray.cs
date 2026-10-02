public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
      int n=nums.Length;
      int maxsum=nums[0];
      int currmax=nums[0];
      int minsum=nums[0];
      int currmin=nums[0];
      int totalsum=nums[0];

      for ( int i=1;i<n;i++)
      {
        totalsum+=nums[i];

        currmax=Math.Max(nums[i],currmax+nums[i]);
        maxsum=Math.Max(currmax,maxsum);

        currmin=Math.Min(nums[i],currmin+nums[i]);
        minsum=Math.Min(currmin,minsum);
      }  
      if(maxsum<0)
      {
        return maxsum;
      } 

      return Math.Max(maxsum,totalsum-minsum);
        
    }
}