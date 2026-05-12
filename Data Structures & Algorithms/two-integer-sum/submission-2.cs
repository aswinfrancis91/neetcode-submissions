public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new Dictionary<int, int>();
        seen.Add(nums[0], 0);
        for (int right = 1; right < nums.Length; right++) {
            var diff = target - nums[right];
            if (seen.TryGetValue(diff, out int left)) {
                return [left, right];
            }
            seen.Add(nums[right], right);
        }
        return null;
    }
}