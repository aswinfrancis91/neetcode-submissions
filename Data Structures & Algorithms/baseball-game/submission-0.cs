public class Solution {
    public int CalPoints(string[] operations) {
        List<int> output = new List<int>();
        for (int i = 0; i < operations.Length; i++) {
            if (operations[i] == "+") {
                output.Add(output[output.Count-1]+output[output.Count-2]);
            } else if (operations[i] == "D") {
                output.Add(output[output.Count-1] * 2);
            } else if (operations[i] == "C") {
                output.RemoveAt(output.Count-1);
            } else {
                output.Add(Int32.Parse(operations[i]));
            }
        }
        int total = 0;
        foreach (var number in output) {
            total = total + number;
        }
        return total;
    }
}