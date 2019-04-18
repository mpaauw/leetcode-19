public class Solution {
    public int ClimbStairs(int n)
    {
        return ClimbRecurse(0, n, new int[n + 1]);
    }

    private int ClimbRecurse(int i, int n, int[] memo)
    {
        if (i > n)
        {
            return 0;
        }
        if (i == n)
        {
            return 1;
        }
        if (memo[i] > 0)
        {
            return memo[i];
        }

        memo[i] = ClimbRecurse(i + 1, n, memo) + ClimbRecurse(i + 2, n, memo);
        return memo[i];
    }
}