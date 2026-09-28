public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {

        int n=nums.Length;
        int l=0;
        int minlen=int.MaxValue;
        int sum=0;

        for (int r=0;r<n;r++)
        {
            sum+=nums[r];

            while(sum>=target)
            {
                minlen=Math.Min(r-l+1,minlen);
                sum-=nums[l];
                l++;
            }
        }
        return minlen==int.MaxValue ? 0 : minlen;
    }
}