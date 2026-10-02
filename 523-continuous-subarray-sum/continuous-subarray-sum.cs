public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        
        int n=nums.Length;
        Dictionary<int,int> map=new Dictionary<int,int> ();

        map[0]=-1;
        int prefixsum=0;

        for( int i=0;i<n;i++)
        {
            prefixsum+=nums[i];
            int rem=prefixsum % k;

            if (map.ContainsKey(rem) )
            {
                if(i-map[rem]>=2)
                
                return true;
                
            }
             else
            {
                map[rem] = i;
            }
        }
        return false;
    }
}