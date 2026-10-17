public class Solution
{
    public bool BackspaceCompare(string s, string t)
    {

        int i=s.Length-1;
        int j =t.Length-1;

        int skips=0;
        int skipt=0;

        while(i>=0 || j>=0) 
        {
            while(i>=0)
            {
                if(s[i]=='#')
                {
                    skips++;
                    i--;
                }
                else if(skips>0)
                {
                    skips--;
                    i--;
                }
                else
                {
                    break;
                }
            }

            while(j>=0)
            {
                if(t[j]=='#')
                {
                    skipt++;
                    j--;
                }
                else if(skipt>0)
                {
                    skipt--;
                    j--;
                }
                else
                {
                    break;
                }
            }

            if (i>=0 && j>=0)
            {
                if(s[i]!=t[j]) 
                {
                    return false;
                }
            }
            else
            {
                if (i>=0 || j>=0)
                return false;
            }

            i--;
            j--;

        }
        return true;
     
    }
}











// public class Solution
// {
//     public bool BackspaceCompare(string s, string t)
//     {
//         Stack<char> s1 = new Stack<char>();
//         Stack<char> s2 = new Stack<char>();

//         for (int i = 0; i < s.Length; i++)
//         {
//             char c = s[i];

//             if (c == '#')
//             {
//                 if (s1.Count > 0)
//                     s1.Pop();
//             }
//             else
//             {
//                 s1.Push(c);
//             }
//         }

//         for (int i = 0; i < t.Length; i++)
//         {
//             char c = t[i];

//             if (c == '#')
//             {
//                 if (s2.Count > 0)
//                     s2.Pop();
//             }
//             else
//             {
//                 s2.Push(c);
//             }
//         }

//         if (s1.Count != s2.Count)
//             return false;

//         while (s1.Count > 0)
//         {
//             if (s1.Pop() != s2.Pop())
//                 return false;
//         }

//         return true;
//     }
// }
