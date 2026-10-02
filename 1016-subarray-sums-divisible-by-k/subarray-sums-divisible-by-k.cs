public class Solution {
    public int SubarraysDivByK(int[] nums, int k) {
        
        int n=nums.Length;
        Dictionary<int,int> map=new Dictionary<int,int>();
        map[0]=1;

        int prefixsum=0;
        int count=0;
        for(int i=0;i<n;i++)
        {
            prefixsum+=nums[i];
            int rem=prefixsum%k;

            if(rem<0)
            {
                rem+=k;
            }

            if (map.ContainsKey(rem))
            {
                count+=map[rem];
            }
            map[rem]=map.GetValueOrDefault(rem,0)+1;
        }
        return count;
    }
}