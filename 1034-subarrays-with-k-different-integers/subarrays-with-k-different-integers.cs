public class Solution {
    public int SubarraysWithKDistinct(int[] nums, int k) {

       return atmost(nums,k)-atmost(nums,k-1); 
    }

    private int atmost(int[] nums, int k)
    {
        int l=0;
        Dictionary<int,int>map= new Dictionary<int,int>();
        int count=0;

        for (int r=0;r <nums.Length;r++)
        {
            map[nums[r]]=map.GetValueOrDefault(nums[r],0)+1;

            while(map.Count>k)
            {
                map[nums[l]]--;

                if(map[nums[l]]==0)
                {
                    map.Remove(nums[l]);
                }
                l++;
            }
            count+=r-l+1;
        }
        return count;

    }
}