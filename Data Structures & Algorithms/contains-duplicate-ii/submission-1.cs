public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        HashSet<int> numsHashSet = new HashSet<int>();
        int left = 0;
        for (int right = 0; right < nums.Length; right++) {
            if (right - left > k) {
                numsHashSet.Remove(nums[left]);
                left++;
            }
            if (numsHashSet.Contains(nums[right])) {
                return true;
            }
            numsHashSet.Add(nums[right]);
        }
        return false;
    }
}