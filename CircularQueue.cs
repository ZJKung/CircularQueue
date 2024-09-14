namespace CircularQueue;

public class CircularQueue<T>
{
    private T[] _array;
    private int _head;
    private int _tail;
    private int _size;

    public CircularQueue(int capacity)
    {
        _array = new T[capacity];
        _head = 0;
        _tail = 0;
        _size = 0;
    }

    public bool Enqueue(T value)
    {
        if (_size == _array.Length)
            return false;

        _array[_tail] = value;
        _tail = (_tail + 1) % _array.Length;
        _size++;
        return true;
    }

    public T Dequeue()
    {
        if (_size == 0)
            return default;

        T value = _array[_head];
        _head = (_head + 1) % _array.Length;
        _size--;
        return value;
    }

    public T Peek()
    {
        if (_size == 0)
            return default;

        return _array[_head];
    }

    public int Count => _size;

    public void Clear()
    {
        _head = 0;
        _tail = 0;
        _size = 0;
    }
}
