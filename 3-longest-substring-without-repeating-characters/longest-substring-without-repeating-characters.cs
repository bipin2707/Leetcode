public class Solution {
    public int LengthOfLongestSubstring(string s) {

        int len=0;
        Dictionary< char ,int> map= new Dictionary<char,int>();

        int l=0;

        for (int r = 0; r < s.Length; r++)
        {
            map[s[r]] = map.GetValueOrDefault(s[r], 0) + 1;

            while (map[s[r]] > 1)
            {
                map[s[l]]--;

                if (map[s[l]] == 0)
                {
                    map.Remove(s[l]);
                }

                l++;
            }

            len = Math.Max(len, r - l + 1);
        }

        return len;
        
    }
}