public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach(char c in s)
        {
            if(c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else {
                var current = (stack.Count > 1) ? stack.Pop() : '';
                if(c == ')')
                {
                    if(current != '(')
                    {
                        return false;
                    }
                }
                else if(c == ']')
                {
                    if(current != '[')
                    {
                        return false;
                    }
                }
                else if(c == '}')
                {
                    if(current != '{')
                    {
                        return false;
                    }
                }
            }
        }
        if(stack.Count != 0)
        {
            return false;
        }
        return true;
    }
}