public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int n=nums.Length;
        int count=0;
        int maxcount=0;

        for(int i=0;i<n;i++)
        {
            if (nums[i]==1)
            {
                count ++;
            }
            else
            {
                maxcount = Math.Max(maxcount,count);
                count=0;
            }
        }
        return Math.Max(maxcount,count); 
        
    }
}