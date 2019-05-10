public class Solution
{
    public int[][] KClosest(int[][] points, int K)
    {
        int[][] result = new int[K][];
        double[] distances = new double[points.Length];
        for (int i = 0; i < points.Length; i++)
        {
            int[] point = points[i];
            double distance = Math.Sqrt(Math.Pow(0 - point[0], 2) + Math.Pow(0 - point[1], 2));
            distances[i] = distance;
        }
        Array.Sort(distances);
        double distanceThreshold = distances[K - 1];
        int iter = 0;
        for (int i = 0; i < points.Length; i++)
        {
            int[] point = points[i];
            double distance = Math.Sqrt(Math.Pow(0 - point[0], 2) + Math.Pow(0 - point[1], 2));
            if (distance <= distanceThreshold)
            {
                result[iter++] = point;
            }
        }
        return result;
    }
}