public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int left = 1;
        int right = 1;
        while (right < nums.Length) {
            if (nums[right - 1] != nums[right]) {
                nums[left] = nums[right];
                left++;
            }
            right++;
        }
        return left;
    }
}