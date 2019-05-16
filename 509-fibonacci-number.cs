public class Solution
{
    public int Fib(int N)
    {
        if (N == 1)
        {
            return 1;
        }
        else if (N == 0)
        {
            return 0;
        }
        return Fib(N - 1) + Fib(N - 2);
    }
}