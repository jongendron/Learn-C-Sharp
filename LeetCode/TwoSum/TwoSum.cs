namespace TwoSum;

class Solution
{
    public int[] TwoSum_1(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[2] { i, j };
                }
            }
        }
        return new int[2];
    }

    public int[] TwoSum_2(int[] nums, int target)
    {
        Dictionary<int, int> elementTracker = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int toSolve = target - nums[i];
            if (elementTracker.ContainsKey(toSolve))
            {
                return new int[2] { elementTracker[toSolve], i };
            }
            elementTracker.Add(nums[i], i);
        }

        return new int[2];
    }
}