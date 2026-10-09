public class Solution {
    public int MaxDistance(int[] position, int m) {
        Array.Sort(position);

        int l=1;
        int r=position[position.Length-1] - position[0];
        int ans=0;

        while(l<=r)
        {
            int mid=l+(r-l)/2;
            if(possible(position,m,mid))
            {
                ans=mid;
                l=mid+1;
            }
            else
            {
                r=mid-1;
            }
        }
        return ans;

        
    }

    private bool possible(int[] position, int m,int mid)
    {
        int last_pos=position[0];
        int count=1;

        for (int i=1;i<position.Length;i++)
        {
            if(position[i]-last_pos>=mid)
            {
                count++;
                last_pos=position[i];
            }
        }
       return count>=m;
    }
}