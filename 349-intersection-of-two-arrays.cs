public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var set1 = new HashSet<int>();
        var set2 = new HashSet<int>();
        foreach(int item in nums1)
        {
            set1.Add(item);
        }
        foreach(int item in nums2)
        {
            set2.Add(item);
        }
        return (set1.Count < set2.Count) ? Intersect(set1, set2) : Intersect(set2, set1);
    }

    private int[] Intersect(HashSet<int> smallSet, HashSet<int> bigSet)
    {
        IList<int> result = new List<int>();
        foreach(int item in smallSet)
        {
            if(bigSet.Contains(item))
            {
                result.Add(item);
            }
        }
        return result.ToArray();
    }
}