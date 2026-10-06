public class Solution {
    public void Rotate(int[] nums, int k) {
        int n=nums.Length;
        k=k%n;

        reverse(nums,0,n-1);
        reverse(nums,0,k-1);
        reverse(nums,k,n-1);
        
    }

    private void reverse(int [] nums, int l, int r)
    {
        while(l<r)
        {
            int temp=nums[l];
            nums[l]=nums[r];
            nums[r]=temp;

            // (nums[l],nums[r])=(nums[r],nums[l]);

           l++;
           r--;

        }
    }
}