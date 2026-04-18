public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int currentOccurence=0;
        int maxOccurance=0;
        for(int i = 0;i<nums.Length;i++){
            if(nums[i]==1){
                currentOccurence++;
            }
            else{
                maxOccurance = currentOccurence > maxOccurance ? currentOccurence:maxOccurance;
                currentOccurence=0;
            }
        }
        maxOccurance = currentOccurence>maxOccurance? currentOccurence:maxOccurance;
        return maxOccurance;
    }
}