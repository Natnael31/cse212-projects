/// <summary>
/// A basic implementation of a Queue
/// </summary>

public class PersonQueue
{
    private readonly List<Person> _queue = new();

    public int Length => _queue.Count;

    /// <summary>
    /// Add a person to the queue
    /// </summary>
    /// <param name="person">The person to add</param>


    public void Enqueue(Person person)
    {
        _queue.Add(person); // add to end (back of queue)
    }

    public Person Dequeue()
    {
        if (_queue.Count == 0)
            throw new InvalidOperationException("Queue is empty.");

        var person = _queue[0]; // removes person from front
        _queue.RemoveAt(0);
        return person;
    }

    public bool IsEmpty()
    {
        return _queue.Count == 0;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}