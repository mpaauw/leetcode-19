public class Solution
{
    public void ReverseString(char[] s)
    {
        int head = 0;
        int tail = s.Length - 1;
        while(head <= tail)
        {
            char temp = s[head];
            s[head] = s[tail];
            s[tail] = temp;
            head++;
            tail--;
        }
    }
}