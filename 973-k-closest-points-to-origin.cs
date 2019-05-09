public class Solution
{
    public int[][] KClosest(int[][] points, int K)
    {

        // use sorted set to store euclidean distances:
        int[][] result = new int[K][];
        Dictionary<int, double> dict = new Dictionary<int, double>(); // <index of point in points, distance>

        // calculate euclidean distances for each point, store in set:
        for(int i = 0; i < points.Length; i++)
        {
            int[] point = points[i];

            double distance = Math.Sqrt(Math.Pow(0 - point[0], 2) + Math.Pow(0 - point[1], 2));

            dict.Add(i, distance);
        }

        var sortedValues = dict.Values.ToArray();
        Array.Sort(sortedValues);

        for (int i = 0; i < K; i++)
        {
            int indexKey = dict.FirstOrDefault(x => x.Value == sortedValues[i]).Key;

            result[i] = points[indexKey];
            dict.Remove(indexKey); // don't double-tap points in result
        }

        return result;
    }
}