public class MyQueue {

    Stack<int>input;
    Stack<int>output;


    public MyQueue() {
        input=new Stack<int> ();
        output=new Stack<int> ();
        
    }
    
    public void Push(int x) {
        input.Push(x);
        
    }
    
    public int Pop() {
        moveelement();
        return output.Pop();
        
    }
    
    public int Peek() {
        moveelement();
        return output.Peek();
    }
    
    public bool Empty() {
        return input.Count==0 && output.Count==0;
        
    }

    private void moveelement()
    {
        if (output.Count==0)
        {
            while(input.Count>0)
            {
                output.Push(input.Pop());
            }

        }
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */