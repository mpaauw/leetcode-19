public class Solution {
    public int NumUniqueEmails(string[] emails) {
        var set = new HashSet<string>();
        int numUniqueEmails = 0;
        foreach(string email in emails)
        {
            var builder = new StringBuilder();
            var emailSplit = email.Split('@');
            string localName = emailSplit[0];
            string domainName = emailSplit[1];

            // first, process +:
            var plusSplit = localName.Split('+');

            // second, process .
            var dotRemove = plusSplit[0].Remove('.');

            // finally, concatenate with domain to find searchable string
            var finalEmailString = builder.Append(dotRemove, emailSplit).ToString();

            if(!set.Contains(finalEmailString))
            {
                set.Add(finalEmailString);
                numUniqueEmails++;
            }
        }
        return numUniqueEmails;
    }
}