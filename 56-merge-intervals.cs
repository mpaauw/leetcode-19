public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        IList<int[]> mergedIntervals = new List<int[]>();
        Array.Sort(intervals, new IntervalComparer());
        foreach(int[] interval in intervals)
        {
            //int[] lastInterval = mergedIntervals.Last();
            if(mergedIntervals.Count < 1 || interval[0] > mergedIntervals.Last()[1])
            {
                mergedIntervals.Add(interval);
            }
            else
            {
                var lastInterval = mergedIntervals.Last();
                mergedIntervals[mergedIntervals.Count - 1] = new int[] { lastInterval[0], (interval[1] <= lastInterval[1]) ? lastInterval[1] : interval[1] };
            }
        }
        return mergedIntervals.ToArray();
    }

    public class IntervalComparer : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            int xStart = x[0];
            int yStart = y[0];
            if(xStart < yStart)
            {
                return -1;
            }
            else if(xStart == yStart)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }

}