public class Solution {
    public bool CheckInclusion(string s1, string s2) {

        Dictionary<char,int> map= new Dictionary<char,int>();
        if (s2.Length<s1.Length) return false;

        for (int i=0;i<s1.Length;i++)
        {
            map[s1[i]]=map.GetValueOrDefault(s1[i],0)+1;
        }

        int l=0;
        int count=s1.Length;
        
        for(int r=0;r<s2.Length;r++)
        {
            char ch=s2[r];
            int val=map.GetValueOrDefault(s2[r],0);
            if(val>0) count--;
            map[s2[r]]=map.GetValueOrDefault(s2[r],0)-1;

            if(r-l+1>s1.Length)
            {
                char leftch=s2[l];
                int leftval=map.GetValueOrDefault(s2[l],0);
                if(leftval>=0) count++;
                map[s2[l]]=map.GetValueOrDefault(s2[l],0)+1;
                l++;
            }

            if (count==0)
            {
                return true;
            }
        }  
        return false; 
    }
}