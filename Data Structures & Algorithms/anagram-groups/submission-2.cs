public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();
        foreach (string s in strs) {
            var count = new int[26];
            foreach (char c in s) {
                count[c - 'a']++;
            }
            string key = String.Join(",", count);
            if (!map.TryGetValue(key, out List<string> existingValue)) {
                existingValue = new List<string>();
                map[key] = existingValue;
            }
            existingValue.Add(s);
        }
        return map.Values.ToList();
    }
}
