public class Solution {
    public string MinRemoveToMakeValid(string s) {

        Stack<int> stack=new Stack <int> ();
        char [] arr = s.ToArray();

        for (int i=0;i<s.Length;i++)
        {
            if (s[i]=='(')
            {
                stack.Push(i);
            }
            else if (s[i]==')')
            {
                if (stack.Count>0)
                {
                    stack.Pop();
                }
                else
                {
                    arr[i]='#';
                }
            }
        }

        while(stack.Count>0)
        {
            arr[stack.Pop()]='#';
        }

        StringBuilder sb =new StringBuilder();

        for (int i=0;i<arr.Length;i++)
        {
            if (arr[i]!='#')
            {
                sb.Append(arr[i]);
            }
        }

        return sb.ToString();
        
    }
}



















// public class Solution {
//     public string MinRemoveToMakeValid(string s) {

//         int open=0;


//         StringBuilder sb=new StringBuilder();

//         foreach (char ch in s)
//         {
//             int len=sb.Length;
//             if (ch=='(')
//             {
//                 open++;
//                 sb.Append(ch);
//             }
//             else if (ch==')')
//             {
                
//                 if(open>0 )
//                 {
//                     sb.Append(ch);
                    
//                     open--;
//                 }
//             }
//             else
//             {
//                 sb.Append(ch);
//             }
//         }

//         StringBuilder result = new StringBuilder ();

//         for (int i=sb.Length-1;i>=0;i--)
//         {
//             if (sb[i]=='(' && open>0)
//             {
//                 open--;
//                 continue;
//             }
//             result.Append(sb[i]);
//         }

        

//         return new string(result.ToString().Reverse().ToArray());

        
//     }
// }