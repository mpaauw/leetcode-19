public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {

        int[] mergedArray = new int[nums1.Length + nums2.Length];
        int p1 = 0, p2 = 0, iter = 0;

        // merge arrays
        while (p1 < nums1.Length && p2 < nums2.Length)
        {
            // comparison, add to merged arr, increment merged arr iterator:
            if (nums1[p1] <= nums2[p2])
            {
                mergedArray[iter++] = nums1[p1++];
            }
            else
            {
                mergedArray[iter++] = nums2[p2++];
            }
        }

        // empty remaining elements from nums1 or nums2:
        while(p1 < nums1.Length)
        {
            mergedArray[iter++] = nums1[p1++];
        }
        while(p2 < nums2.Length)
        {
            mergedArray[iter++] = nums2[p2++];
        }

        int setSize = mergedArray.Length;

        // find median, accounting for even set
        if (setSize % 2 == 0) // if even set size, return average of middle-two elements
        {
            return (double)(mergedArray[setSize / 2] + mergedArray[(setSize / 2) - 1]) / 2;
        }
        else
        { // if odd set size, return middle element.
            return mergedArray[setSize / 2];
        }
    }
}