public class MinStack {
    Stack<int> stack;
    Stack<int> minstack;

    public MinStack() {
      stack=new Stack<int>();
      minstack =new Stack<int>();

        
    }
    
    public void Push(int value) {

        stack.Push(value);

        if(minstack.Count==0 || minstack.Peek()>=value )
        {
            minstack.Push(value);
        }
        
    }
    
    public void Pop() {

      int val=  stack.Pop();
        if (val == minstack.Peek()) {
            minstack.Pop();
        }
        
    }
    
    public int Top() {
       return stack.Peek();
        
    }
    
    public int GetMin() {
      return  minstack.Peek();
        
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(value);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */