public class Solution {
    public int TotalFruit(int[] fruits) {

        if (fruits.Length <= 2) return fruits.Length;
  
        int l=0;
        int max=0;

        Dictionary<int,int> map=new Dictionary<int,int>();

        for (int r=0;r<fruits.Length;r++)
        {
            map[fruits[r]]=map.GetValueOrDefault(fruits[r],0)+1;

            while(map.Count()>2)
            {
                map[fruits[l]]--;

                if(map[fruits[l]]==0)
                {
                    map.Remove(fruits[l]);
                }
                l++;
            }

            max=Math.Max(max,r-l+1);
        }
       return max; 
    }
}