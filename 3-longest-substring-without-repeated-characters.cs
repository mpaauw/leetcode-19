public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> set = new HashSet<char>();
        int result = 0, i = 0, j = 0, n = s.Length;
        while (i < n && j < n)
        {
            if (!set.Contains(s[j]))
            {
                set.Add(s[j++]);
                result = Math.Max(result, j - i);
            }
            else
            {
                set.Remove(s[i++]);
            }
        }
        return result;
    }
}