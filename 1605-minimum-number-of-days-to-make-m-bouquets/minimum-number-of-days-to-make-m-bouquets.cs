public class Solution {
    public int MinDays(int[] bloomDay, int m, int k) {
        
        int l=bloomDay.Min();
        int r=bloomDay.Max();

        int ans=-1;
        

        while(l<=r)
        {
            int mid=l+(r-l)/2;

            if (possible(bloomDay, m, k, mid))
            {
                ans=mid;
                r=mid-1;
            }
            else
            {
                l=mid+1;
            }
        }
        return ans;
    }

    private bool possible(int[] bloomDay, int m, int k,int mid)
    {
        int count=0;
        int b=0;
        for (int i=0;i<bloomDay.Length;i++)
        {
            if(bloomDay[i]<=mid)
            {
                count++;
                if (count==k)
                {
                    b++;
                    count=0;
                }
            }
            else
            {
                count=0;

            }
            
        }
        return b>=m;

    }
    
}