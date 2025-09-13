using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
// // TODO Problem 2 - Write and run test cases and fix the code to match requirements.
[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Dequeue on an empty queue
    // Expected Result: Throws InvalidOperationException
    // Defect(s) Found: None
    public void TestPriorityQueue_DequeueEmpty_Throws()
    {
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with different priorities
    // Expected Result: Highest priority item returned first
    // Defect(s) Found: None
    public void TestPriorityQueue_ReturnsHighestPriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 10);

        string result = priorityQueue.Dequeue();

        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario: Two items with same highest priority
    // Expected Result: Returns the earliest (FIFO among equals)
    // Defect(s) Found: Would fail if code used >= instead of >
    public void TestPriorityQueue_FifoOnSamePriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 10);
        priorityQueue.Enqueue("Second", 10);

        string result = priorityQueue.Dequeue();

        Assert.AreEqual("First", result);
    }

    [TestMethod]
    // Scenario: Items removed after being dequeued
    // Expected Result: Queue size decreases; next highest returned next
    // Defect(s) Found: None
    public void TestPriorityQueue_RemovesDequeuedItems()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 5);

        string first = priorityQueue.Dequeue();
        string second = priorityQueue.Dequeue();

        Assert.AreEqual("B", first);
        Assert.AreEqual("A", second);
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}
