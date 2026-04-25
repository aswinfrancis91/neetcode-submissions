public class MyStack {
    private Queue<int> _myQueue = null;
    private int _lastItem = 0;
    public MyStack() {
        _myQueue = new Queue<int>();
    }

    public void Push(int x) {
        _lastItem = x;
        _myQueue.Enqueue(x);
    }

    public int Pop() {
        for (int i = 0; i < _myQueue.Count - 1; i++) {
            _lastItem = _myQueue.Dequeue();
            _myQueue.Enqueue(_lastItem);
        }
        return _myQueue.Dequeue();
    }

    public int Top() {
        return _lastItem;
    }

    public bool Empty() {
        return _myQueue.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */