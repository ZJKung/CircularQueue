namespace CircularQueue;

/// <summary>
/// Initializes a new instance of the <see cref="CircularQueue{T}"/> class with the specified capacity.
/// Represents a circular queue data structure.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
public class CircularQueue<T>
{
    private readonly T[] _array;
    private int _head = 0;
    private int _tail = 0;
    private int _size = 0;
    /// <summary>
    /// Initializes a new instance of the <see cref="CircularQueue{T}"/> class with the specified capacity.
    /// </summary>
    /// <param name="capacity">The maximum number of elements that the queue can contain.</param>
    public CircularQueue(int capacity)
    {
        _array = new T[capacity];
    }

    /// <summary>
    /// Adds an element to the end of the queue.
    /// </summary>
    /// <param name="value">The element to add to the queue.</param>
    /// <returns><c>true</c> if the element was successfully added; otherwise, <c>false</c>.</returns>
    public bool Enqueue(T value)
    {
        // Implementation details omitted return false;
        _array[_tail] = value;
        _tail = (_tail + 1) % _array.Length;
        _size++;
        return true;
    }
    /// <summary>
    /// Removes and returns the element at the beginning of the queue.
    /// </summary>
    /// <returns>value if not empty, otherwise default</returns>
    public T Dequeue()
    {
        if (_size == 0)
            return default;

        T value = _array[_head];
        _head = (_head + 1) % _array.Length;
        _size--;
        return value;
    }
    /// <summary>
    /// Returns the element at the beginning of the queue without removing it.
    /// </summary>
    /// <returns></returns>
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
