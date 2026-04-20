public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int arrayLength=nums.Length;
        int newArraySize=2*arrayLength;
        int[] ans = new int[newArraySize];
        for(int i =0;i<arrayLength;i++){
            ans[i]=ans[i+arrayLength]=nums[i];
        }
        return ans;
    }
}