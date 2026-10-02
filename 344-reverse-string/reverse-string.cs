public class Solution {
    public void ReverseString(char[] s) {

        int n=s.Length-1;
        int l=0;
        int r=n;

        while(l<=r)
        {
           ( s[l],s[r])=(s[r],s[l]);

           l++;
           r--;
        }
        
    }
}