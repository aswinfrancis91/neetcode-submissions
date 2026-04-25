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
        if(_myQueue.Count==1){
            return _myQueue.Dequeue();
        }
        var tempQueue = new Queue<int>();
        for (int i = 0; i < _myQueue.Count; i++) {
            _lastItem = _myQueue.Dequeue();
            tempQueue.Enqueue(_lastItem);
        }
        var topItem = _myQueue.Dequeue();
        _myQueue = tempQueue;
        return topItem;
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