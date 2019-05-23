public class Solution
{
    public int Reverse(int x)
    {
        bool isSigned = (x < 0) ? true : false;
        int result = 0;
        x = (x < 0) ? x *= -1 : x; // remove sign, if applicable
        while (x > 0)
        {
            if(result > 0 && Int32.MaxValue / result < 10)
            {
                return 0;
            }
            result *= 10;
            result += x % 10;
            x /= 10;
        }
        return (isSigned) ? result * -1 : result; // re-add sign, if applicable
    }
}