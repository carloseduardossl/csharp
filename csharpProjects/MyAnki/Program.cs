public int[] TwoSum(int[] nums, int target)
{
    int[] sortedIndices = new int[nums.Length];
    for (int i = 0; i < sortedIndices.Length; i++)
    {
        sortedIndices[i] = i;
    }

    Array.Sort(sortedIndices, (a, b) => nums[a].CompareTo(nums[b]));

    int left = 0;
    int right = nums.Length - 1;

    while (left < right)
    {
        int sum = nums[sortedIndices[left]] + nums[sortedIndices[right]];

        if (sum == target)
        {
            return new int[] { sortedIndices[left], sortedIndices[right] };
        }
        else if (sum < target)
        {
            left++;
        }
        else
        {
            right--;
        }
    }

    return new int[] { -1, -1 };
}
