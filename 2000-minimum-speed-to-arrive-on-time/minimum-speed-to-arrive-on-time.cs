public class Solution {
    public int MinSpeedOnTime(int[] dist, double hour) {

        int l=1;
        int r = 10000000;
        

        while(l<r)
        {
            int speed=l+(r-l)/2;
            if(minspeed(dist,hour,speed))
            {
                
                r=speed;

            }
            else
            {
                l=speed+1;
            }
        }
        return minspeed(dist, hour, l) ? l : -1;
        
    }

    private bool minspeed(int[] dist, double hour, int speed)
    {
        double totalTime=0;
        for (int i=0;i<dist.Length-1;i++)
        {
            totalTime += Math.Ceiling((double)dist[i] / speed);

        }
        totalTime += (double)dist[dist.Length - 1] / speed;
        return totalTime<=hour;
    }
}