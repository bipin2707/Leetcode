
public class Solution {
    public int LongestValidParentheses(string s) {

        int open = 0, close = 0, max = 0;

        
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(')
                open++;
            else
                close++;

            if (open == close)
                max = Math.Max(max, 2 * close);
            else if (close > open) {
                open = 0;
                close = 0;
            }
        }

        open = 0;
        close = 0;

        
        for (int i = s.Length - 1; i >= 0; i--) {
            if (s[i] == '(')
                open++;
            else
                close++;

            if (open == close)
                max = Math.Max(max, 2 * open);
            else if (open > close) {
                open = 0;
                close = 0;
            }
        }

        return max;
    }
}
