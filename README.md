# CircularQueue

## Description

`CircularQueue` is a generic circular queue data structure implementation in C#. It allows for efficient use of space by reusing the array slots as elements are dequeued and enqueued.

## Installation

To use the `CircularQueue` class in your project, simply include the `CircularQueue.cs` file in your project.

## Usage

Here are some examples of how to use the `CircularQueue` class:

### Initialization

```csharp

// Create a circular queue with a capacity of 5
CircularQueue<int> queue = new CircularQueue<int>(5);// Add elements to the queue
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);// Remove and return the element at the beginning of the queue
int firstElement = queue.Dequeue(); // firstElement will be 1// Return the element at the beginning of the queue without removing it
int nextElement = queue.Peek(); // nextElement will be 2// Get the number of elements in the queue
int count = queue.Count; // count will be 2// Clear all elements from the queue
queue.Clear();
```
