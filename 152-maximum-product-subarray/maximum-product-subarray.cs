public class Solution {
    public int MaxProduct(int[] nums) {

        int n=nums.Length;
        int minprod=nums[0];
        int maxprod=nums[0];
        int result=nums[0];

        for (int i=1;i<n;i++ )
        {
           int tempmax=Math.Max(nums[i],Math.Max(maxprod*nums[i],minprod*nums[i]));
           int tempmin=Math.Min(nums[i],Math.Min(maxprod*nums[i],minprod*nums[i]));

            maxprod=tempmax;
            minprod=tempmin;

            result=Math.Max(result,maxprod);

        }
        return result;
        
    }
}