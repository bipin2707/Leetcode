public class Solution {
    public int LongestOnes(int[] nums, int k) {
        
        int zerocount=0;
        int n=nums.Length;
        int l=0;
        int maxlength=0;

        for (int r=0;r<n;r++)
        {
            if(nums[r]==0)
            {
                zerocount++;
            }
            if(zerocount>k)
            {
                if(nums[l]==0)
            {
                zerocount--;
            }
                
                l++;
            }
            
        }
        return n-l ;
    }
}