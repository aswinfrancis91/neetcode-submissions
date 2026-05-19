public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        int currentValue = 1;
        for (int i = 0; i < nums.Length; i++) {
            result[i] = currentValue;
            currentValue *= nums[i];
        }
        currentValue = 1;
        for (int i = nums.Length - 1; i >= 0; i--) {
            result[i] = result[i] * currentValue;
            currentValue *= nums[i];
        }
        return result;
    }
}
