public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        int result = students.Length;
        int[] studentHashMap = new int[2];
        for (int i = 0; i < students.Length; i++) {
            studentHashMap[students[i]]++;
        }
        for (int i = 0; i < sandwiches.Length; i++) {
            if (studentHashMap[sandwiches[i]] > 0) {
                result--;
                studentHashMap[sandwiches[i]]--;
            }
            else{
                return result;
            }
        }
        return result;
    }
}