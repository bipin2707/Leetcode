public class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        
        Dictionary<int,int>map= new Dictionary<int,int> ();
        map[0]=1;
        int count = 0;
        int sum=0;

        for (int r = 0; r < nums.Length; r++)
        {
            sum+=nums[r];

            if (map.ContainsKey(sum-k))
            {
                count+=map[sum-k];
            }

           map[sum]=map.GetValueOrDefault(sum,0)+1;


        }

        return count;
    }
}