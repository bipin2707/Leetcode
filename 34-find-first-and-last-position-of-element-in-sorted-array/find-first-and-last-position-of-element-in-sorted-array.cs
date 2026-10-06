public class Solution {
    public int[] SearchRange(int[] nums, int target) {

        return new int [] { firstocc(nums,target),lastocc(nums,target)};
        
    }

    private int firstocc (int[] nums, int target)
    {
        int l=0;
        int r=nums.Length-1;
        int ans=-1;

        while(l<=r)
        {
            int mid=l+(r-l)/2;

            if(nums[mid]==target)
            {
                ans= mid;
                r=mid-1;

            }
            else if(nums[mid]<target)
            {
                l=mid+1;
            }
            else
            {
                r=mid-1;
            }
        }
        return ans;
    }

     private int lastocc (int[] nums, int target)
    {
        int l=0;
        int r=nums.Length-1;
        int ans=-1;

        while(l<=r)
        {
            int mid=l+(r-l)/2;

            if(nums[mid]==target)
            {
                ans= mid;
                l=mid+1;

            }
            else if(nums[mid]<target)
            {
                l=mid+1;
            }
            else
            {
                r=mid-1;
            }
        }
        return ans;
    }
}