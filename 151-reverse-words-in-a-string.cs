public class Solution
{
    public string ReverseWords(string s)
    {
        string[] words = s.Trim().Split(' ');
        StringBuilder builder = new StringBuilder();
        for (int i = words.Length - 1; i >= 0; i--)
        {
            string word = words[i].Trim();
            if (String.IsNullOrWhiteSpace(word))
            {
                continue;
            }
            if (i == 0)
            {
                builder.Append(word);
            }
            else
            {
                builder.Append($"{word} ");
            }
        }
        return builder.ToString();
    }
}