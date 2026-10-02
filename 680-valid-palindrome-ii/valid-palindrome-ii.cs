public class Solution {
    public bool ValidPalindrome(string s) {

        int l=0;
        int r=s.Length-1;

        while(l<r)
        {
            if(s[l]!=s[r])
            {
                return IsValidPalindrome(s,l+1,r) || IsValidPalindrome(s,l,r-1);
            }

            l++;
            r--;
        }
        return true;
        
    }

    private bool IsValidPalindrome (string s,int l,int r)
    {
        

        while(l<r)
        {
            if (s[l]!=s[r])
            {
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
}