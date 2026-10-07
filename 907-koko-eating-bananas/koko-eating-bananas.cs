public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {

        int l=1;
        int r=piles.Max();

        while(l<r)
        {
            int mid=l+(r-l)/2;
            
            long hours = 0;
            for(int i=0;i<piles.Length;i++)
            {
                 hours+=(piles[i]+mid-1)/mid;
            }

            if (hours<=h)
            {
                
                r=mid;
            }
            else
            {
                l=mid+1;
            }
        }
        return l;



        
    }
}