using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("A", 1);
        queue.Enqueue("B", 3);
        queue.Enqueue("C", 2);

        Assert.AreEqual("B", queue.Dequeue());
        Assert.AreEqual("C", queue.Dequeue());
        Assert.AreEqual("A", queue.Dequeue());
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("Bob", 1);
        queue.Enqueue("Saleh", 3);
        queue.Enqueue("sue", 2);

        Assert.AreEqual("Saleh", queue.Dequeue());
        Assert.AreEqual("sue", queue.Dequeue());
        Assert.AreEqual("Bob", queue.Dequeue());
    }

    // Add more test cases as needed below.
}