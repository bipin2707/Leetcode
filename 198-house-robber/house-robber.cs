public class Solution {
    public int Rob(int[] nums) {

        int p0=0;
        int p1=0;

        foreach(int money in nums)
        {
            int curr=Math.Max(p1,p0+money);

            p0=p1;
            p1=curr;
        }
        return p1;
        
    }
}