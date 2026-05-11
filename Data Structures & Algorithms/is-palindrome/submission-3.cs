public class Solution {
    public bool IsPalindrome(string s) {
        var testString = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();
        var charArray = testString.ToCharArray();
        int left = 0;
        for (int right = charArray.Length - 1; left<=right; right--) {
            if (charArray[left] == charArray[right]) {
                left++;
                continue;
            }
            return false;
        }
        return true;
    }
}