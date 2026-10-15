
public class Solution
{
    public bool BackspaceCompare(string s, string t)
    {
        Stack<char> s1 = new Stack<char>();
        Stack<char> s2 = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (c == '#')
            {
                if (s1.Count > 0)
                    s1.Pop();
            }
            else
            {
                s1.Push(c);
            }
        }

        for (int i = 0; i < t.Length; i++)
        {
            char c = t[i];

            if (c == '#')
            {
                if (s2.Count > 0)
                    s2.Pop();
            }
            else
            {
                s2.Push(c);
            }
        }

        if (s1.Count != s2.Count)
            return false;

        while (s1.Count > 0)
        {
            if (s1.Pop() != s2.Pop())
                return false;
        }

        return true;
    }
}
