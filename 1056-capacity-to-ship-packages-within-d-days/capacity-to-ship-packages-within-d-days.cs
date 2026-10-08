public class Solution {
    public int ShipWithinDays(int[] weights, int days) {

        int l=weights.Max();
        int r=weights.Sum();
       
        //int ans=0;

        while(l<r)
        {
            int mid=l+(r-l)/2;
            if(canship( weights,  days, mid))
            {
                //ans=mid;
                r=mid;
            }
            else
            {
                l=mid+1;

            }
        }
        return l;

       
    }
     private bool canship(int[] weights, int days,int mid)
        {
            int d=1;
            int curr_Weight=0;
            for(int i=0;i<weights.Length;i++)
            {
                
                if(curr_Weight+weights[i]>mid)
                {
                    d++;
                    curr_Weight=weights[i];
                }
                else
                {
                    curr_Weight+=weights[i];
                }


            }
            return d<=days;
        }
}