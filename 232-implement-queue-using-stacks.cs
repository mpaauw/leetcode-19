public class MyQueue {

    private Stack<int> inStack;
    private Stack<int> outStack;

    /** Initialize your data structure here. */
    public MyQueue() {
        this.inStack = new Stack<int>();
        this.outStack = new Stack<int>();
    }
    
    /** Push element x to the back of queue. */
    public void Push(int x) {
        if(inStack.Count == 0 && outStack.Count > 0)
        {
            Transfer(outStack, inStack);
        }
        this.inStack.Push(x);
    }
    
    /** Removes the element from in front of queue and returns that element. */
    public int Pop() {
        if(Empty())
        {
            throw new ArgumentException("Queue is empty!");
        }
        else if(outStack.Count == 0 && inStack.Count > 0)
        {
            Transfer(inStack, outStack);
        }
        return outStack.Pop();
    }
    
    /** Get the front element. */
    public int Peek() {
        if(Empty())
        {
            throw new ArgumentException("Queue is empty!");
        }
        else if(outStack.Count == 0 && inStack.Count > 0)
        {
            Transfer(inStack, outStack);
        }
        return outStack.Peek();
    }
    
    /** Returns whether the queue is empty. */
    public bool Empty() {
        return inStack.Count == 0 && outStack.Count == 0;
    }

    private void Transfer(Stack<int> source, Stack<int> destination)
    {
        while(source.Count > 0)
        {
            destination.Push(source.Pop());
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