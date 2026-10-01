public class Solution {
    public int PivotIndex(int[] nums) {

        int n=nums.Length;
        int totalsum=0;
        int rightsum=0;
        int leftsum=0;
        for (int i=0;i<n;i++)
        {
            totalsum+=nums[i];
        }

        for (int i=0;i<n;i++)
        {
             rightsum=totalsum-leftsum-nums[i];
            if(rightsum==leftsum)
            {
                return i;   
            }
            leftsum+=nums[i];
        }

        return -1; 
        
    }
}