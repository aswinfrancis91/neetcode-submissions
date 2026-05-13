public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var queue = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        var count = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            if (!count.ContainsKey(nums[i])) {
                count.Add(nums[i], 0);
            }
            count[nums[i]]++;
        }
        foreach (var item in count) {
            queue.Enqueue(item.Key, item.Value);
        }
        var result = new int[k];
        for (int i = 0; i < k; i++) {
            result[i] = queue.Dequeue();
        }
        return result;
    }
}
