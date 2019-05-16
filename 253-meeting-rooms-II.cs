public class Solution
{
    public int MinMeetingRooms(int[][] intervals)
    {
        // build buffer:
        int max = 0;
        foreach (int[] interval in intervals)
        {
            if (interval[1] > max)
            {
                max = interval[1];
            }
        }
        int[] buffer = new int[max];

        // populate:
        int numRooms = 0;
        foreach (int[] interval in intervals)
        {
            for (int i = interval[0]; i < interval[1]; i++)
            {
                buffer[i]++;
                if (buffer[i] > numRooms)
                {
                    numRooms = buffer[i];
                }
            }
        }

        return numRooms;
    }
}