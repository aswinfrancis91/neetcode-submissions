public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        Dictionary<char, int> setOne = new Dictionary<char, int>();
        Dictionary<char, int> setTwo = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++) {
            setOne[s[i]] = setOne.GetValueOrDefault(s[i], 0) + 1;
            setTwo[t[i]] = setTwo.GetValueOrDefault(t[i], 0) + 1;
        }
        return setOne.Count == setTwo.Count && !setOne.Except(setTwo).Any();
    }
}
