public class Solution {
    public bool IsValid(string s) {
        var charArray = s.ToCharArray();
        Stack<char> syntaxArray = new();
        foreach (char character in charArray) {
            switch (character) {
                case '(':
                case '{':
                case '[':
                    syntaxArray.Push(character);
                    break;
                case ')':
                    if (syntaxArray.Count > 0 && syntaxArray.Peek() == '(') {
                        syntaxArray.Pop();
                    } else
                        return false;
                    break;
                case '}':
                    if (syntaxArray.Count > 0 && syntaxArray.Peek() == '{') {
                        syntaxArray.Pop();
                    } else
                        return false;
                    break;
                case ']':
                    if (syntaxArray.Count > 0 && syntaxArray.Peek() == '[') {
                        syntaxArray.Pop();
                    } else
                        return false;
                    break;
            }
        }
        return syntaxArray.Count == 0;
    }
}
