public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {

        

        Stack<int> stack=new Stack<int>();

        for (int i=0;i<asteroids.Length;i++)
        {
            while(stack.Count>0 && stack.Peek()>0 && asteroids[i]<0 && stack.Peek()<-asteroids[i])
            {
                stack.Pop();
            }
            if(stack.Count>0 && stack.Peek()>0 && asteroids[i]<0 )
            {
                if(stack.Peek() == -asteroids[i])
                {
                    stack.Pop();

                }

            }
            else
            {
                stack.Push(asteroids[i]);
            }

        }

        int [] arr = new int [stack.Count];

        for (int i=stack.Count-1;i>=0;i--)
        {
            arr[i]=stack.Pop();
            
        }

        return arr;
        
    }
}