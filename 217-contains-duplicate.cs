public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            if(set.Contains(num))
            {
                return true;
            }
            set.Add(num);           
        }
        return false;
    }
}