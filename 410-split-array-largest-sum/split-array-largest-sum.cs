public class Solution {
    public int SplitArray(int[] nums, int k) {

        int l=nums.Max();
        int r=nums.Sum();

        if (k>nums.Length) return -1;

        int ans=-1;

        while(l<=r)
        {
            int mid=l+(r-l)/2;
            if(poss( nums,  k,  mid))
            {
                ans =mid;
                r=mid-1;
            }
            else
            {
                l=mid+1;
            }
        }
        return ans;
        
    }
    private bool poss (int[] nums, int k, int mid)
    {
        int sum=0;
        int count=1;

        for (int i=0;i<nums.Length;i++)
        {
            if(sum+nums[i]<=mid)
            {
                sum+=nums[i];
            }
            else
            {
                count ++;
                sum=nums[i];
            }
        }
        return count<=k;
    }
}