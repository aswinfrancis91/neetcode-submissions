public class Solution {
    public string Encode(IList<string> strs) {
        var encodedString = new List<string>();
        foreach (string str in strs) {
            string temp = str.Length + "#" + str;
            encodedString.Add(temp);
        }
        return string.Concat(encodedString);
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        int i = 0;
        while (i < s.Length) {
            int delimiterIndex = s.IndexOf('#', i);
            int length = int.Parse(s.Substring(i, delimiterIndex - i));
            i = delimiterIndex + 1;
            result.Add(s.Substring(i, length));
            i = i + length;
        }
        return result;
    }
}