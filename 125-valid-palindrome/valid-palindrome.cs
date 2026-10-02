public class Solution {
    public bool IsPalindrome(string s) {

        int n=s.Length-1;
        int l=0;
        int r=n;

        while(l<=r)
        {

            while(l<=r && !Char.IsLetterOrDigit(s[l]))
            {
                l++;
            }
             while(l<=r && !Char.IsLetterOrDigit(s[r]))
            {
                r--;
            }
             if (l > r)
            {
                break;
            }
            if(Char.ToLower(s[l])!=Char.ToLower(s[r]))
            {
                return false;
            }
            l++;
            r--;
        }

        return true;
        
    }
}