using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Adding and removing a single item
    // Expected Result: The item is returned when dequeued
    // Defect(s) Found: None
    public void TestPriorityQueue_SingleItem()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 1);
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Item1", result);
    }

    [TestMethod]
    // Scenario: Removing from an empty queue
    // Expected Result: InvalidOperationException is thrown
    // Defect(s) Found: None
    [ExpectedException(typeof(InvalidOperationException))]
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();
    }

    [TestMethod]
    // Scenario: Handling items with different priorities
    // Expected Result: The highest priority item is dequeued
    // Defect(s) Found: None
    public void TestPriorityQueue_DifferentPriorities()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("LowPriority", 1);
        priorityQueue.Enqueue("HighPriority", 10);
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("HighPriority", result);
    }

    [TestMethod]
    // Scenario: Handling items with the same priority (FIFO)
    // Expected Result: The first item with the highest priority is dequeued
    // Defect(s) Found: None
    public void TestPriorityQueue_SamePriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("FirstHigh", 5);
        priorityQueue.Enqueue("SecondHigh", 5);
        var result1 = priorityQueue.Dequeue();
        var result2 = priorityQueue.Dequeue();
        Assert.AreEqual("FirstHigh", result1);
        Assert.AreEqual("SecondHigh", result2);
    }

    [TestMethod]
    // Scenario: Adding multiple items and checking order
    // Expected Result: Items are dequeued according to priority and FIFO within same priority
    // Defect(s) Found: None
    public void TestPriorityQueue_MultipleItems()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Medium1", 5);
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium2", 5);
        priorityQueue.Enqueue("High", 10);

        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium1", priorityQueue.Dequeue());
        Assert.AreEqual("Medium2", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}
