public class Solution {
    public string RemoveDuplicates(string s) {

        StringBuilder sb=new StringBuilder ();

        foreach(char ch in s)
        {
            int len=sb.Length;

            if( len>0 && ch==sb[len-1])
            {
                sb.Remove(len-1,1);
            }
            else
            {
                sb.Append(ch);
            }
        }
        return sb.ToString();

    }
}


























// public class Solution {
//     public string RemoveDuplicates(string s) {
        
//         int n=s.Length;

//         Stack<char> s1 =new Stack<char>();

//         for(int i=0;i<n;i++)
//         {
//             char c=s[i];

//             if (s1.Count>0 && c==s1.Peek())
//             {
//                 s1.Pop();
//             }
//             else
//             {
//                 s1.Push(c);
//             }

//         }

//         string result = new string(s1.Reverse().ToArray());
//         return result;
//     }
    
// }