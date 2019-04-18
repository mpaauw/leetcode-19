public int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        int currentNum = nums[i];
        int diff = target - currentNum;
        if (dict.ContainsKey(diff))
        {
            return new int[] { i, dict[diff] };
        }
        else
        {
            if(!dict.ContainsKey(currentNum))
            {
                dict.Add(currentNum, i);
            }
        }
    }
    throw new Exception();
}