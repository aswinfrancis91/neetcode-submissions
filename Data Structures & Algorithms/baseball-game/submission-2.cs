public class Solution {
    public int CalPoints(string[] operations) {
        List<int> output = new List<int>();
        int sum = 0;
        for (int i = 0; i < operations.Length; i++) {
            if (operations[i] == "+") {
                var total = output[output.Count - 1] + output[output.Count - 2];
                sum += total;
                output.Add(total);
            } else if (operations[i] == "D") {
                var total = output[output.Count - 1] * 2;
                sum += total;
                output.Add(total);
            } else if (operations[i] == "C") {
                var lastDigit = output[output.Count - 1];
                sum -= lastDigit;
                output.RemoveAt(output.Count - 1);
            } else {
                var total = Int32.Parse(operations[i]);
                sum += total;
                output.Add(total);
            }
        }
        return sum;
    }
}